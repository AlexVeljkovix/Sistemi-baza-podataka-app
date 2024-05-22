namespace Test3.Forme
{
    partial class HigijenicariUpdateForm
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
            this.txbMbr = new System.Windows.Forms.TextBox();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.chkNovoOd = new System.Windows.Forms.CheckBox();
            this.cbxNovaOd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSifra = new System.Windows.Forms.TextBox();
            this.listOdeljenja = new System.Windows.Forms.ListView();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisiOd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mbr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime";
            // 
            // txbMbr
            // 
            this.txbMbr.Enabled = false;
            this.txbMbr.Location = new System.Drawing.Point(114, 32);
            this.txbMbr.Name = "txbMbr";
            this.txbMbr.Size = new System.Drawing.Size(100, 22);
            this.txbMbr.TabIndex = 4;
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(114, 73);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(100, 22);
            this.txbIme.TabIndex = 5;
            // 
            // txbPrezime
            // 
            this.txbPrezime.Location = new System.Drawing.Point(114, 117);
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(100, 22);
            this.txbPrezime.TabIndex = 6;
            // 
            // chkNovoOd
            // 
            this.chkNovoOd.AutoSize = true;
            this.chkNovoOd.Location = new System.Drawing.Point(12, 205);
            this.chkNovoOd.Name = "chkNovoOd";
            this.chkNovoOd.Size = new System.Drawing.Size(200, 20);
            this.chkNovoOd.TabIndex = 7;
            this.chkNovoOd.Text = "Dodavanje novog odeljenja?";
            this.chkNovoOd.UseVisualStyleBackColor = true;
            this.chkNovoOd.CheckedChanged += new System.EventHandler(this.chkNovoOd_CheckedChanged);
            // 
            // cbxNovaOd
            // 
            this.cbxNovaOd.Enabled = false;
            this.cbxNovaOd.FormattingEnabled = true;
            this.cbxNovaOd.Location = new System.Drawing.Point(142, 255);
            this.cbxNovaOd.Name = "cbxNovaOd";
            this.cbxNovaOd.Size = new System.Drawing.Size(121, 24);
            this.cbxNovaOd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Novo odeljenje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sifra odrzavanja";
            // 
            // txbSifra
            // 
            this.txbSifra.Enabled = false;
            this.txbSifra.Location = new System.Drawing.Point(163, 310);
            this.txbSifra.Name = "txbSifra";
            this.txbSifra.Size = new System.Drawing.Size(100, 22);
            this.txbSifra.TabIndex = 11;
            // 
            // listOdeljenja
            // 
            this.listOdeljenja.HideSelection = false;
            this.listOdeljenja.Location = new System.Drawing.Point(419, 32);
            this.listOdeljenja.Name = "listOdeljenja";
            this.listOdeljenja.Size = new System.Drawing.Size(117, 174);
            this.listOdeljenja.TabIndex = 12;
            this.listOdeljenja.UseCompatibleStateImageBehavior = false;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAzuriraj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAzuriraj.Location = new System.Drawing.Point(379, 301);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(189, 41);
            this.btnAzuriraj.TabIndex = 16;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisiOd
            // 
            this.btnObrisiOd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnObrisiOd.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnObrisiOd.Location = new System.Drawing.Point(379, 233);
            this.btnObrisiOd.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiOd.Name = "btnObrisiOd";
            this.btnObrisiOd.Size = new System.Drawing.Size(189, 41);
            this.btnObrisiOd.TabIndex = 17;
            this.btnObrisiOd.Text = "Obrisi odeljenje";
            this.btnObrisiOd.UseVisualStyleBackColor = false;
            this.btnObrisiOd.Click += new System.EventHandler(this.btnObrisiOd_Click);
            // 
            // HigijenicariUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 442);
            this.Controls.Add(this.btnObrisiOd);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.listOdeljenja);
            this.Controls.Add(this.txbSifra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxNovaOd);
            this.Controls.Add(this.chkNovoOd);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.txbMbr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HigijenicariUpdateForm";
            this.Text = "Azuriranje higijenicara";
            this.Load += new System.EventHandler(this.HigijenicariUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMbr;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.CheckBox chkNovoOd;
        private System.Windows.Forms.ComboBox cbxNovaOd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSifra;
        private System.Windows.Forms.ListView listOdeljenja;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisiOd;
    }
}