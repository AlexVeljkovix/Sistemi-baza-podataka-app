namespace Test3.Forme
{
    partial class DodajMedOsobljeForm
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
            this.rbtnLO = new System.Windows.Forms.RadioButton();
            this.rbtnLS = new System.Windows.Forms.RadioButton();
            this.rbtnStomatolog = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMbr = new System.Windows.Forms.TextBox();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.tbxGodine = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxBrordinacije = new System.Windows.Forms.TextBox();
            this.tbxSpecijalnost = new System.Windows.Forms.TextBox();
            this.cbxIdStolice = new System.Windows.Forms.ComboBox();
            this.cbxSmena = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mbr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Godine radnog staza";
            // 
            // rbtnLO
            // 
            this.rbtnLO.AutoSize = true;
            this.rbtnLO.Location = new System.Drawing.Point(31, 305);
            this.rbtnLO.Name = "rbtnLO";
            this.rbtnLO.Size = new System.Drawing.Size(141, 20);
            this.rbtnLO.TabIndex = 4;
            this.rbtnLO.TabStop = true;
            this.rbtnLO.Text = "Lekar opste prakse";
            this.rbtnLO.UseVisualStyleBackColor = true;
            this.rbtnLO.CheckedChanged += new System.EventHandler(this.rbtnLO_CheckedChanged);
            // 
            // rbtnLS
            // 
            this.rbtnLS.AutoSize = true;
            this.rbtnLS.Location = new System.Drawing.Point(336, 305);
            this.rbtnLS.Name = "rbtnLS";
            this.rbtnLS.Size = new System.Drawing.Size(130, 20);
            this.rbtnLS.TabIndex = 5;
            this.rbtnLS.TabStop = true;
            this.rbtnLS.Text = "Lekar specijalista";
            this.rbtnLS.UseVisualStyleBackColor = true;
            this.rbtnLS.CheckedChanged += new System.EventHandler(this.rbtnLS_CheckedChanged);
            // 
            // rbtnStomatolog
            // 
            this.rbtnStomatolog.AutoSize = true;
            this.rbtnStomatolog.Location = new System.Drawing.Point(616, 305);
            this.rbtnStomatolog.Name = "rbtnStomatolog";
            this.rbtnStomatolog.Size = new System.Drawing.Size(94, 20);
            this.rbtnStomatolog.TabIndex = 6;
            this.rbtnStomatolog.TabStop = true;
            this.rbtnStomatolog.Text = "Stomatolog";
            this.rbtnStomatolog.UseVisualStyleBackColor = true;
            this.rbtnStomatolog.CheckedChanged += new System.EventHandler(this.rbtnStomatolog_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tip medicinskog osoblja";
            // 
            // tbxMbr
            // 
            this.tbxMbr.Location = new System.Drawing.Point(238, 43);
            this.tbxMbr.Name = "tbxMbr";
            this.tbxMbr.Size = new System.Drawing.Size(100, 22);
            this.tbxMbr.TabIndex = 8;
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(238, 85);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(100, 22);
            this.tbxIme.TabIndex = 9;
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(238, 130);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(100, 22);
            this.tbxPrezime.TabIndex = 10;
            // 
            // tbxGodine
            // 
            this.tbxGodine.Location = new System.Drawing.Point(238, 180);
            this.tbxGodine.Name = "tbxGodine";
            this.tbxGodine.Size = new System.Drawing.Size(100, 22);
            this.tbxGodine.TabIndex = 11;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodaj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDodaj.Location = new System.Drawing.Point(602, 43);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(189, 41);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Broj ordinacije";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Specijalnost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Smena";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Id stolice";
            // 
            // tbxBrordinacije
            // 
            this.tbxBrordinacije.Location = new System.Drawing.Point(146, 360);
            this.tbxBrordinacije.Name = "tbxBrordinacije";
            this.tbxBrordinacije.Size = new System.Drawing.Size(100, 22);
            this.tbxBrordinacije.TabIndex = 20;
            // 
            // tbxSpecijalnost
            // 
            this.tbxSpecijalnost.Location = new System.Drawing.Point(432, 360);
            this.tbxSpecijalnost.Name = "tbxSpecijalnost";
            this.tbxSpecijalnost.Size = new System.Drawing.Size(100, 22);
            this.tbxSpecijalnost.TabIndex = 21;
            // 
            // cbxIdStolice
            // 
            this.cbxIdStolice.FormattingEnabled = true;
            this.cbxIdStolice.Location = new System.Drawing.Point(691, 411);
            this.cbxIdStolice.Name = "cbxIdStolice";
            this.cbxIdStolice.Size = new System.Drawing.Size(100, 24);
            this.cbxIdStolice.TabIndex = 23;
            // 
            // cbxSmena
            // 
            this.cbxSmena.FormattingEnabled = true;
            this.cbxSmena.Location = new System.Drawing.Point(691, 363);
            this.cbxSmena.Name = "cbxSmena";
            this.cbxSmena.Size = new System.Drawing.Size(100, 24);
            this.cbxSmena.TabIndex = 24;
            // 
            // DodajMedOsobljeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 490);
            this.Controls.Add(this.cbxSmena);
            this.Controls.Add(this.cbxIdStolice);
            this.Controls.Add(this.tbxSpecijalnost);
            this.Controls.Add(this.tbxBrordinacije);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbxGodine);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.tbxMbr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtnStomatolog);
            this.Controls.Add(this.rbtnLS);
            this.Controls.Add(this.rbtnLO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajMedOsobljeForm";
            this.Text = "Dodavanje novog medicinskog radnika";
            this.Load += new System.EventHandler(this.DodajMedOsobljeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnLO;
        private System.Windows.Forms.RadioButton rbtnLS;
        private System.Windows.Forms.RadioButton rbtnStomatolog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxMbr;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.TextBox tbxGodine;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxBrordinacije;
        private System.Windows.Forms.TextBox tbxSpecijalnost;
        private System.Windows.Forms.ComboBox cbxIdStolice;
        private System.Windows.Forms.ComboBox cbxSmena;
    }
}