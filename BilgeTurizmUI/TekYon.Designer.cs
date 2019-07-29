namespace BilgeTurizmUI
{
    partial class TekYon
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
            this.lblKampanya = new System.Windows.Forms.Label();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeferSec = new System.Windows.Forms.Button();
            this.grpGidisSeferleri = new System.Windows.Forms.GroupBox();
            this.rdbGidisSeferSuit = new System.Windows.Forms.RadioButton();
            this.rdbGidisSeferPre = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpGidisSeferSuit = new System.Windows.Forms.GroupBox();
            this.lblSuitFiyat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpGidisSeferPre = new System.Windows.Forms.GroupBox();
            this.lblStandartFiyat = new System.Windows.Forms.Label();
            this.lblSaat1100 = new System.Windows.Forms.Label();
            this.lblPremium = new System.Windows.Forms.Label();
            this.grpGidisSeferleri.SuspendLayout();
            this.grpGidisSeferSuit.SuspendLayout();
            this.grpGidisSeferPre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKampanya
            // 
            this.lblKampanya.AutoSize = true;
            this.lblKampanya.BackColor = System.Drawing.SystemColors.Control;
            this.lblKampanya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblKampanya.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblKampanya.Location = new System.Drawing.Point(19, 221);
            this.lblKampanya.Name = "lblKampanya";
            this.lblKampanya.Size = new System.Drawing.Size(436, 15);
            this.lblKampanya.TabIndex = 35;
            this.lblKampanya.Text = "Seçtiğiniz sefer ve tarihe özel Suit otobüsümüzde kampanya vardır.";
            this.lblKampanya.Visible = false;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnaSayfa.Location = new System.Drawing.Point(22, 345);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(220, 45);
            this.btnAnaSayfa.TabIndex = 34;
            this.btnAnaSayfa.Text = "ANA SAYFAYA DÖN";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gidiş Seferleri:";
            // 
            // btnSeferSec
            // 
            this.btnSeferSec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSeferSec.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeferSec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeferSec.Location = new System.Drawing.Point(383, 345);
            this.btnSeferSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeferSec.Name = "btnSeferSec";
            this.btnSeferSec.Size = new System.Drawing.Size(134, 45);
            this.btnSeferSec.TabIndex = 32;
            this.btnSeferSec.Text = "SEÇ";
            this.btnSeferSec.UseVisualStyleBackColor = false;
            this.btnSeferSec.Click += new System.EventHandler(this.btnSeferSec_Click);
            // 
            // grpGidisSeferleri
            // 
            this.grpGidisSeferleri.Controls.Add(this.rdbGidisSeferSuit);
            this.grpGidisSeferleri.Controls.Add(this.rdbGidisSeferPre);
            this.grpGidisSeferleri.Controls.Add(this.label5);
            this.grpGidisSeferleri.Controls.Add(this.label6);
            this.grpGidisSeferleri.Controls.Add(this.grpGidisSeferSuit);
            this.grpGidisSeferleri.Controls.Add(this.label7);
            this.grpGidisSeferleri.Controls.Add(this.grpGidisSeferPre);
            this.grpGidisSeferleri.Location = new System.Drawing.Point(22, 44);
            this.grpGidisSeferleri.Margin = new System.Windows.Forms.Padding(2);
            this.grpGidisSeferleri.Name = "grpGidisSeferleri";
            this.grpGidisSeferleri.Padding = new System.Windows.Forms.Padding(2);
            this.grpGidisSeferleri.Size = new System.Drawing.Size(495, 175);
            this.grpGidisSeferleri.TabIndex = 31;
            this.grpGidisSeferleri.TabStop = false;
            // 
            // rdbGidisSeferSuit
            // 
            this.rdbGidisSeferSuit.AutoSize = true;
            this.rdbGidisSeferSuit.Location = new System.Drawing.Point(11, 127);
            this.rdbGidisSeferSuit.Margin = new System.Windows.Forms.Padding(2);
            this.rdbGidisSeferSuit.Name = "rdbGidisSeferSuit";
            this.rdbGidisSeferSuit.Size = new System.Drawing.Size(14, 13);
            this.rdbGidisSeferSuit.TabIndex = 24;
            this.rdbGidisSeferSuit.TabStop = true;
            this.rdbGidisSeferSuit.UseVisualStyleBackColor = true;
            // 
            // rdbGidisSeferPre
            // 
            this.rdbGidisSeferPre.AutoSize = true;
            this.rdbGidisSeferPre.Location = new System.Drawing.Point(11, 60);
            this.rdbGidisSeferPre.Margin = new System.Windows.Forms.Padding(2);
            this.rdbGidisSeferPre.Name = "rdbGidisSeferPre";
            this.rdbGidisSeferPre.Size = new System.Drawing.Size(14, 13);
            this.rdbGidisSeferPre.TabIndex = 23;
            this.rdbGidisSeferPre.TabStop = true;
            this.rdbGidisSeferPre.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(369, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "FİYAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(182, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "KALKIŞ SAATİ";
            // 
            // grpGidisSeferSuit
            // 
            this.grpGidisSeferSuit.BackColor = System.Drawing.Color.Gainsboro;
            this.grpGidisSeferSuit.Controls.Add(this.lblSuitFiyat);
            this.grpGidisSeferSuit.Controls.Add(this.label12);
            this.grpGidisSeferSuit.Controls.Add(this.label13);
            this.grpGidisSeferSuit.Location = new System.Drawing.Point(38, 101);
            this.grpGidisSeferSuit.Margin = new System.Windows.Forms.Padding(2);
            this.grpGidisSeferSuit.Name = "grpGidisSeferSuit";
            this.grpGidisSeferSuit.Padding = new System.Windows.Forms.Padding(2);
            this.grpGidisSeferSuit.Size = new System.Drawing.Size(453, 62);
            this.grpGidisSeferSuit.TabIndex = 10;
            this.grpGidisSeferSuit.TabStop = false;
            // 
            // lblSuitFiyat
            // 
            this.lblSuitFiyat.AutoSize = true;
            this.lblSuitFiyat.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuitFiyat.ForeColor = System.Drawing.Color.Navy;
            this.lblSuitFiyat.Location = new System.Drawing.Point(331, 15);
            this.lblSuitFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuitFiyat.Name = "lblSuitFiyat";
            this.lblSuitFiyat.Size = new System.Drawing.Size(66, 17);
            this.lblSuitFiyat.TabIndex = 9;
            this.lblSuitFiyat.Text = "90+5 TL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(176, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "13:00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(5, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Suit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(35, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "OTOBÜS";
            // 
            // grpGidisSeferPre
            // 
            this.grpGidisSeferPre.BackColor = System.Drawing.Color.White;
            this.grpGidisSeferPre.Controls.Add(this.lblStandartFiyat);
            this.grpGidisSeferPre.Controls.Add(this.lblSaat1100);
            this.grpGidisSeferPre.Controls.Add(this.lblPremium);
            this.grpGidisSeferPre.Location = new System.Drawing.Point(38, 34);
            this.grpGidisSeferPre.Margin = new System.Windows.Forms.Padding(2);
            this.grpGidisSeferPre.Name = "grpGidisSeferPre";
            this.grpGidisSeferPre.Padding = new System.Windows.Forms.Padding(2);
            this.grpGidisSeferPre.Size = new System.Drawing.Size(453, 62);
            this.grpGidisSeferPre.TabIndex = 9;
            this.grpGidisSeferPre.TabStop = false;
            // 
            // lblStandartFiyat
            // 
            this.lblStandartFiyat.AutoSize = true;
            this.lblStandartFiyat.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStandartFiyat.ForeColor = System.Drawing.Color.Navy;
            this.lblStandartFiyat.Location = new System.Drawing.Point(331, 15);
            this.lblStandartFiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStandartFiyat.Name = "lblStandartFiyat";
            this.lblStandartFiyat.Size = new System.Drawing.Size(46, 17);
            this.lblStandartFiyat.TabIndex = 5;
            this.lblStandartFiyat.Text = "70 TL";
            // 
            // lblSaat1100
            // 
            this.lblSaat1100.AutoSize = true;
            this.lblSaat1100.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat1100.ForeColor = System.Drawing.Color.Navy;
            this.lblSaat1100.Location = new System.Drawing.Point(176, 15);
            this.lblSaat1100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaat1100.Name = "lblSaat1100";
            this.lblSaat1100.Size = new System.Drawing.Size(48, 17);
            this.lblSaat1100.TabIndex = 4;
            this.lblSaat1100.Text = "11:00";
            // 
            // lblPremium
            // 
            this.lblPremium.AutoSize = true;
            this.lblPremium.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPremium.ForeColor = System.Drawing.Color.Navy;
            this.lblPremium.Location = new System.Drawing.Point(4, 15);
            this.lblPremium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.Size = new System.Drawing.Size(66, 17);
            this.lblPremium.TabIndex = 3;
            this.lblPremium.Text = "Standart";
            // 
            // Gidis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(540, 416);
            this.Controls.Add(this.lblKampanya);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeferSec);
            this.Controls.Add(this.grpGidisSeferleri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gidis";
            this.Text = "Gidiş Sefer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gidis_FormClosed);
            this.Load += new System.EventHandler(this.Gidis_Load);
            this.grpGidisSeferleri.ResumeLayout(false);
            this.grpGidisSeferleri.PerformLayout();
            this.grpGidisSeferSuit.ResumeLayout(false);
            this.grpGidisSeferSuit.PerformLayout();
            this.grpGidisSeferPre.ResumeLayout(false);
            this.grpGidisSeferPre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKampanya;
        public System.Windows.Forms.Button btnAnaSayfa;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSeferSec;
        public System.Windows.Forms.GroupBox grpGidisSeferleri;
        public System.Windows.Forms.RadioButton rdbGidisSeferSuit;
        public System.Windows.Forms.RadioButton rdbGidisSeferPre;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.GroupBox grpGidisSeferSuit;
        public System.Windows.Forms.Label lblSuitFiyat;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox grpGidisSeferPre;
        public System.Windows.Forms.Label lblStandartFiyat;
        public System.Windows.Forms.Label lblSaat1100;
        public System.Windows.Forms.Label lblPremium;
    }
}