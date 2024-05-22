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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Test3.Forme
{
    public partial class PacijentUpdateForm : Form
    {

        public Pacijent p;
        public PacijentUpdateForm()
        {
            InitializeComponent();
        }

        public PacijentUpdateForm(Pacijent p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void PacijentUpdate_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE PACIJENTA {p.Ime.ToUpper()} {p.Prezime.ToUpper()}";
        }

        public void popuniPodacima()
        {
            txbMbr.Text = this.p.Mbr.ToString();
            txbIme.Text = this.p.Ime;
            txbPrezime.Text = this.p.Prezime;
        }

       

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene pacijenta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {     
                try
                {
                    ISession s = DataLayer.GetSession();
                    Pacijent pa = s.Load<Pacijent>(this.p.Mbr);

                    this.p.Mbr = int.Parse(txbMbr.Text);
                    this.p.Ime = txbIme.Text;
                    this.p.Prezime = txbPrezime.Text;

                    pa.Mbr = p.Mbr;
                    pa.Ime = p.Ime;
                    pa.Prezime = p.Prezime;
                   

                    s.Update(pa);
                    s.Flush();
                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }




                MessageBox.Show("Azuriranje pacijenta je uspesno izvrseno!");
                this.Close();

            }
        }   
    }
}
