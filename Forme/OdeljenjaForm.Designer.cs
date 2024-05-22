namespace Test3.Forme
{
    partial class OdeljenjaForm
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
            this.listaOdeljenja = new System.Windows.Forms.ListView();
            this.btnDodajOdeljenje = new System.Windows.Forms.Button();
            this.btnObrisiOdeljenje = new System.Windows.Forms.Button();
            this.BtnIzmeniPacijenta = new System.Windows.Forms.Button();
            this.btnPacijenti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaOdeljenja
            // 
            this.listaOdeljenja.HideSelection = false;
            this.listaOdeljenja.Location = new System.Drawing.Point(15, 14);
            this.listaOdeljenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaOdeljenja.Name = "listaOdeljenja";
            this.listaOdeljenja.Size = new System.Drawing.Size(748, 384);
            this.listaOdeljenja.TabIndex = 40;
            this.listaOdeljenja.UseCompatibleStateImageBehavior = false;
            // 
            // btnDodajOdeljenje
            // 
            this.btnDodajOdeljenje.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodajOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajOdeljenje.Location = new System.Drawing.Point(829, 14);
            this.btnDodajOdeljenje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajOdeljenje.Name = "btnDodajOdeljenje";
            this.btnDodajOdeljenje.Size = new System.Drawing.Size(200, 49);
            this.btnDodajOdeljenje.TabIndex = 41;
            this.btnDodajOdeljenje.Text = "Dodaj odeljenje";
            this.btnDodajOdeljenje.UseVisualStyleBackColor = false;
            this.btnDodajOdeljenje.Click += new System.EventHandler(this.btnDodajOdeljenje_Click);
            // 
            // btnObrisiOdeljenje
            // 
            this.btnObrisiOdeljenje.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnObrisiOdeljenje.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiOdeljenje.Location = new System.Drawing.Point(829, 70);
            this.btnObrisiOdeljenje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiOdeljenje.Name = "btnObrisiOdeljenje";
            this.btnObrisiOdeljenje.Size = new System.Drawing.Size(200, 49);
            this.btnObrisiOdeljenje.TabIndex = 42;
            this.btnObrisiOdeljenje.Text = "Obrisi odeljenje";
            this.btnObrisiOdeljenje.UseVisualStyleBackColor = false;
            this.btnObrisiOdeljenje.Click += new System.EventHandler(this.btnObrisiOdeljenje_Click);
            // 
            // BtnIzmeniPacijenta
            // 
            this.BtnIzmeniPacijenta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnIzmeniPacijenta.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzmeniPacijenta.Location = new System.Drawing.Point(829, 127);
            this.BtnIzmeniPacijenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnIzmeniPacijenta.Name = "BtnIzmeniPacijenta";
            this.BtnIzmeniPacijenta.Size = new System.Drawing.Size(200, 49);
            this.BtnIzmeniPacijenta.TabIndex = 43;
            this.BtnIzmeniPacijenta.Text = "Izmeni odeljenje";
            this.BtnIzmeniPacijenta.UseVisualStyleBackColor = false;
            this.BtnIzmeniPacijenta.Click += new System.EventHandler(this.BtnIzmeniPacijenta_Click);
            // 
            // btnPacijenti
            // 
            this.btnPacijenti.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPacijenti.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacijenti.Location = new System.Drawing.Point(829, 350);
            this.btnPacijenti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPacijenti.Name = "btnPacijenti";
            this.btnPacijenti.Size = new System.Drawing.Size(200, 49);
            this.btnPacijenti.TabIndex = 44;
            this.btnPacijenti.Text = "Pacijenti na odeljenju";
            this.btnPacijenti.UseVisualStyleBackColor = false;
            this.btnPacijenti.Click += new System.EventHandler(this.btnPacijenti_Click);
            // 
            // OdeljenjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 437);
            this.Controls.Add(this.btnPacijenti);
            this.Controls.Add(this.BtnIzmeniPacijenta);
            this.Controls.Add(this.btnObrisiOdeljenje);
            this.Controls.Add(this.btnDodajOdeljenje);
            this.Controls.Add(this.listaOdeljenja);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OdeljenjaForm";
            this.Text = "Pregled svih odeljenja";
            this.Load += new System.EventHandler(this.OdeljenjaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaOdeljenja;
        private System.Windows.Forms.Button btnDodajOdeljenje;
        private System.Windows.Forms.Button btnObrisiOdeljenje;
        private System.Windows.Forms.Button BtnIzmeniPacijenta;
        private System.Windows.Forms.Button btnPacijenti;
    }
}