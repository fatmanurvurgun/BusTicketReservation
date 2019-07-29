using BilgeTurizm.DATA;
using BİlgeTurizm.DAL;
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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

            //int[] sehirler = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    for (int j = sehirler.Length - 1; j >= 0; j--)
            //    {
            //        if (sehirler[i] != sehirler[j])
            //        {
            //            SeferBilgileri sefer = new SeferBilgileri();
            //            sefer.Nereden = sehirler[i];
            //            sefer.Nereye = sehirler[j];
            //            sefer.KalkisSaati = "13:00";
            //            sefer.VarisSaati = "15:00";
            //            sefer.OtobusTipi = "Suit";
            //            sefer.Ucret = 90;
            //            Metotlar.db.SeferBilgiTablo.Add(sefer);
            //            Metotlar.db.SaveChanges();
            //        }
            //    }
            //}
            //Random rnd = new Random();
            //decimal[] ucretler = { 55, 60, 65, 70, 75, 80, 85, 90, 95, 100, 105, 110 };
            //for (int i = 2; i <= 265; i++)
            //{
            //    SeferBilgileri sf = db.SeferBilgiTablo.FirstOrDefault(x => x.ID == i);
            //    sf.Ucret = ucretler[rnd.Next(0, 11)];
            //    Metotlar.db.SaveChanges();
            //}

            cmbNereden.DataSource = Metotlar.db.Sehirler.ToList();
            cmbNereden.DisplayMember = "Sehir";
            cmbNereden.ValueMember = "SehirID";

            cmbNereye.DataSource = Metotlar.db.Sehirler.ToList();
            cmbNereye.DisplayMember = "Sehir";
            cmbNereye.ValueMember = "SehirID";
            cmbNereye.SelectedIndex = 1;


            dtpGidisTarihi.MinDate = DateTime.Now;
            dtpDonusTarihi.Value = dtpGidisTarihi.Value.AddDays(1);

            rdbTekYon.Checked = true;
            dtpDonusTarihi.Enabled = false;
            dtpDonusTarihi.Hide();

            rdbSatinAlma.Checked = true;


        }

        private void rdbGidisDonus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGidisDonus.Checked)
            {
                dtpDonusTarihi.Enabled = true;
                dtpDonusTarihi.Show();
            }
            else
            {
                dtpDonusTarihi.Enabled = false;
                dtpDonusTarihi.Hide();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            //Static Verileri kaydettik
            Bilgiler.GidisTarihi = dtpGidisTarihi.Value.Date;
            Bilgiler.DonusTarihi = dtpDonusTarihi.Value.Date;
            Bilgiler.NeredenSehir = (int)cmbNereden.SelectedValue;
            Bilgiler.NereyeSehir = (int)cmbNereye.SelectedValue;
            Bilgiler.RezerveMi = rdbRezervasyon.Checked;
            Bilgiler.SeyahatTipi = rdbGidisDonus.Checked ? SeyehatTipi.GidisDonus : SeyehatTipi.TekYon;

            if ((int)cmbNereden.SelectedValue == (int)cmbNereye.SelectedValue)
            {
                MessageBox.Show("Kalkış ve varış lokasyonları aynı olamaz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if (rdbGidisDonus.Checked)
            {
                GidisDonus gd = new GidisDonus(this);
                gd.Show();
            }
            else
            {
                TekYon g = new TekYon(this);
                g.Show();
            }


            Hide();

        }

        private void dtpGidisTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpDonusTarihi.MinDate = dtpGidisTarihi.Value.AddDays(1);

        }

        private void btnPnrSorgula_Click(object sender, EventArgs e)
        {
            PNRSorgulamaEkrani pnr = new PNRSorgulamaEkrani(this);
            pnr.Show();
            Hide();
        }
    }
}
