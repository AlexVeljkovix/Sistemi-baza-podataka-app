using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test3.Entiteti;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Test3.Forme
{
    public partial class UpdateLSForm : Form
    {
        public LekariSpecijalisti specijalista;
        public UpdateLSForm()
        {
            InitializeComponent();
        }

        public UpdateLSForm(LekariSpecijalisti s)
        {
            this.specijalista = s;
            InitializeComponent();
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmenu lekara specijaliste?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    LekariSpecijalisti sp = s.Load<LekariSpecijalisti>(this.specijalista.Mbr);

                    this.specijalista.Mbr = int.Parse(txbMbr.Text);
                    this.specijalista.Ime = txbIme.Text;
                    this.specijalista.Prezime = txbPrezime.Text;
                    this.specijalista.GodineRadnogStaza = int.Parse(txbGodine.Text);
                    this.specijalista.Specijalnost = txbSpecijalnost.Text;


                    sp.Mbr = specijalista.Mbr;
                    sp.Ime = specijalista.Ime;
                    sp.Prezime = specijalista.Prezime;
                    sp.GodineRadnogStaza = specijalista.GodineRadnogStaza;
                    sp.Specijalnost = specijalista.Specijalnost;


                    s.Update(sp);
                    s.Flush();
                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }




                MessageBox.Show("Azuriranje lekara specijaliste je uspesno izvrseno!");
                this.Close();
            }
        }

        private void UpdateLSForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE LEKARA SPECIJALISTE {specijalista.Ime.ToUpper()} {specijalista.Prezime.ToUpper()}";
        }

        public void popuniPodacima()
        {
            txbMbr.Text = specijalista.Mbr.ToString();
            txbIme.Text = specijalista.Ime;
            txbPrezime.Text = specijalista.Prezime;
            txbGodine.Text = specijalista.GodineRadnogStaza.ToString();
            txbSpecijalnost.Text = specijalista.Specijalnost;
        }
    }
}
