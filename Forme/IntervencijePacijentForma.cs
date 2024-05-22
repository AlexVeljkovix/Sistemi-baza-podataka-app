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
    public partial class IntervencijePacijentForma : Form
    {
        public AmbulantniPacijent pacijent;
        public IntervencijePacijentForma()
        {
            InitializeComponent();
        }

        public IntervencijePacijentForma(AmbulantniPacijent a)
        {
            this.pacijent = a;
            InitializeComponent();
        }
        private void IntervenicjePacijentForma_Load(object sender, EventArgs e)
        {
            listaIntervencija.Columns.Add("Sifra intervencije", 120);
            listaIntervencija.Columns.Add("MBR stomatologa", 90);
            listaIntervencija.Columns.Add("Datum", 130);
            listaIntervencija.Columns.Add("Vrsta", 120);
            listaIntervencija.View = View.Details;
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listaIntervencija.Items.Clear();


            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Intervencija as i where i.Pacijent.Mbr = :identifikator");
                q.SetInt32("identifikator", pacijent.Mbr);

                IList<Intervencija> intervencije = q.List<Intervencija>();

                foreach (Intervencija i in intervencije)
                {
                    ListViewItem item = new ListViewItem(i.SifraIntervencije.ToString());
                    item.SubItems.Add(i.Stomatolog.Mbr.ToString());
                    item.SubItems.Add(i.Datum.ToString());
                    item.SubItems.Add(i.Vrsta);

                    listaIntervencija.Items.Add(item);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
