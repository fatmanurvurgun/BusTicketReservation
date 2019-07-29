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
    public partial class PNRSorgulamaEkrani : Form
    {
        AnaForm anaForm;
        public PNRSorgulamaEkrani(AnaForm gelenForm)
        {
            InitializeComponent();
            anaForm = gelenForm;
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if(txtPnrKodu.Text.Trim() == "" || txtPnrKodu.Text.Length != 6)
            {
                MessageBox.Show("Lütfen geçerli bir PNR Kodu giriniz!");
                return;
            }
            lbxBiletler.Items.Clear();
            foreach (Bilet bilet in Metotlar.db.BiletTablo.Where(x => x.PnrKodu == txtPnrKodu.Text).ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = bilet.Musteri.Ad;
                lvi.SubItems.Add(bilet.Musteri.SoyAd);
                lvi.SubItems.Add(Metotlar.SehirBul(bilet.SeferBiletBilgisi.Nereden));
                lvi.SubItems.Add(Metotlar.SehirBul(bilet.SeferBiletBilgisi.Nereye));
                lvi.SubItems.Add(bilet.KalkisTarihi.ToShortDateString());
                lvi.SubItems.Add((bilet.SeferBiletBilgisi.OtobusTipi == "Standart" ? "11:00" : "13:00"));
                lvi.SubItems.Add(bilet.KoltukNo.ToString());


                lbxBiletler.Items.Add(lvi);
            }

            if(Metotlar.db.BiletTablo.FirstOrDefault(x => x.PnrKodu == txtPnrKodu.Text).RezerveMi)
            {
                btnSatinAl.Show();
            }
        }

        private void btnAnaEkranaDon_Click(object sender, EventArgs e)
        {
            Hide();
            anaForm.Show();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            OdemeEkrani oe = new OdemeEkrani(txtPnrKodu.Text);
            oe.Show();
            Hide();
        }

        private void PNRSorgulamaEkrani_Load(object sender, EventArgs e)
        {
            btnSatinAl.Hide();
        }

        private void PNRSorgulamaEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }
    }
}
