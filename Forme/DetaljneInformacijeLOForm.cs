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
    public partial class DetaljneInformacijeLOForm : Form
    {
        public LekariOpstePrakse lekar;
        public DetaljneInformacijeLOForm()
        {
            InitializeComponent();
        }

        public DetaljneInformacijeLOForm(LekariOpstePrakse l)
        {
            this.lekar = l;
            InitializeComponent();
        }

        private void DetaljneInformacijeLSForm_Load(object sender, EventArgs e)
        {
            
            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from Pacijent as p where p.LekarOP.Mbr = :identifikator");
            q.SetInt32("identifikator", lekar.Mbr);

            IList<Pacijent> pacijenti = q.List<Pacijent>();
            List<string> lista = new List<string>();

            foreach (Pacijent p in pacijenti)
                if(p!=null)
                 lista.Add(p.Mbr.ToString());

            cbxListaPacijenata.DataSource = lista;

           
            popuniPodacima();
            this.Text = $"INFORMACIJE O LEKARU OPSTE PRAKSE {lekar.Ime.ToUpper()} {lekar.Prezime.ToUpper()}";
        }
        public void popuniPodacima()
        {
            tbxMbr.Text = lekar.Mbr.ToString();
            tbxIme.Text = lekar.Ime;
            tbxPrezime.Text = lekar.Prezime;
            tbxGodine.Text = lekar.GodineRadnogStaza.ToString();
            tbxBrojOrdinacije.Text = lekar.BrOrdinacije.ToString();
        }
    }
}
