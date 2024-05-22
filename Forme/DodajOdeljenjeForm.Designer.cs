namespace Test3.Forme
{
    partial class DodajOdeljenjeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSifraOdeljenja = new System.Windows.Forms.TextBox();
            this.txbTipOdeljenja = new System.Windows.Forms.TextBox();
            this.cbxLekarSpecijalista = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra odeljenja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum izgradnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lekar specijalista";
            // 
            // txbSifraOdeljenja
            // 
            this.txbSifraOdeljenja.Location = new System.Drawing.Point(231, 38);
            this.txbSifraOdeljenja.Name = "txbSifraOdeljenja";
            this.txbSifraOdeljenja.Size = new System.Drawing.Size(100, 20);
            this.txbSifraOdeljenja.TabIndex = 4;
            // 
            // txbTipOdeljenja
            // 
            this.txbTipOdeljenja.Location = new System.Drawing.Point(231, 119);
            this.txbTipOdeljenja.Name = "txbTipOdeljenja";
            this.txbTipOdeljenja.Size = new System.Drawing.Size(100, 20);
            this.txbTipOdeljenja.TabIndex = 5;
            // 
            // cbxLekarSpecijalista
            // 
            this.cbxLekarSpecijalista.FormattingEnabled = true;
            this.cbxLekarSpecijalista.Location = new System.Drawing.Point(231, 159);
            this.cbxLekarSpecijalista.Name = "cbxLekarSpecijalista";
            this.cbxLekarSpecijalista.Size = new System.Drawing.Size(100, 21);
            this.cbxLekarSpecijalista.TabIndex = 6;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(147, 80);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(184, 20);
            this.dtpDatum.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodaj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDodaj.Location = new System.Drawing.Point(115, 317);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(142, 33);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajOdeljenjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 362);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cbxLekarSpecijalista);
            this.Controls.Add(this.txbTipOdeljenja);
            this.Controls.Add(this.txbSifraOdeljenja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajOdeljenjeForm";
            this.Text = "Dodavanje novog odeljenja";
            this.Load += new System.EventHandler(this.DodajOdeljenjeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSifraOdeljenja;
        private System.Windows.Forms.TextBox txbTipOdeljenja;
        private System.Windows.Forms.ComboBox cbxLekarSpecijalista;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnDodaj;
    }
}