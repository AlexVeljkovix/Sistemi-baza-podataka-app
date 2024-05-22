namespace Test3.Forme
{
    partial class NeMedOsobljeForm
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
            this.btnTehnickoOdrzavanje = new System.Windows.Forms.Button();
            this.btnHigijenicari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTehnickoOdrzavanje
            // 
            this.btnTehnickoOdrzavanje.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTehnickoOdrzavanje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTehnickoOdrzavanje.Location = new System.Drawing.Point(13, 13);
            this.btnTehnickoOdrzavanje.Margin = new System.Windows.Forms.Padding(4);
            this.btnTehnickoOdrzavanje.Name = "btnTehnickoOdrzavanje";
            this.btnTehnickoOdrzavanje.Size = new System.Drawing.Size(353, 49);
            this.btnTehnickoOdrzavanje.TabIndex = 48;
            this.btnTehnickoOdrzavanje.Text = "Tehnicko odrzavanje";
            this.btnTehnickoOdrzavanje.UseVisualStyleBackColor = false;
            this.btnTehnickoOdrzavanje.Click += new System.EventHandler(this.btnTehnickoOdrzavanje_Click);
            // 
            // btnHigijenicari
            // 
            this.btnHigijenicari.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHigijenicari.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHigijenicari.Location = new System.Drawing.Point(13, 82);
            this.btnHigijenicari.Margin = new System.Windows.Forms.Padding(4);
            this.btnHigijenicari.Name = "btnHigijenicari";
            this.btnHigijenicari.Size = new System.Drawing.Size(353, 49);
            this.btnHigijenicari.TabIndex = 49;
            this.btnHigijenicari.Text = "Higijenicari";
            this.btnHigijenicari.UseVisualStyleBackColor = false;
            this.btnHigijenicari.Click += new System.EventHandler(this.btnHigijenicari_Click);
            // 
            // NeMedOsobljeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 158);
            this.Controls.Add(this.btnHigijenicari);
            this.Controls.Add(this.btnTehnickoOdrzavanje);
            this.Name = "NeMedOsobljeForm";
            this.Text = "Nemedicinsko osoblje";
            this.Load += new System.EventHandler(this.NeMedOsobljeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTehnickoOdrzavanje;
        private System.Windows.Forms.Button btnHigijenicari;
    }
}