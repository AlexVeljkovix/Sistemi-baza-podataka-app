﻿namespace Test3.Forme
{
    partial class StacPacijentiForm
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
            this.listaStacPacijenata = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listaStacPacijenata
            // 
            this.listaStacPacijenata.HideSelection = false;
            this.listaStacPacijenata.Location = new System.Drawing.Point(12, 12);
            this.listaStacPacijenata.Name = "listaStacPacijenata";
            this.listaStacPacijenata.Size = new System.Drawing.Size(846, 351);
            this.listaStacPacijenata.TabIndex = 40;
            this.listaStacPacijenata.UseCompatibleStateImageBehavior = false;
            // 
            // StacPacijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 375);
            this.Controls.Add(this.listaStacPacijenata);
            this.Name = "StacPacijenti";
            this.Text = "Stacionarni pacijenti";
            this.Load += new System.EventHandler(this.StacPacijenti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaStacPacijenata;
    }
}