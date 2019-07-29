namespace BilgeTurizmUI
{
    partial class PNRSorgulamaEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPnrKodu = new System.Windows.Forms.TextBox();
            this.grpPnrSorgulama = new System.Windows.Forms.GroupBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxBiletler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAnaEkranaDon = new System.Windows.Forms.Button();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.grpPnrSorgulama.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPnrKodu
            // 
            this.txtPnrKodu.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPnrKodu.Location = new System.Drawing.Point(105, 31);
            this.txtPnrKodu.Margin = new System.Windows.Forms.Padding(2);
            this.txtPnrKodu.Name = "txtPnrKodu";
            this.txtPnrKodu.Size = new System.Drawing.Size(168, 26);
            this.txtPnrKodu.TabIndex = 0;
            // 
            // grpPnrSorgulama
            // 
            this.grpPnrSorgulama.Controls.Add(this.btnSorgula);
            this.grpPnrSorgulama.Controls.Add(this.label1);
            this.grpPnrSorgulama.Controls.Add(this.txtPnrKodu);
            this.grpPnrSorgulama.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPnrSorgulama.Location = new System.Drawing.Point(11, 11);
            this.grpPnrSorgulama.Margin = new System.Windows.Forms.Padding(2);
            this.grpPnrSorgulama.Name = "grpPnrSorgulama";
            this.grpPnrSorgulama.Padding = new System.Windows.Forms.Padding(2);
            this.grpPnrSorgulama.Size = new System.Drawing.Size(705, 76);
            this.grpPnrSorgulama.TabIndex = 4;
            this.grpPnrSorgulama.TabStop = false;
            this.grpPnrSorgulama.Text = "Bilet Sorgula";
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSorgula.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.ForeColor = System.Drawing.Color.White;
            this.btnSorgula.Location = new System.Drawing.Point(286, 25);
            this.btnSorgula.Margin = new System.Windows.Forms.Padding(2);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(167, 37);
            this.btnSorgula.TabIndex = 4;
            this.btnSorgula.Text = "SORGULA";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "PNR Kodu:";
            // 
            // lbxBiletler
            // 
            this.lbxBiletler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lbxBiletler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxBiletler.Location = new System.Drawing.Point(12, 92);
            this.lbxBiletler.Name = "lbxBiletler";
            this.lbxBiletler.Size = new System.Drawing.Size(705, 250);
            this.lbxBiletler.TabIndex = 5;
            this.lbxBiletler.UseCompatibleStateImageBehavior = false;
            this.lbxBiletler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nereden";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nereye";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sefer Tarihi";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sefer Saati";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Koltuk No";
            this.columnHeader7.Width = 100;
            // 
            // btnAnaEkranaDon
            // 
            this.btnAnaEkranaDon.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAnaEkranaDon.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaEkranaDon.ForeColor = System.Drawing.Color.White;
            this.btnAnaEkranaDon.Location = new System.Drawing.Point(12, 347);
            this.btnAnaEkranaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnaEkranaDon.Name = "btnAnaEkranaDon";
            this.btnAnaEkranaDon.Size = new System.Drawing.Size(167, 37);
            this.btnAnaEkranaDon.TabIndex = 4;
            this.btnAnaEkranaDon.Text = "ANA EKRANA DÖN";
            this.btnAnaEkranaDon.UseVisualStyleBackColor = false;
            this.btnAnaEkranaDon.Click += new System.EventHandler(this.btnAnaEkranaDon_Click);
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSatinAl.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAl.ForeColor = System.Drawing.Color.White;
            this.btnSatinAl.Location = new System.Drawing.Point(545, 347);
            this.btnSatinAl.Margin = new System.Windows.Forms.Padding(2);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(167, 37);
            this.btnSatinAl.TabIndex = 4;
            this.btnSatinAl.Text = "BİLETLERİ SATIN AL";
            this.btnSatinAl.UseVisualStyleBackColor = false;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // PNRSorgulamaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 391);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.btnAnaEkranaDon);
            this.Controls.Add(this.lbxBiletler);
            this.Controls.Add(this.grpPnrSorgulama);
            this.Name = "PNRSorgulamaEkrani";
            this.Text = "PNR Sorgulama Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PNRSorgulamaEkrani_FormClosed);
            this.Load += new System.EventHandler(this.PNRSorgulamaEkrani_Load);
            this.grpPnrSorgulama.ResumeLayout(false);
            this.grpPnrSorgulama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPnrKodu;
        private System.Windows.Forms.GroupBox grpPnrSorgulama;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lbxBiletler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnAnaEkranaDon;
        private System.Windows.Forms.Button btnSatinAl;
    }
}