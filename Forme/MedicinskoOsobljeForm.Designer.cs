namespace Test3.Forme
{
    partial class MedicinskoOsobljeForm
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
            this.listaMOsoblje = new System.Windows.Forms.ListView();
            this.btnDetaljniInfo = new System.Windows.Forms.Button();
            this.btnIzmeniMo = new System.Windows.Forms.Button();
            this.btnObrisiMo = new System.Windows.Forms.Button();
            this.btnDodajMo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaMOsoblje
            // 
            this.listaMOsoblje.HideSelection = false;
            this.listaMOsoblje.Location = new System.Drawing.Point(12, 34);
            this.listaMOsoblje.Name = "listaMOsoblje";
            this.listaMOsoblje.Size = new System.Drawing.Size(789, 384);
            this.listaMOsoblje.TabIndex = 46;
            this.listaMOsoblje.UseCompatibleStateImageBehavior = false;
            // 
            // btnDetaljniInfo
            // 
            this.btnDetaljniInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDetaljniInfo.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetaljniInfo.Location = new System.Drawing.Point(829, 369);
            this.btnDetaljniInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetaljniInfo.Name = "btnDetaljniInfo";
            this.btnDetaljniInfo.Size = new System.Drawing.Size(200, 49);
            this.btnDetaljniInfo.TabIndex = 45;
            this.btnDetaljniInfo.Text = "Detaljnije informacije";
            this.btnDetaljniInfo.UseVisualStyleBackColor = false;
            this.btnDetaljniInfo.Click += new System.EventHandler(this.btnDetaljniInfo_Click);
            // 
            // btnIzmeniMo
            // 
            this.btnIzmeniMo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIzmeniMo.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniMo.Location = new System.Drawing.Point(829, 149);
            this.btnIzmeniMo.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniMo.Name = "btnIzmeniMo";
            this.btnIzmeniMo.Size = new System.Drawing.Size(200, 49);
            this.btnIzmeniMo.TabIndex = 42;
            this.btnIzmeniMo.Text = "Izmeni MO";
            this.btnIzmeniMo.UseVisualStyleBackColor = false;
            this.btnIzmeniMo.Click += new System.EventHandler(this.btnIzmeniMo_Click);
            // 
            // btnObrisiMo
            // 
            this.btnObrisiMo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnObrisiMo.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiMo.Location = new System.Drawing.Point(829, 92);
            this.btnObrisiMo.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiMo.Name = "btnObrisiMo";
            this.btnObrisiMo.Size = new System.Drawing.Size(200, 49);
            this.btnObrisiMo.TabIndex = 41;
            this.btnObrisiMo.Text = "Obrisi MO";
            this.btnObrisiMo.UseVisualStyleBackColor = false;
            this.btnObrisiMo.Click += new System.EventHandler(this.btnObrisiMo_Click);
            // 
            // btnDodajMo
            // 
            this.btnDodajMo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDodajMo.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajMo.Location = new System.Drawing.Point(829, 35);
            this.btnDodajMo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajMo.Name = "btnDodajMo";
            this.btnDodajMo.Size = new System.Drawing.Size(200, 49);
            this.btnDodajMo.TabIndex = 40;
            this.btnDodajMo.Text = "Dodaj MO";
            this.btnDodajMo.UseVisualStyleBackColor = false;
            this.btnDodajMo.Click += new System.EventHandler(this.btnDodajMo_Click);
            // 
            // MedicinskoOsobljeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 466);
            this.Controls.Add(this.listaMOsoblje);
            this.Controls.Add(this.btnDetaljniInfo);
            this.Controls.Add(this.btnIzmeniMo);
            this.Controls.Add(this.btnObrisiMo);
            this.Controls.Add(this.btnDodajMo);
            this.Name = "MedicinskoOsobljeForm";
            this.Text = "Medicinsko osoblje";
            this.Load += new System.EventHandler(this.MedicinskoOsobljeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaMOsoblje;
        private System.Windows.Forms.Button btnDetaljniInfo;
        private System.Windows.Forms.Button btnIzmeniMo;
        private System.Windows.Forms.Button btnObrisiMo;
        private System.Windows.Forms.Button btnDodajMo;
    }
}