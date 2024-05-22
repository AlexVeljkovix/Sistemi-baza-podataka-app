namespace Test3
{
    partial class DemoModeForm
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
            this.btnUcitajPacijenta = new System.Windows.Forms.Button();
            this.btnDodajPacijenta = new System.Windows.Forms.Button();
            this.btnManyToOne = new System.Windows.Forms.Button();
            this.PrikaziLekaraOP = new System.Windows.Forms.Button();
            this.btnVezaOneToMany = new System.Windows.Forms.Button();
            this.btnDodavanjeOdrIStolica = new System.Windows.Forms.Button();
            this.btnOneToManyTO = new System.Windows.Forms.Button();
            this.btnVezaManyToMany = new System.Windows.Forms.Button();
            this.btnIntervencija = new System.Windows.Forms.Button();
            this.btnDodajLekaraOP = new System.Windows.Forms.Button();
            this.btnProstiUpit = new System.Windows.Forms.Button();
            this.btnSlozenijiUpit = new System.Windows.Forms.Button();
            this.btnVisestrukiRezultati = new System.Windows.Forms.Button();
            this.btnCriteria = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcitajPacijenta
            // 
            this.btnUcitajPacijenta.Location = new System.Drawing.Point(12, 53);
            this.btnUcitajPacijenta.Name = "btnUcitajPacijenta";
            this.btnUcitajPacijenta.Size = new System.Drawing.Size(136, 35);
            this.btnUcitajPacijenta.TabIndex = 0;
            this.btnUcitajPacijenta.Text = "Ucitaj pacijenta";
            this.btnUcitajPacijenta.UseVisualStyleBackColor = true;
            this.btnUcitajPacijenta.Click += new System.EventHandler(this.btnUcitajPacijenta_Click);
            // 
            // btnDodajPacijenta
            // 
            this.btnDodajPacijenta.Location = new System.Drawing.Point(13, 12);
            this.btnDodajPacijenta.Name = "btnDodajPacijenta";
            this.btnDodajPacijenta.Size = new System.Drawing.Size(136, 35);
            this.btnDodajPacijenta.TabIndex = 1;
            this.btnDodajPacijenta.Text = "Dodaj pacijenta";
            this.btnDodajPacijenta.UseVisualStyleBackColor = true;
            this.btnDodajPacijenta.Click += new System.EventHandler(this.btnDodajPacijenta_Click);
            // 
            // btnManyToOne
            // 
            this.btnManyToOne.Location = new System.Drawing.Point(13, 95);
            this.btnManyToOne.Name = "btnManyToOne";
            this.btnManyToOne.Size = new System.Drawing.Size(135, 35);
            this.btnManyToOne.TabIndex = 2;
            this.btnManyToOne.Text = "Veza many-to-one";
            this.btnManyToOne.UseVisualStyleBackColor = true;
            this.btnManyToOne.Click += new System.EventHandler(this.btnManyToOne_Click);
            // 
            // PrikaziLekaraOP
            // 
            this.PrikaziLekaraOP.Location = new System.Drawing.Point(155, 12);
            this.PrikaziLekaraOP.Name = "PrikaziLekaraOP";
            this.PrikaziLekaraOP.Size = new System.Drawing.Size(135, 35);
            this.PrikaziLekaraOP.TabIndex = 4;
            this.PrikaziLekaraOP.Text = "Prikazi Lekara OP";
            this.PrikaziLekaraOP.UseVisualStyleBackColor = true;
            this.PrikaziLekaraOP.Click += new System.EventHandler(this.PrikaziLekaraOP_Click);
            // 
            // btnVezaOneToMany
            // 
            this.btnVezaOneToMany.Location = new System.Drawing.Point(14, 136);
            this.btnVezaOneToMany.Name = "btnVezaOneToMany";
            this.btnVezaOneToMany.Size = new System.Drawing.Size(135, 35);
            this.btnVezaOneToMany.TabIndex = 5;
            this.btnVezaOneToMany.Text = "Veza one-to-many";
            this.btnVezaOneToMany.UseVisualStyleBackColor = true;
            this.btnVezaOneToMany.Click += new System.EventHandler(this.btnVezaOneToMany_Click);
            // 
            // btnDodavanjeOdrIStolica
            // 
            this.btnDodavanjeOdrIStolica.Location = new System.Drawing.Point(13, 177);
            this.btnDodavanjeOdrIStolica.Name = "btnDodavanjeOdrIStolica";
            this.btnDodavanjeOdrIStolica.Size = new System.Drawing.Size(135, 58);
            this.btnDodavanjeOdrIStolica.TabIndex = 6;
            this.btnDodavanjeOdrIStolica.Text = "Dodavanje odrzvanja i stolice";
            this.btnDodavanjeOdrIStolica.UseVisualStyleBackColor = true;
            this.btnDodavanjeOdrIStolica.Click += new System.EventHandler(this.btnDodavanjeOdrIStolica_Click);
            // 
            // btnOneToManyTO
            // 
            this.btnOneToManyTO.Location = new System.Drawing.Point(14, 241);
            this.btnOneToManyTO.Name = "btnOneToManyTO";
            this.btnOneToManyTO.Size = new System.Drawing.Size(135, 54);
            this.btnOneToManyTO.TabIndex = 7;
            this.btnOneToManyTO.Text = "Veza one-to-many TO";
            this.btnOneToManyTO.UseVisualStyleBackColor = true;
            this.btnOneToManyTO.Click += new System.EventHandler(this.btnOneToManyTO_Click);
            // 
            // btnVezaManyToMany
            // 
            this.btnVezaManyToMany.Location = new System.Drawing.Point(12, 301);
            this.btnVezaManyToMany.Name = "btnVezaManyToMany";
            this.btnVezaManyToMany.Size = new System.Drawing.Size(135, 67);
            this.btnVezaManyToMany.TabIndex = 8;
            this.btnVezaManyToMany.Text = "Veza many-to-many odrzavanje odeljenja";
            this.btnVezaManyToMany.UseVisualStyleBackColor = true;
            this.btnVezaManyToMany.Click += new System.EventHandler(this.btnVezaManyToMany_Click);
            // 
            // btnIntervencija
            // 
            this.btnIntervencija.Location = new System.Drawing.Point(12, 374);
            this.btnIntervencija.Name = "btnIntervencija";
            this.btnIntervencija.Size = new System.Drawing.Size(135, 67);
            this.btnIntervencija.TabIndex = 9;
            this.btnIntervencija.Text = "Veza many-to-many intervencija";
            this.btnIntervencija.UseVisualStyleBackColor = true;
            this.btnIntervencija.Click += new System.EventHandler(this.btnIntervencija_Click);
            // 
            // btnDodajLekaraOP
            // 
            this.btnDodajLekaraOP.Location = new System.Drawing.Point(155, 53);
            this.btnDodajLekaraOP.Name = "btnDodajLekaraOP";
            this.btnDodajLekaraOP.Size = new System.Drawing.Size(135, 35);
            this.btnDodajLekaraOP.TabIndex = 10;
            this.btnDodajLekaraOP.Text = "Dodaj lekara OP";
            this.btnDodajLekaraOP.UseVisualStyleBackColor = true;
            this.btnDodajLekaraOP.Click += new System.EventHandler(this.btnDodajLekaraOP_Click);
            // 
            // btnProstiUpit
            // 
            this.btnProstiUpit.Location = new System.Drawing.Point(155, 94);
            this.btnProstiUpit.Name = "btnProstiUpit";
            this.btnProstiUpit.Size = new System.Drawing.Size(135, 35);
            this.btnProstiUpit.TabIndex = 11;
            this.btnProstiUpit.Text = "Prosti upit";
            this.btnProstiUpit.UseVisualStyleBackColor = true;
            this.btnProstiUpit.Click += new System.EventHandler(this.btnProstiUpit_Click);
            // 
            // btnSlozenijiUpit
            // 
            this.btnSlozenijiUpit.Location = new System.Drawing.Point(155, 135);
            this.btnSlozenijiUpit.Name = "btnSlozenijiUpit";
            this.btnSlozenijiUpit.Size = new System.Drawing.Size(135, 58);
            this.btnSlozenijiUpit.TabIndex = 12;
            this.btnSlozenijiUpit.Text = "Upit sa parametrima";
            this.btnSlozenijiUpit.UseVisualStyleBackColor = true;
            this.btnSlozenijiUpit.Click += new System.EventHandler(this.btnSlozenijiUpit_Click);
            // 
            // btnVisestrukiRezultati
            // 
            this.btnVisestrukiRezultati.Location = new System.Drawing.Point(155, 200);
            this.btnVisestrukiRezultati.Name = "btnVisestrukiRezultati";
            this.btnVisestrukiRezultati.Size = new System.Drawing.Size(135, 35);
            this.btnVisestrukiRezultati.TabIndex = 13;
            this.btnVisestrukiRezultati.Text = "Visestruki rezultati";
            this.btnVisestrukiRezultati.UseVisualStyleBackColor = true;
            this.btnVisestrukiRezultati.Click += new System.EventHandler(this.btnVisestrukiRezultati_Click);
            // 
            // btnCriteria
            // 
            this.btnCriteria.Location = new System.Drawing.Point(155, 241);
            this.btnCriteria.Name = "btnCriteria";
            this.btnCriteria.Size = new System.Drawing.Size(135, 35);
            this.btnCriteria.TabIndex = 14;
            this.btnCriteria.Text = "Criteria";
            this.btnCriteria.UseVisualStyleBackColor = true;
            this.btnCriteria.Click += new System.EventHandler(this.btnCriteria_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(155, 282);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 35);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 461);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCriteria);
            this.Controls.Add(this.btnVisestrukiRezultati);
            this.Controls.Add(this.btnSlozenijiUpit);
            this.Controls.Add(this.btnProstiUpit);
            this.Controls.Add(this.btnDodajLekaraOP);
            this.Controls.Add(this.btnIntervencija);
            this.Controls.Add(this.btnVezaManyToMany);
            this.Controls.Add(this.btnOneToManyTO);
            this.Controls.Add(this.btnDodavanjeOdrIStolica);
            this.Controls.Add(this.btnVezaOneToMany);
            this.Controls.Add(this.PrikaziLekaraOP);
            this.Controls.Add(this.btnManyToOne);
            this.Controls.Add(this.btnDodajPacijenta);
            this.Controls.Add(this.btnUcitajPacijenta);
            this.Name = "Form1";
            this.Text = "Aplikacija za rad sa bazom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajPacijenta;
        private System.Windows.Forms.Button btnDodajPacijenta;
        private System.Windows.Forms.Button btnManyToOne;
        private System.Windows.Forms.Button PrikaziLekaraOP;
        private System.Windows.Forms.Button btnVezaOneToMany;
        private System.Windows.Forms.Button btnDodavanjeOdrIStolica;
        private System.Windows.Forms.Button btnOneToManyTO;
        private System.Windows.Forms.Button btnVezaManyToMany;
        private System.Windows.Forms.Button btnIntervencija;
        private System.Windows.Forms.Button btnDodajLekaraOP;
        private System.Windows.Forms.Button btnProstiUpit;
        private System.Windows.Forms.Button btnSlozenijiUpit;
        private System.Windows.Forms.Button btnVisestrukiRezultati;
        private System.Windows.Forms.Button btnCriteria;
        private System.Windows.Forms.Button btnUpdate;
    }
}

