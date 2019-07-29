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
    public partial class GidisDonus : Form
    {
        public AnaForm anaform;
        public GidisDonus(AnaForm gelenForm)
        {
            InitializeComponent();
            anaform = gelenForm;
        }

        private void GidisDonus_Load(object sender, EventArgs e)
        {
            label1.Text = anaform.cmbNereden.Text + " - " + anaform.cmbNereye.Text + " Seferi";
            label8.Text = anaform.cmbNereye.Text + " - " + anaform.cmbNereden.Text + " Seferi";
            rdbGidisSeferStandart.Checked = true;
            rdbDonusSeferStandart.Checked = true;


            //Kampanya var mı kontrolü
            decimal standartGidisFiyat = Metotlar.db.SeferBilgiTablo.FirstOrDefault(x => x.Nereden == Bilgiler.NeredenSehir && x.Nereye == Bilgiler.NereyeSehir && x.OtobusTipi == "Standart").Ucret;
            decimal suitGidisFiyat = Metotlar.db.SeferBilgiTablo.FirstOrDefault(x => x.Nereden == Bilgiler.NeredenSehir && x.Nereye == Bilgiler.NereyeSehir && x.OtobusTipi == "Suit").Ucret;

            decimal standartDonusFiyat = Metotlar.db.SeferBilgiTablo.FirstOrDefault(x => x.Nereden == Bilgiler.NereyeSehir && x.Nereye == Bilgiler.NeredenSehir && x.OtobusTipi == "Standart").Ucret;

            decimal suitDonusFiyati = Metotlar.db.SeferBilgiTablo.FirstOrDefault(x => x.Nereden == Bilgiler.NereyeSehir && x.Nereye == Bilgiler.NeredenSehir && x.OtobusTipi == "Suit").Ucret;

            lblStandartGidis.Text = string.Format("{0:c}", standartGidisFiyat);
            lblSuitGidis.Text = string.Format("{0:c}", suitGidisFiyat);

            lblStandartDonus.Text = string.Format("{0:c}", standartDonusFiyat);
            lblSuitDonus.Text = string.Format("{0:c}", suitDonusFiyati);

            if(standartGidisFiyat >= suitGidisFiyat) { lblKampanya.Show();  }
            if(standartDonusFiyat >= suitDonusFiyati) { lblKampanyaDonus.Show();  }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Hide();
            anaform.Show();
        }

        private void btnSeferSec_Click(object sender, EventArgs e)
        {
            Bilgiler.GidisSeferID = Metotlar.SeferIDBul(Bilgiler.NeredenSehir, Bilgiler.NereyeSehir, (rdbGidisSeferStandart.Checked ? "Standart" : "Suit"));
            Bilgiler.DonusSeferID = Metotlar.SeferIDBul(Bilgiler.NereyeSehir, Bilgiler.NeredenSehir, (rdbDonusSeferStandart.Checked ? "Standart" : "Suit"));
            if (!Metotlar.YerVarMi(Bilgiler.GidisSeferID, Bilgiler.GidisTarihi))
            {
                MessageBox.Show("Gidiş seferimizde boş koltuk bulunmamaktadır.");
                return;
            }
            else if (!Metotlar.YerVarMi(Bilgiler.DonusSeferID, Bilgiler.DonusTarihi))
            {
                MessageBox.Show("Donüş seferimizde boş koltuk bulunmamaktadır.");
                return;
            }

            Bilgiler.GidisOtobusTipi = rdbGidisSeferStandart.Checked ? OtobusTipi.Standart : OtobusTipi.Suit;
            Bilgiler.DonusOtobusTipi = rdbDonusSeferStandart.Checked ? OtobusTipi.Standart : OtobusTipi.Suit;
            Bilgiler.GidisSaati = rdbGidisSeferStandart.Checked ? "11:00" : "13:00";
            Bilgiler.DonusSaati = rdbDonusSeferStandart.Checked ? "11:00" : "13:00";

            //Eğer dönüş seferi standart ise TRUE değeri gönderilir.
            //Eğer dönüş seferi suit ise FALSE değeri gönderilir.
            if (rdbGidisSeferStandart.Checked)
            {
                StandartOtobus birinciOtobus = new StandartOtobus(this, rdbDonusSeferStandart.Checked);
                birinciOtobus.Show();

                Hide();
            }
            else
            {
                SuitOtobus ikinciOtobus = new SuitOtobus(this, rdbDonusSeferStandart.Checked);
                ikinciOtobus.Show();
                Hide();
            }

        }

        private void GidisDonus_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaform.Show();
        }
    }
}
