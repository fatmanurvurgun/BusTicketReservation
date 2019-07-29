using BilgeTurizm.DATA;
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
    public partial class OzetEkrani : Form
    {
        string pnrKodu;
        int yolcuSayisi = 0;
        public OzetEkrani()
        {
            InitializeComponent();
        }

        public OzetEkrani(string pnr)
        {
            InitializeComponent();
            pnrKodu = pnr;
        }

        private void OzetEkrani_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(pnrKodu))
            {
                foreach (Bilet bilet in Metotlar.db.BiletTablo.Where(x => x.PnrKodu == pnrKodu).ToList())
                {
                    Label adSoyad = new Label();
                    adSoyad.Width = 74;
                    adSoyad.Text = bilet.Musteri.Ad + " " + bilet.Musteri.SoyAd;

                    Label tcNo = new Label();
                    tcNo.Width = 74;
                    tcNo.Text = bilet.Musteri.TcNo;

                    Label nereden = new Label();
                    nereden.Width = 74;
                    nereden.Text = Metotlar.SehirBul(bilet.SeferBiletBilgisi.Nereden);

                    Label nereye = new Label();
                    nereye.Width = 74;
                    nereye.Text = Metotlar.SehirBul(bilet.SeferBiletBilgisi.Nereye);

                    Label seferTarihi = new Label();
                    seferTarihi.Width = 74;
                    seferTarihi.Text = bilet.KalkisTarihi.ToShortDateString();

                    Label seferSaati = new Label();
                    seferSaati.Width = 74;
                    seferSaati.Text = bilet.SeferBiletBilgisi.OtobusTipi == "Standart" ? "11:00" : "13:00";

                    Label koltukNo = new Label();
                    koltukNo.Width = 74;
                    koltukNo.Text = bilet.KoltukNo.ToString();

                    Label biletSinifi = new Label();
                    biletSinifi.Width = 74;
                    biletSinifi.Text = (bilet.SeferBiletBilgisi.OtobusTipi == "Suit" && bilet.KoltukNo <= 8) ? "VIP" : "Standart";

                    Label otobusTipi = new Label();
                    otobusTipi.Width = 74;
                    otobusTipi.Text = bilet.SeferBiletBilgisi.OtobusTipi;

                    Label yemek = new Label();
                    yemek.Width = 74;
                    yemek.Text = Metotlar.YemekAdi(bilet.YemekID);

                    ozetPaneli.Controls.AddRange(new Control[] { adSoyad, tcNo, nereden, nereye, seferTarihi, seferSaati, koltukNo, biletSinifi, otobusTipi, yemek });


                }

                lblToplamUcret.Text = string.Format("{0:c2}", Metotlar.db.BiletTablo.FirstOrDefault(x => x.PnrKodu == pnrKodu).ToplamFiyat);
                lblPnrKodu.Text = pnrKodu;

                return;
            }


            GidisMusterileriYazdir();

            if (Bilgiler.SeyahatTipi == SeyehatTipi.GidisDonus)
            {
                DonusMusterileriYazdir();
            }

            if (Bilgiler.SigortaVarMi)
            {
                lblBilet.Visible = true;
                lblBiletUcreti.Text = string.Format("{0:c}", Bilgiler.ToplamFiyat - (20 * yolcuSayisi));
                lblBiletUcreti.Visible = true;

                lblSigorta.Visible = true;
                lblSigortaUcreti.Text = string.Format("{0:c}", 20 * yolcuSayisi);
                lblSigortaUcreti.Visible = true;
            }

            lblToplamUcret.Text = string.Format("{0:c}", Bilgiler.ToplamFiyat);
            lblPnrKodu.Text = Bilgiler.PNRKodu;

        }

        private void DonusMusterileriYazdir()
        {
            foreach (Yolcu yolcu in Bilgiler.DonusMusteriler)
            {
                Label adSoyad = new Label();
                adSoyad.Width = 74;
                adSoyad.Text = yolcu.Ad + " " + yolcu.SoyAd;

                Label tcNo = new Label();
                tcNo.Width = 74;
                tcNo.Text = yolcu.TcNo;

                Label nereden = new Label();
                nereden.Width = 74;
                nereden.Text = Metotlar.SehirBul(Bilgiler.NereyeSehir);

                Label nereye = new Label();
                nereye.Width = 74;
                nereye.Text = Metotlar.SehirBul(Bilgiler.NeredenSehir);

                Label seferTarihi = new Label();
                seferTarihi.Width = 74;
                seferTarihi.Text = Bilgiler.DonusTarihi.ToShortDateString();

                Label seferSaati = new Label();
                seferSaati.Width = 74;
                seferSaati.Text = Bilgiler.DonusSaati;

                Label koltukNo = new Label();
                koltukNo.Width = 74;
                koltukNo.Text = yolcu.koltukNo.ToString();

                Label biletSinifi = new Label();
                biletSinifi.Width = 74;
                biletSinifi.Text = (Bilgiler.DonusOtobusTipi == OtobusTipi.Suit && yolcu.koltukNo <= 8) ? "VIP" : "Standart";

                Label otobusTipi = new Label();
                otobusTipi.Width = 74;
                otobusTipi.Text = Bilgiler.DonusOtobusTipi == OtobusTipi.Standart ? "Standart" : "Suit";

                Label yemek = new Label();
                yemek.Width = 74;
                yemek.Text = Metotlar.YemekAdi(yolcu.yemekID);

                ozetPaneli.Controls.AddRange(new Control[] { adSoyad, tcNo, nereden, nereye, seferTarihi, seferSaati, koltukNo, biletSinifi, otobusTipi, yemek });
                yolcuSayisi++;
            }
        }

        private void GidisMusterileriYazdir()
        {
            foreach (Yolcu yolcu in Bilgiler.GidisMusteriler)
            {
                Label adSoyad = new Label();
                adSoyad.Width = 74;
                adSoyad.Text = yolcu.Ad + " " + yolcu.SoyAd;

                Label tcNo = new Label();
                tcNo.Width = 74;
                tcNo.Text = yolcu.TcNo;

                Label nereden = new Label();
                nereden.Width = 74;
                nereden.Text = Metotlar.SehirBul(Bilgiler.NeredenSehir);

                Label nereye = new Label();
                nereye.Width = 74;
                nereye.Text = Metotlar.SehirBul(Bilgiler.NereyeSehir);

                Label seferTarihi = new Label();
                seferTarihi.Width = 74;
                seferTarihi.Text = Bilgiler.GidisTarihi.ToShortDateString();

                Label seferSaati = new Label();
                seferSaati.Width = 74;
                seferSaati.Text = Bilgiler.GidisSaati;

                Label koltukNo = new Label();
                koltukNo.Width = 74;
                koltukNo.Text = yolcu.koltukNo.ToString();

                Label biletSinifi = new Label();
                biletSinifi.Width = 74;
                biletSinifi.Text = (Bilgiler.GidisOtobusTipi == OtobusTipi.Suit && yolcu.koltukNo <= 8) ? "VIP" : "Standart";

                Label otobusTipi = new Label();
                otobusTipi.Width = 74;
                otobusTipi.Text = Bilgiler.GidisOtobusTipi == OtobusTipi.Standart ? "Standart" : "Suit";

                Label yemek = new Label();
                yemek.Width = 74;
                yemek.Text = Metotlar.YemekAdi(yolcu.yemekID);

                ozetPaneli.Controls.AddRange(new Control[] { adSoyad, tcNo, nereden, nereye, seferTarihi, seferSaati, koltukNo, biletSinifi, otobusTipi, yemek });

                yolcuSayisi++;
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi tercih ettiğiniz için çok teşekkür ederiz. İyi ki varsınız :)");
            System.Windows.Forms.Application.Exit();
        }

        private void OzetEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
