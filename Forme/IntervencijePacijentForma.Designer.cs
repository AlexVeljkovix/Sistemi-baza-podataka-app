namespace Test3.Forme
{
    partial class IntervencijePacijentForma
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
            this.listaIntervencija = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listaIntervencija
            // 
            this.listaIntervencija.HideSelection = false;
            this.listaIntervencija.Location = new System.Drawing.Point(12, 12);
            this.listaIntervencija.Name = "listaIntervencija";
            this.listaIntervencija.Size = new System.Drawing.Size(619, 209);
            this.listaIntervencija.TabIndex = 1;
            this.listaIntervencija.UseCompatibleStateImageBehavior = false;
            // 
            // IntervenicjePacijentForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 237);
            this.Controls.Add(this.listaIntervencija);
            this.Name = "IntervenicjePacijentForma";
            this.Text = "Informacije o intervencijama";
            this.Load += new System.EventHandler(this.IntervenicjePacijentForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaIntervencija;
    }
}