namespace Test3.Entiteti
{
    partial class IntervencijeForm
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
            this.btnNovaIntervencija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaIntervencija
            // 
            this.listaIntervencija.HideSelection = false;
            this.listaIntervencija.Location = new System.Drawing.Point(9, 10);
            this.listaIntervencija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaIntervencija.Name = "listaIntervencija";
            this.listaIntervencija.Size = new System.Drawing.Size(449, 171);
            this.listaIntervencija.TabIndex = 0;
            this.listaIntervencija.UseCompatibleStateImageBehavior = false;
            // 
            // btnNovaIntervencija
            // 
            this.btnNovaIntervencija.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNovaIntervencija.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaIntervencija.Location = new System.Drawing.Point(10, 201);
            this.btnNovaIntervencija.Name = "btnNovaIntervencija";
            this.btnNovaIntervencija.Size = new System.Drawing.Size(150, 40);
            this.btnNovaIntervencija.TabIndex = 46;
            this.btnNovaIntervencija.Text = "Nova intervencija";
            this.btnNovaIntervencija.UseVisualStyleBackColor = false;
            this.btnNovaIntervencija.Click += new System.EventHandler(this.btnNovaIntervencija_Click);
            // 
            // IntervencijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 251);
            this.Controls.Add(this.btnNovaIntervencija);
            this.Controls.Add(this.listaIntervencija);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IntervencijeForm";
            this.Text = "Informacije o intervenciji";
            this.Load += new System.EventHandler(this.IntervencijeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaIntervencija;
        private System.Windows.Forms.Button btnNovaIntervencija;
    }
}