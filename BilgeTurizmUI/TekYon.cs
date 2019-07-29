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
    public partial class TekYon : Form
    {
        AnaForm anaForm;
        public TekYon(AnaForm gelenForm)
        {
            InitializeComponent();
            anaForm = gelenForm;
        }

        private void btnSeferSec_Click(object sender, EventArgs e)
        {
            Bilgiler.GidisSeferID = Metotlar.SeferIDBul(Bilgiler.NeredenSehir, Bilgiler.NereyeSehir, (rdbGidisSeferPre.Checked ? "Standart" : "Suit"));
            if (!Metotlar.YerVarMi(Bilgiler.GidisSeferID, Bilgiler.GidisTarihi))
            {
                MessageBox.Show("Bu seferimizde boş koltuk bulunmamaktadır.");
                return;
            }

            Bilgiler.GidisOtobusTipi = rdbGidisSeferPre.Checked ? OtobusTipi.Standart : OtobusTipi.Suit;

            //Standart tip otobüs radio button seçiliyse sefer saati 11:00 , Suit tip otobüs seçilecekse 13:00 olarak ayarlanır.
            Bilgiler.GidisSaati = rdbGidisSeferPre.Checked ? "11:00" : "13:00";

            if (rdbGidisSeferPre.Checked)
            {
                StandartOtobus standart = new StandartOtobus(this);
                standart.Show();
                Hide();
            }
            else
            {
                SuitOtobus suit = new SuitOtobus(this);
                suit.Show();
                Hide();
            }

        }

        private void Gidis_Load(object sender, EventArgs e)
        {
            label1.Text = anaForm.cmbNereden.Text + " - " + anaForm.cmbNereye.Text + " Seferi";
            rdbGidisSeferPre.Checked = true;

            decimal standartFiyat = Metotlar.db.SeferBilgiTablo.FirstOrDefault(x => x.Nereden == Bilgiler.NeredenSehir && x.Nereye == Bilgiler.NereyeSehir && x.OtobusTipi == "Standart").Ucret;

            decimal suitFiyat = Metotlar.db.SeferBilgiTablo.FirstOrDefault(x => x.Nereden == Bilgiler.NeredenSehir && x.Nereye == Bilgiler.NereyeSehir && x.OtobusTipi == "Suit").Ucret;

            lblStandartFiyat.Text = string.Format("{0:c}", standartFiyat);
            lblSuitFiyat.Text = string.Format("{0:c}", suitFiyat);

            if(standartFiyat >= suitFiyat ) { lblKampanya.Show(); }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Hide();
            anaForm.Show();
        }

        private void Gidis_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }
    }
}
