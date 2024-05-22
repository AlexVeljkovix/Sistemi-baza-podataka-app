namespace Test3
{
    partial class UpdateOdeljenjeForm
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
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSifraOdeljenja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTipOdeljenja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLekarSpecijalista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAzuriraj.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAzuriraj.Location = new System.Drawing.Point(142, 402);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(189, 41);
            this.btnAzuriraj.TabIndex = 15;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sifra odeljenja";
            // 
            // txbSifraOdeljenja
            // 
            this.txbSifraOdeljenja.Enabled = false;
            this.txbSifraOdeljenja.Location = new System.Drawing.Point(332, 42);
            this.txbSifraOdeljenja.Margin = new System.Windows.Forms.Padding(4);
            this.txbSifraOdeljenja.Name = "txbSifraOdeljenja";
            this.txbSifraOdeljenja.Size = new System.Drawing.Size(132, 22);
            this.txbSifraOdeljenja.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Datum izgradnje";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(220, 95);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(244, 22);
            this.dtpDatum.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tip";
            // 
            // txbTipOdeljenja
            // 
            this.txbTipOdeljenja.Location = new System.Drawing.Point(332, 149);
            this.txbTipOdeljenja.Margin = new System.Windows.Forms.Padding(4);
            this.txbTipOdeljenja.Name = "txbTipOdeljenja";
            this.txbTipOdeljenja.Size = new System.Drawing.Size(132, 22);
            this.txbTipOdeljenja.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lekar specijalista";
            // 
            // cbxLekarSpecijalista
            // 
            this.cbxLekarSpecijalista.FormattingEnabled = true;
            this.cbxLekarSpecijalista.Location = new System.Drawing.Point(332, 206);
            this.cbxLekarSpecijalista.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLekarSpecijalista.Name = "cbxLekarSpecijalista";
            this.cbxLekarSpecijalista.Size = new System.Drawing.Size(132, 24);
            this.cbxLekarSpecijalista.TabIndex = 23;
            // 
            // UpdateOdeljenjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 456);
            this.Controls.Add(this.cbxLekarSpecijalista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTipOdeljenja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSifraOdeljenja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAzuriraj);
            this.Name = "UpdateOdeljenjeForm";
            this.Text = "Azuriranje odeljenja";
            this.Load += new System.EventHandler(this.UpdateOdeljenjeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSifraOdeljenja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTipOdeljenja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxLekarSpecijalista;
    }
}