namespace Test3.Forme
{
    partial class StomatoloskaStolicaInfoForm
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
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbDatumP = new System.Windows.Forms.TextBox();
            this.txbProizvodjac = new System.Windows.Forms.TextBox();
            this.txbTehnickoOdrzavanje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proizvodjac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tehnicko odrzavanje";
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(249, 42);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(157, 22);
            this.txbId.TabIndex = 4;
            // 
            // txbDatumP
            // 
            this.txbDatumP.Enabled = false;
            this.txbDatumP.Location = new System.Drawing.Point(249, 87);
            this.txbDatumP.Name = "txbDatumP";
            this.txbDatumP.Size = new System.Drawing.Size(157, 22);
            this.txbDatumP.TabIndex = 5;
            // 
            // txbProizvodjac
            // 
            this.txbProizvodjac.Enabled = false;
            this.txbProizvodjac.Location = new System.Drawing.Point(249, 131);
            this.txbProizvodjac.Name = "txbProizvodjac";
            this.txbProizvodjac.Size = new System.Drawing.Size(157, 22);
            this.txbProizvodjac.TabIndex = 6;
            // 
            // txbTehnickoOdrzavanje
            // 
            this.txbTehnickoOdrzavanje.Enabled = false;
            this.txbTehnickoOdrzavanje.Location = new System.Drawing.Point(249, 178);
            this.txbTehnickoOdrzavanje.Name = "txbTehnickoOdrzavanje";
            this.txbTehnickoOdrzavanje.Size = new System.Drawing.Size(157, 22);
            this.txbTehnickoOdrzavanje.TabIndex = 7;
            // 
            // StomatoloskaStolicaInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 244);
            this.Controls.Add(this.txbTehnickoOdrzavanje);
            this.Controls.Add(this.txbProizvodjac);
            this.Controls.Add(this.txbDatumP);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StomatoloskaStolicaInfoForm";
            this.Text = "Informacije o stomatoloskoj stolici";
            this.Load += new System.EventHandler(this.StomatoloskaStolicaInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbDatumP;
        private System.Windows.Forms.TextBox txbProizvodjac;
        private System.Windows.Forms.TextBox txbTehnickoOdrzavanje;
    }
}