using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgeTurizm.DATA;
using BİlgeTurizm.DAL;
using System.Data.Entity.Validation;

namespace BilgeTurizmUI
{
    public partial class OdemeEkrani : Form
    {
        string pnrKodu;
        bool rezerveMi;

        public OdemeEkrani()
        {
            InitializeComponent();
            rezerveMi = false;
            pnrKodu = Bilgiler.PNRKodu;
        }

        public OdemeEkrani(string PNRKodu)
        {
            InitializeComponent();
            pnrKodu = PNRKodu;
            rezerveMi = true;
        }

        private void OdemeEkrani_Load(object sender, EventArgs e)
        {
            rdbMasterCard.Checked = true;
            if (rezerveMi)
            {
                lblToplamUcret.Text = string.Format("{0:c2}", Metotlar.db.BiletTablo.FirstOrDefault(x => x.PnrKodu == pnrKodu).ToplamFiyat);
                return;
            }
            ToplamFiyatHesapla();
            lblToplamUcret.Text = Convert.ToInt32(Bilgiler.ToplamFiyat) + " TL";
            

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {

            if (!Metotlar.BosAlanVarMi(grpKartBilgileri))
            {
                if (rezerveMi)
                {
                    List<Bilet> biletler = Metotlar.db.BiletTablo.Where(x => x.PnrKodu == pnrKodu).ToList();
                    foreach (Bilet bilet in biletler)
                    {
                        bilet.RezerveMi = false;
                        Metotlar.db.SaveChanges();
                    }
                    OzetEkrani ob = new OzetEkrani(pnrKodu);
                    ob.Show();
                    Hide();
                    return;
                }

                
               
                GidenYolculariKaydet();

                if (Bilgiler.SeyahatTipi == SeyehatTipi.GidisDonus)
                {
                    DonusYolculariKaydet();
                }

                OzetEkrani oe = new OzetEkrani();
                oe.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız ve Geçerli Değerler Giriniz...");
                return;
            }
        }

        private void DonusYolculariKaydet()
        {
            
            foreach (Yolcu item in Bilgiler.DonusMusteriler)
            {
                Musteriler musteri = new Musteriler();
                musteri.Ad = item.Ad;
                musteri.SoyAd = item.SoyAd;
                musteri.TcNo = item.TcNo;
                musteri.EMail = item.EMail;
                musteri.Telefon = item.Telefon;
                musteri.Cinsiyet = item.Cinsiyet;
                Metotlar.db.MusterilerTablo.Add(musteri);

                Bilet bilet = new Bilet();
                bilet.YemekID = item.yemekID;
                bilet.RezerveMi = Bilgiler.RezerveMi;
                bilet.KoltukNo = (short)item.koltukNo;
                bilet.KalkisTarihi = Bilgiler.DonusTarihi;
                bilet.VarisTarihi = Bilgiler.DonusTarihi;
                bilet.SeferBilgileriID = Bilgiler.DonusSeferID;
                bilet.MusteriID = musteri.MusteriID;
                bilet.YetiskinMi = item.YetiskinMi;
                bilet.SigortaliMi = Bilgiler.SigortaVarMi;
                bilet.ToplamFiyat = Bilgiler.ToplamFiyat;
                bilet.PnrKodu = pnrKodu;
                Metotlar.db.BiletTablo.Add(bilet);
                Metotlar.db.SaveChanges();
            }
        }

        private void GidenYolculariKaydet()
        {
            
            foreach (Yolcu item in Bilgiler.GidisMusteriler)
            {
                Musteriler musteri = new Musteriler();
                musteri.Ad = item.Ad;
                musteri.SoyAd = item.SoyAd;
                musteri.EMail = item.EMail;
                musteri.TcNo = item.TcNo;
                musteri.Telefon = item.Telefon;
                musteri.Cinsiyet = item.Cinsiyet;
                Metotlar.db.MusterilerTablo.Add(musteri);


                Bilet bilet = new Bilet();
                bilet.YemekID = item.yemekID;
                bilet.RezerveMi = Bilgiler.RezerveMi;
                bilet.KoltukNo = (short)item.koltukNo;
                bilet.KalkisTarihi = Bilgiler.GidisTarihi;
                bilet.VarisTarihi = Bilgiler.GidisTarihi;
                bilet.SeferBilgileriID = Bilgiler.GidisSeferID;
                bilet.MusteriID = musteri.MusteriID;
                bilet.YetiskinMi = item.YetiskinMi;
                bilet.SigortaliMi = Bilgiler.SigortaVarMi;
                bilet.ToplamFiyat = Bilgiler.ToplamFiyat;
                bilet.PnrKodu = pnrKodu;
                Metotlar.db.BiletTablo.Add(bilet);
                Metotlar.db.SaveChanges();
            }
        }

        private void ToplamFiyatHesapla()
        {
            foreach (Yolcu yolcu in Bilgiler.GidisMusteriler)
            {
                if (Bilgiler.SigortaVarMi)
                {
                    Bilgiler.ToplamFiyat += 20;
                }

                if (yolcu.YetiskinMi)
                {
                    Bilgiler.ToplamFiyat += Metotlar.FiyatBul(Bilgiler.GidisSeferID);
                }
                else
                {
                    Bilgiler.ToplamFiyat += Metotlar.FiyatBul(Bilgiler.GidisSeferID) * 0.8m;
                }

                if (Bilgiler.GidisOtobusTipi == OtobusTipi.Suit && yolcu.koltukNo <= 8)
                {
                    Bilgiler.ToplamFiyat += 20;
                }

            }

            if (Bilgiler.SeyahatTipi == SeyehatTipi.GidisDonus)
            {
                foreach (Yolcu yolcu in Bilgiler.DonusMusteriler)
                {

                    //Sigorta Kontrolü
                    if (Bilgiler.SigortaVarMi)
                    {
                        Bilgiler.ToplamFiyat += 20;
                    }


                    //Çocuk kontrolü
                    if (yolcu.YetiskinMi)
                    {
                        Bilgiler.ToplamFiyat += Metotlar.FiyatBul(Bilgiler.DonusSeferID);
                    }
                    else
                    {
                        Bilgiler.ToplamFiyat += Metotlar.FiyatBul(Bilgiler.DonusSeferID) * 0.8m;
                    }


                    //VIP Koltuk kontrolü
                    if (Bilgiler.DonusOtobusTipi == OtobusTipi.Suit && yolcu.koltukNo <= 8)
                    {
                        Bilgiler.ToplamFiyat += 20;
                    }
                }
            }
        }

        private void OdemeEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtKartUzerindekiIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtKartNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
