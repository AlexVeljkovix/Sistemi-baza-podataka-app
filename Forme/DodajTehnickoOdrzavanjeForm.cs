using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test3.Entiteti;

namespace Test3.Forme
{
    public partial class DodajTehnickoOdrzavanjeForm : Form
    {
        
        public DodajTehnickoOdrzavanjeForm()
        {
            InitializeComponent();
        }

        
        private void DodajTehnickoOdrzavanjeForm_Load(object sender, EventArgs e)
        {
            prikaziPodatke();
        }
        public void prikaziPodatke()
        {
            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from StomatoloskaStolica");

            IList<StomatoloskaStolica> stolice = q.List<StomatoloskaStolica>();
            List<string> lista = new List<string>();

            foreach (StomatoloskaStolica st in stolice)
                if (st.OdrzavanjeStolice == null)
                    lista.Add(st.Id.ToString());

            cbxStolica.DataSource = lista;
        }
        private void btnDodajNovuStolicu_Click(object sender, EventArgs e)
        {
            DodajStolicuForm forma=new DodajStolicuForm();
            forma.ShowDialog();
            this.prikaziPodatke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog radnika tehnickog odrzavanja?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);


            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    TehnickoOdrzavanje to = new TehnickoOdrzavanje()
                    {
                        Mbr = int.Parse(txbMbr.Text),
                        Ime = txbIme.Text,
                        Prezime = txbPrezime.Text,
                        Struka = txbStruka.Text,
                    };
                    StomatoloskaStolica stolica = s.Load<StomatoloskaStolica>(int.Parse(cbxStolica.Text));
                    stolica.OdrzavanjeStolice = to;
                    s.Save(to);
                    s.Save(stolica);
                    s.Flush();
                    s.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Uspesno ste dodali novog radnika tehnickog odrzavanja!");
            this.Close();
        }
    }
}
