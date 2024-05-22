namespace Test3.Forme
{
    partial class NovaIntervencijaStomatologForm
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
            this.txbSifra = new System.Windows.Forms.TextBox();
            this.txbVrsta = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cbxPacijent = new System.Windows.Forms.ComboBox();
            this.btnKreirajIntervenciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra intervencije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrsta intervencije";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum intervencije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pacijent";
            // 
            // txbSifra
            // 
            this.txbSifra.Location = new System.Drawing.Point(301, 27);
            this.txbSifra.Name = "txbSifra";
            this.txbSifra.Size = new System.Drawing.Size(100, 22);
            this.txbSifra.TabIndex = 4;
            // 
            // txbVrsta
            // 
            this.txbVrsta.Location = new System.Drawing.Point(301, 74);
            this.txbVrsta.Name = "txbVrsta";
            this.txbVrsta.Size = new System.Drawing.Size(100, 22);
            this.txbVrsta.TabIndex = 5;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(168, 115);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(233, 22);
            this.dtpDatum.TabIndex = 6;
            // 
            // cbxPacijent
            // 
            this.cbxPacijent.FormattingEnabled = true;
            this.cbxPacijent.Location = new System.Drawing.Point(280, 156);
            this.cbxPacijent.Name = "cbxPacijent";
            this.cbxPacijent.Size = new System.Drawing.Size(121, 24);
            this.cbxPacijent.TabIndex = 7;
            // 
            // btnKreirajIntervenciju
            // 
            this.btnKreirajIntervenciju.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnKreirajIntervenciju.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajIntervenciju.Location = new System.Drawing.Point(119, 273);
            this.btnKreirajIntervenciju.Margin = new System.Windows.Forms.Padding(4);
            this.btnKreirajIntervenciju.Name = "btnKreirajIntervenciju";
            this.btnKreirajIntervenciju.Size = new System.Drawing.Size(200, 49);
            this.btnKreirajIntervenciju.TabIndex = 47;
            this.btnKreirajIntervenciju.Text = "Kreiraj intervenciju";
            this.btnKreirajIntervenciju.UseVisualStyleBackColor = false;
            this.btnKreirajIntervenciju.Click += new System.EventHandler(this.btnKreirajIntervenciju_Click);
            // 
            // NovaIntervencijaStomatologForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 335);
            this.Controls.Add(this.btnKreirajIntervenciju);
            this.Controls.Add(this.cbxPacijent);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txbVrsta);
            this.Controls.Add(this.txbSifra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovaIntervencijaStomatologForm";
            this.Text = "Kreiranje nove intervencije";
            this.Load += new System.EventHandler(this.NovaIntervencijaStomatologForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSifra;
        private System.Windows.Forms.TextBox txbVrsta;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cbxPacijent;
        private System.Windows.Forms.Button btnKreirajIntervenciju;
    }
}