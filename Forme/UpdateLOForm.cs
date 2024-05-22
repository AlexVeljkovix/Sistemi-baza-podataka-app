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

namespace Test3.Forme
{
    public partial class UpdateLOForm : Form
    {
        public LekariOpstePrakse lekar;
        public UpdateLOForm()
        {
            InitializeComponent();
        }

        public UpdateLOForm(LekariOpstePrakse l)
        {
            InitializeComponent();
            this.lekar = l;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmenu lekara opste prakse?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    LekariOpstePrakse lo = s.Load<LekariOpstePrakse>(this.lekar.Mbr);

                    this.lekar.Mbr = int.Parse(tbxMbr.Text);
                    this.lekar.Ime = tbxIme.Text;
                    this.lekar.Prezime = tbxPrezime.Text;
                    this.lekar.GodineRadnogStaza = int.Parse(tbxGodine.Text);
                    this.lekar.BrOrdinacije = int.Parse(tbxBrojOrdinacije.Text);


                    lo.Mbr = lekar.Mbr;
                    lo.Ime = lekar.Ime;
                    lo.Prezime = lekar.Prezime;
                    lo.GodineRadnogStaza = lekar.GodineRadnogStaza;
                    lo.BrOrdinacije = lekar.BrOrdinacije;


                    s.Update(lo);
                    s.Flush();
                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }




                MessageBox.Show("Azuriranje lekara opste prakse je uspesno izvrseno!");
                this.Close();
            }
        }

        private void UpdateLOForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE LEKARA OPSTE PRAKSE {lekar.Ime.ToUpper()} {lekar.Prezime.ToUpper()}";
        }

        public void popuniPodacima()
        {
            tbxMbr.Text = lekar.Mbr.ToString();
            tbxIme.Text = lekar.Ime;
            tbxPrezime.Text = lekar.Prezime;
            tbxGodine.Text = lekar.GodineRadnogStaza.ToString();
            tbxBrojOrdinacije.Text =lekar.BrOrdinacije.ToString();
        }

    }
}
