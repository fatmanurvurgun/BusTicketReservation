using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeTurizmUI
{
    public partial class SuitOtobus : Form
    {
        public Form gdForm;
        public bool ikinciOtobusTipi;
        public Dictionary<int, string> gidistekiKoltuklar;
        public Dictionary<int, string> donustekiKoltuklar;
        public bool YolcuBilgilerineGitsinMi;


        public SuitOtobus(Form gelenForm, bool ikinciOtobus)
        {
            InitializeComponent();
            gdForm = gelenForm;
            ikinciOtobusTipi = ikinciOtobus;
        }

        public SuitOtobus(Form form)
        {
            InitializeComponent();
            gdForm = form;
        }

        private void IkinciOtobus_Load(object sender, EventArgs e)
        {
            if (gdForm.GetType() == typeof(GidisDonus))
            {
                //Gidişi SUIT seçen
                gidistekiKoltuklar = new Dictionary<int, string>();
                Metotlar.KoltukYukle(Bilgiler.GidisTarihi, Bilgiler.GidisSeferID, grpSuitOtobus);
                YolcuBilgilerineGitsinMi = false;
            }
            else if (gdForm.GetType() == typeof(TekYon))
            {
                gidistekiKoltuklar = new Dictionary<int, string>();
                Metotlar.KoltukYukle(Bilgiler.GidisTarihi, Bilgiler.GidisSeferID, grpSuitOtobus);
                YolcuBilgilerineGitsinMi = true;
            }
            else
            {
                //Dönüşü SUIT Seçen
                donustekiKoltuklar = new Dictionary<int, string>();
                gidistekiKoltuklar = Bilgiler.GidisSecilenKoltuklar;
                Metotlar.KoltukYukle(Bilgiler.DonusTarihi, Bilgiler.DonusSeferID, grpSuitOtobus);
                YolcuBilgilerineGitsinMi = true;
            }
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            if (gidistekiKoltuklar.Count == 0)
            {
                MessageBox.Show("En az bir koltuk seçiniz!");
                return;
            }

            if (YolcuBilgilerineGitsinMi)
            {
                if (Bilgiler.SeyahatTipi == SeyehatTipi.GidisDonus)
                {
                    if (donustekiKoltuklar.Count == 0)
                    {
                        MessageBox.Show("Lütfen en az 1 koltuk seçiniz.");
                        return;
                    }
                    else if (Bilgiler.GidisSecilenKoltuklar.Count != donustekiKoltuklar.Count)
                    {
                        MessageBox.Show("Lütfen " + (gidistekiKoltuklar.Count - donustekiKoltuklar.Count) + " koltuk daha seçiniz!");
                        return;
                    }
                    else
                    {
                        Bilgiler.DonusSecilenKoltuklar = donustekiKoltuklar;
                    }

                }
                else
                {
                    Bilgiler.GidisSecilenKoltuklar = gidistekiKoltuklar;
                }

                YolcuBilgileri yb = new YolcuBilgileri();
                yb.Show();
                Hide();

            }
            else
            {
                Bilgiler.GidisSecilenKoltuklar = gidistekiKoltuklar;
                if (ikinciOtobusTipi)
                {
                    StandartOtobus birinciOtobus = new StandartOtobus(this);
                    birinciOtobus.Show();
                    Hide();
                }
                else
                {
                    SuitOtobus ikinciOtobus = new SuitOtobus(this);
                    ikinciOtobus.Show();
                    Hide();
                }
            }

        }

        private void koltukSec_Click(object sender, EventArgs e)
        {
            PictureBox koltuk = sender as PictureBox;
            if (YolcuBilgilerineGitsinMi == true)
            {
                // Ya şu an dönüş koltuklarını seçiyordur.
                // Ya da sadece gidiş seçmiştir ama suit seçmiştir ve bu adımdan sonra yolcu bilgilerini girecektir.
                if (Bilgiler.SeyahatTipi == SeyehatTipi.TekYon)
                {
                    Metotlar.GidenKoltuklariSec(this, koltuk, gidistekiKoltuklar);
                }
                else
                {
                    DonusKoltuklariSec(koltuk);
                }
            }
            else
            {
                // Giden yolcu koltuklarını seçiyordur.
                Metotlar.GidenKoltuklariSec(this, koltuk, gidistekiKoltuklar);
            }
        }

        private void DonusKoltuklariSec(PictureBox koltuk)
        {
            int secilenKoltuk = Convert.ToInt32(koltuk.Name.Substring(10, (koltuk.Name.Length - 10)));
            if (koltuk.BackColor == Color.Lime)
            {
                koltuk.BackColor = SystemColors.Control;
                donustekiKoltuklar.Remove(secilenKoltuk);
            }
            else
            {
                if (donustekiKoltuklar.Count >= gidistekiKoltuklar.Count)
                {
                    MessageBox.Show("Maksimum " + gidistekiKoltuklar.Count + " koltuk seçebilirsiniz.");
                }
                else
                {
                    koltuk.BackColor = Color.Lime;
                    if (secilenKoltuk <= 8)
                    {
                        donustekiKoltuklar.Add(secilenKoltuk, "farketmez");
                        return;
                    }

                    if (secilenKoltuk % 2 == 0)
                    {
                        //Çift sayı ise koltuk numarasının bir eksiğine bakarız.
                        string yandakiKoltukName = "pictureBox" + (secilenKoltuk - 1);
                        PictureBox pb = (PictureBox)Controls.Find(yandakiKoltukName, true)[0];
                        if (pb.Tag != null && pb.Tag.ToString() == "1")
                        {
                            donustekiKoltuklar.Add(secilenKoltuk, "erkek");
                        }
                        else if (pb.Tag != null && pb.Tag.ToString() == "0")
                        {
                            donustekiKoltuklar.Add(secilenKoltuk, "kadın");
                        }
                        else
                        {
                            donustekiKoltuklar.Add(secilenKoltuk, "farketmez");
                        }
                    }
                    else
                    {
                        //Tek sayı ise koltuk numarasının bir fazlasına bakarız.
                        string yandakiKoltukName = "pictureBox" + (secilenKoltuk + 1);
                        PictureBox pb = (PictureBox)Controls.Find(yandakiKoltukName, true)[0];
                        if (pb.Tag != null && pb.Tag.ToString() == "1")
                        {
                            donustekiKoltuklar.Add(secilenKoltuk, "erkek");
                        }
                        else if (pb.Tag != null && pb.Tag.ToString() == "0")
                        {
                            donustekiKoltuklar.Add(secilenKoltuk, "kadın");
                        }
                        else
                        {
                            donustekiKoltuklar.Add(secilenKoltuk, "farketmez");
                        }
                    }

                }
            }
        }

        private void IkinciOtobus_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
