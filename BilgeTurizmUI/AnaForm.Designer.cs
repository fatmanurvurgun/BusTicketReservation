namespace BilgeTurizmUI
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.btnListele = new System.Windows.Forms.Button();
            this.grpSeferBilgisi = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdbTekYon = new System.Windows.Forms.RadioButton();
            this.rdbGidisDonus = new System.Windows.Forms.RadioButton();
            this.rdbRezervasyon = new System.Windows.Forms.RadioButton();
            this.rdbSatinAlma = new System.Windows.Forms.RadioButton();
            this.dtpDonusTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGidisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPnrSorgula = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSeferBilgisi.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnListele.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListele.Location = new System.Drawing.Point(255, 468);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(184, 45);
            this.btnListele.TabIndex = 19;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // grpSeferBilgisi
            // 
            this.grpSeferBilgisi.BackColor = System.Drawing.Color.Gray;
            this.grpSeferBilgisi.Controls.Add(this.flowLayoutPanel1);
            this.grpSeferBilgisi.Controls.Add(this.rdbRezervasyon);
            this.grpSeferBilgisi.Controls.Add(this.rdbSatinAlma);
            this.grpSeferBilgisi.Controls.Add(this.dtpDonusTarihi);
            this.grpSeferBilgisi.Controls.Add(this.dtpGidisTarihi);
            this.grpSeferBilgisi.Controls.Add(this.cmbNereye);
            this.grpSeferBilgisi.Controls.Add(this.cmbNereden);
            this.grpSeferBilgisi.Controls.Add(this.label2);
            this.grpSeferBilgisi.Controls.Add(this.label1);
            this.grpSeferBilgisi.Location = new System.Drawing.Point(11, 179);
            this.grpSeferBilgisi.Margin = new System.Windows.Forms.Padding(2);
            this.grpSeferBilgisi.Name = "grpSeferBilgisi";
            this.grpSeferBilgisi.Padding = new System.Windows.Forms.Padding(2);
            this.grpSeferBilgisi.Size = new System.Drawing.Size(428, 285);
            this.grpSeferBilgisi.TabIndex = 18;
            this.grpSeferBilgisi.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rdbTekYon);
            this.flowLayoutPanel1.Controls.Add(this.rdbGidisDonus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(119, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(179, 30);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // rdbTekYon
            // 
            this.rdbTekYon.AutoSize = true;
            this.rdbTekYon.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTekYon.Location = new System.Drawing.Point(2, 2);
            this.rdbTekYon.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTekYon.Name = "rdbTekYon";
            this.rdbTekYon.Size = new System.Drawing.Size(73, 20);
            this.rdbTekYon.TabIndex = 4;
            this.rdbTekYon.TabStop = true;
            this.rdbTekYon.Text = "Tek Yön";
            this.rdbTekYon.UseVisualStyleBackColor = true;
            // 
            // rdbGidisDonus
            // 
            this.rdbGidisDonus.AutoSize = true;
            this.rdbGidisDonus.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbGidisDonus.Location = new System.Drawing.Point(79, 2);
            this.rdbGidisDonus.Margin = new System.Windows.Forms.Padding(2);
            this.rdbGidisDonus.Name = "rdbGidisDonus";
            this.rdbGidisDonus.Size = new System.Drawing.Size(95, 20);
            this.rdbGidisDonus.TabIndex = 5;
            this.rdbGidisDonus.TabStop = true;
            this.rdbGidisDonus.Text = "Gidiş Dönüş";
            this.rdbGidisDonus.UseVisualStyleBackColor = true;
            this.rdbGidisDonus.CheckedChanged += new System.EventHandler(this.rdbGidisDonus_CheckedChanged);
            // 
            // rdbRezervasyon
            // 
            this.rdbRezervasyon.AutoSize = true;
            this.rdbRezervasyon.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbRezervasyon.Location = new System.Drawing.Point(97, 200);
            this.rdbRezervasyon.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRezervasyon.Name = "rdbRezervasyon";
            this.rdbRezervasyon.Size = new System.Drawing.Size(99, 20);
            this.rdbRezervasyon.TabIndex = 8;
            this.rdbRezervasyon.TabStop = true;
            this.rdbRezervasyon.Text = "Rezervasyon";
            this.rdbRezervasyon.UseVisualStyleBackColor = true;
            // 
            // rdbSatinAlma
            // 
            this.rdbSatinAlma.AutoSize = true;
            this.rdbSatinAlma.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSatinAlma.Location = new System.Drawing.Point(227, 200);
            this.rdbSatinAlma.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSatinAlma.Name = "rdbSatinAlma";
            this.rdbSatinAlma.Size = new System.Drawing.Size(86, 20);
            this.rdbSatinAlma.TabIndex = 9;
            this.rdbSatinAlma.TabStop = true;
            this.rdbSatinAlma.Text = "Satın Alma";
            this.rdbSatinAlma.UseVisualStyleBackColor = true;
            // 
            // dtpDonusTarihi
            // 
            this.dtpDonusTarihi.Location = new System.Drawing.Point(250, 154);
            this.dtpDonusTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDonusTarihi.MaxDate = new System.DateTime(2020, 5, 31, 0, 0, 0, 0);
            this.dtpDonusTarihi.Name = "dtpDonusTarihi";
            this.dtpDonusTarihi.Size = new System.Drawing.Size(153, 20);
            this.dtpDonusTarihi.TabIndex = 7;
            // 
            // dtpGidisTarihi
            // 
            this.dtpGidisTarihi.Location = new System.Drawing.Point(32, 154);
            this.dtpGidisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGidisTarihi.MaxDate = new System.DateTime(2020, 5, 30, 0, 0, 0, 0);
            this.dtpGidisTarihi.Name = "dtpGidisTarihi";
            this.dtpGidisTarihi.Size = new System.Drawing.Size(153, 20);
            this.dtpGidisTarihi.TabIndex = 6;
            this.dtpGidisTarihi.ValueChanged += new System.EventHandler(this.dtpGidisTarihi_ValueChanged);
            // 
            // cmbNereye
            // 
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Location = new System.Drawing.Point(116, 65);
            this.cmbNereye.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(182, 21);
            this.cmbNereye.TabIndex = 3;
            // 
            // cmbNereden
            // 
            this.cmbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Location = new System.Drawing.Point(116, 28);
            this.cmbNereden.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(182, 21);
            this.cmbNereden.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereye:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden:";
            // 
            // btnPnrSorgula
            // 
            this.btnPnrSorgula.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnPnrSorgula.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPnrSorgula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPnrSorgula.Location = new System.Drawing.Point(12, 468);
            this.btnPnrSorgula.Margin = new System.Windows.Forms.Padding(2);
            this.btnPnrSorgula.Name = "btnPnrSorgula";
            this.btnPnrSorgula.Size = new System.Drawing.Size(184, 45);
            this.btnPnrSorgula.TabIndex = 19;
            this.btnPnrSorgula.Text = "PNR SORGULA";
            this.btnPnrSorgula.UseVisualStyleBackColor = false;
            this.btnPnrSorgula.Click += new System.EventHandler(this.btnPnrSorgula_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(455, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPnrSorgula);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.grpSeferBilgisi);
            this.Name = "AnaForm";
            this.Text = "Bilge Turizm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.grpSeferBilgisi.ResumeLayout(false);
            this.grpSeferBilgisi.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnListele;
        public System.Windows.Forms.GroupBox grpSeferBilgisi;
        public System.Windows.Forms.RadioButton rdbSatinAlma;
        public System.Windows.Forms.RadioButton rdbRezervasyon;
        public System.Windows.Forms.DateTimePicker dtpDonusTarihi;
        public System.Windows.Forms.DateTimePicker dtpGidisTarihi;
        public System.Windows.Forms.ComboBox cmbNereye;
        public System.Windows.Forms.ComboBox cmbNereden;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnPnrSorgula;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.RadioButton rdbTekYon;
        public System.Windows.Forms.RadioButton rdbGidisDonus;
    }
}