namespace Test3.Forme
{
    partial class UpdateLSForm
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
            this.Ime = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMbr = new System.Windows.Forms.TextBox();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.txbGodine = new System.Windows.Forms.TextBox();
            this.txbSpecijalnost = new System.Windows.Forms.TextBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mbr";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(12, 75);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(29, 16);
            this.Ime.TabIndex = 1;
            this.Ime.Text = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(12, 111);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(56, 16);
            this.Prezime.TabIndex = 2;
            this.Prezime.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Godine radnog staza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Specijalnost";
            // 
            // txbMbr
            // 
            this.txbMbr.Enabled = false;
            this.txbMbr.Location = new System.Drawing.Point(242, 33);
            this.txbMbr.Name = "txbMbr";
            this.txbMbr.Size = new System.Drawing.Size(100, 22);
            this.txbMbr.TabIndex = 5;
            // 
            // txbIme
            // 
            this.txbIme.Location = new System.Drawing.Point(242, 72);
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(100, 22);
            this.txbIme.TabIndex = 6;
            // 
            // txbPrezime
            // 
            this.txbPrezime.Location = new System.Drawing.Point(242, 108);
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(100, 22);
            this.txbPrezime.TabIndex = 7;
            // 
            // txbGodine
            // 
            this.txbGodine.Location = new System.Drawing.Point(242, 145);
            this.txbGodine.Name = "txbGodine";
            this.txbGodine.Size = new System.Drawing.Size(100, 22);
            this.txbGodine.TabIndex = 8;
            // 
            // txbSpecijalnost
            // 
            this.txbSpecijalnost.Location = new System.Drawing.Point(242, 180);
            this.txbSpecijalnost.Name = "txbSpecijalnost";
            this.txbSpecijalnost.Size = new System.Drawing.Size(100, 22);
            this.txbSpecijalnost.TabIndex = 9;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAzuriraj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAzuriraj.Location = new System.Drawing.Point(85, 258);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(189, 41);
            this.btnAzuriraj.TabIndex = 17;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // UpdateLSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 312);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.txbSpecijalnost);
            this.Controls.Add(this.txbGodine);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.txbMbr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.label1);
            this.Name = "UpdateLSForm";
            this.Text = "Izmeni lekara specijalistu";
            this.Load += new System.EventHandler(this.UpdateLSForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMbr;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.TextBox txbGodine;
        private System.Windows.Forms.TextBox txbSpecijalnost;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}