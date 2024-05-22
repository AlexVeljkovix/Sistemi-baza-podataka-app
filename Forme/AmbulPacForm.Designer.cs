namespace Test3.Forme
{
    partial class AmbulPacForm
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
            this.listaAmbulPacijenata = new System.Windows.Forms.ListView();
            this.btnIntervencije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaAmbulPacijenata
            // 
            this.listaAmbulPacijenata.HideSelection = false;
            this.listaAmbulPacijenata.Location = new System.Drawing.Point(12, 12);
            this.listaAmbulPacijenata.Name = "listaAmbulPacijenata";
            this.listaAmbulPacijenata.Size = new System.Drawing.Size(705, 287);
            this.listaAmbulPacijenata.TabIndex = 40;
            this.listaAmbulPacijenata.UseCompatibleStateImageBehavior = false;
            // 
            // btnIntervencije
            // 
            this.btnIntervencije.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIntervencije.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIntervencije.Location = new System.Drawing.Point(261, 314);
            this.btnIntervencije.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntervencije.Name = "btnIntervencije";
            this.btnIntervencije.Size = new System.Drawing.Size(189, 41);
            this.btnIntervencije.TabIndex = 41;
            this.btnIntervencije.Text = "Intervencije";
            this.btnIntervencije.UseVisualStyleBackColor = false;
            this.btnIntervencije.Click += new System.EventHandler(this.btnIntervencije_Click);
            // 
            // AmbulPacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 368);
            this.Controls.Add(this.btnIntervencije);
            this.Controls.Add(this.listaAmbulPacijenata);
            this.Name = "AmbulPacForm";
            this.Text = "Ambulantni pacijenti";
            this.Load += new System.EventHandler(this.AmbulPac_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaAmbulPacijenata;
        private System.Windows.Forms.Button btnIntervencije;
    }
}