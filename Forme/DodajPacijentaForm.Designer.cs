namespace Test3.Forme
{
    partial class DodajPacijentaForm
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnAP = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnSP = new System.Windows.Forms.RadioButton();
            this.tbxMbr = new System.Windows.Forms.TextBox();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxAdresa = new System.Windows.Forms.TextBox();
            this.cbxSifraOdeljenja = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbxLekarOpstePrakse = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodaj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDodaj.Location = new System.Drawing.Point(473, 51);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(189, 41);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Maticni broj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Prezime";
            // 
            // rbtnAP
            // 
            this.rbtnAP.AutoSize = true;
            this.rbtnAP.Location = new System.Drawing.Point(15, 252);
            this.rbtnAP.Name = "rbtnAP";
            this.rbtnAP.Size = new System.Drawing.Size(144, 20);
            this.rbtnAP.TabIndex = 18;
            this.rbtnAP.TabStop = true;
            this.rbtnAP.Text = "Ambulantni pacijent";
            this.rbtnAP.UseVisualStyleBackColor = true;
            this.rbtnAP.CheckedChanged += new System.EventHandler(this.rbtnAP_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tip pacijenta";
            // 
            // rbtnSP
            // 
            this.rbtnSP.AutoSize = true;
            this.rbtnSP.Location = new System.Drawing.Point(311, 252);
            this.rbtnSP.Name = "rbtnSP";
            this.rbtnSP.Size = new System.Drawing.Size(145, 20);
            this.rbtnSP.TabIndex = 20;
            this.rbtnSP.TabStop = true;
            this.rbtnSP.Text = "Stacionarni pacijent";
            this.rbtnSP.UseVisualStyleBackColor = true;
            this.rbtnSP.CheckedChanged += new System.EventHandler(this.rbtnSP_CheckedChanged);
            // 
            // tbxMbr
            // 
            this.tbxMbr.Location = new System.Drawing.Point(125, 25);
            this.tbxMbr.Name = "tbxMbr";
            this.tbxMbr.Size = new System.Drawing.Size(127, 22);
            this.tbxMbr.TabIndex = 21;
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(125, 67);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(127, 22);
            this.tbxIme.TabIndex = 22;
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(125, 114);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(127, 22);
            this.tbxPrezime.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sifra odeljenja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Datum prijema";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Datum otpusta";
            // 
            // tbxAdresa
            // 
            this.tbxAdresa.Location = new System.Drawing.Point(95, 298);
            this.tbxAdresa.Name = "tbxAdresa";
            this.tbxAdresa.Size = new System.Drawing.Size(100, 22);
            this.tbxAdresa.TabIndex = 28;
            // 
            // cbxSifraOdeljenja
            // 
            this.cbxSifraOdeljenja.FormattingEnabled = true;
            this.cbxSifraOdeljenja.Location = new System.Drawing.Point(442, 301);
            this.cbxSifraOdeljenja.Name = "cbxSifraOdeljenja";
            this.cbxSifraOdeljenja.Size = new System.Drawing.Size(121, 24);
            this.cbxSifraOdeljenja.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(442, 338);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(442, 370);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // cbxLekarOpstePrakse
            // 
            this.cbxLekarOpstePrakse.FormattingEnabled = true;
            this.cbxLekarOpstePrakse.Location = new System.Drawing.Point(184, 170);
            this.cbxLekarOpstePrakse.Name = "cbxLekarOpstePrakse";
            this.cbxLekarOpstePrakse.Size = new System.Drawing.Size(121, 24);
            this.cbxLekarOpstePrakse.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Lekar opste prakse";
            // 
            // DodajPacijentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 423);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxLekarOpstePrakse);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbxSifraOdeljenja);
            this.Controls.Add(this.tbxAdresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.tbxMbr);
            this.Controls.Add(this.rbtnSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnAP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Name = "DodajPacijentaForm";
            this.Text = "Dodavanje novog pacijenta";
            this.Load += new System.EventHandler(this.DodajPacijentaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnAP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnSP;
        private System.Windows.Forms.TextBox tbxMbr;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxAdresa;
        private System.Windows.Forms.ComboBox cbxSifraOdeljenja;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbxLekarOpstePrakse;
        private System.Windows.Forms.Label label9;
    }
}