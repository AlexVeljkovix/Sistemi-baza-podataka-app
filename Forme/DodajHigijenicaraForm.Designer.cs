namespace Test3.Forme
{
    partial class DodajHigijenicaraForm
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
            this.txbMbr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNovaOd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSifra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mbr";
            // 
            // txbMbr
            // 
            this.txbMbr.Location = new System.Drawing.Point(159, 43);
            this.txbMbr.Name = "txbMbr";
            this.txbMbr.Size = new System.Drawing.Size(100, 22);
            this.txbMbr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime";
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(159, 95);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(100, 22);
            this.txbIme.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezime";
            // 
            // txbPrezime
            // 
            this.txbPrezime.Location = new System.Drawing.Point(159, 145);
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(100, 22);
            this.txbPrezime.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodaj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDodaj.Location = new System.Drawing.Point(70, 362);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(189, 41);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Novo odeljenje";
            // 
            // cbxNovaOd
            // 
            this.cbxNovaOd.FormattingEnabled = true;
            this.cbxNovaOd.Location = new System.Drawing.Point(159, 197);
            this.cbxNovaOd.Name = "cbxNovaOd";
            this.cbxNovaOd.Size = new System.Drawing.Size(100, 24);
            this.cbxNovaOd.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sifra odrzavanja";
            // 
            // txbSifra
            // 
            this.txbSifra.Location = new System.Drawing.Point(159, 246);
            this.txbSifra.Name = "txbSifra";
            this.txbSifra.Size = new System.Drawing.Size(100, 22);
            this.txbSifra.TabIndex = 19;
            // 
            // DodajHigijenicaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 416);
            this.Controls.Add(this.txbSifra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxNovaOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMbr);
            this.Controls.Add(this.label1);
            this.Name = "DodajHigijenicaraForm";
            this.Text = "Dodavanje novog higijenicara";
            this.Load += new System.EventHandler(this.DodajHigijenicaraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMbr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxNovaOd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSifra;
    }
}