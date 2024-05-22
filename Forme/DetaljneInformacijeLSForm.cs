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
    public partial class DetaljneInformacijeLSForm : Form
    {
        public LekariSpecijalisti specijalista;
        public DetaljneInformacijeLSForm()
        {
            InitializeComponent();
        }
        public DetaljneInformacijeLSForm(LekariSpecijalisti s)
        {
            this.specijalista = s;
            InitializeComponent();
        }


        private void DetaljneInformacijeLSForm_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from Odeljenje as o where o.LekarSpecijalista.Mbr = :identifikator");
            q.SetInt32("identifikator", specijalista.Mbr);

            IList<Odeljenje> odeljenja = q.List<Odeljenje>();
            List<string> lista = new List<string>();

            foreach (Odeljenje o in odeljenja)
                if (0 != null)
                    lista.Add(o.SifraOdeljenja.ToString());

            cbxOdeljenja.DataSource = lista;

            popuniPodacima();
            this.Text = $"INFORMACIJE O LEKARU SPECIJALISTI {specijalista.Ime.ToUpper()} {specijalista.Prezime.ToUpper()}";
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
