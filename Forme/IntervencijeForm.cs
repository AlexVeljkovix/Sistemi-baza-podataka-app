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
using Test3.Forme;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace Test3.Entiteti
{
    public partial class IntervencijeForm : Form
    {
        Stomatolozi stomatolog;
        
        public IntervencijeForm()
        {
            InitializeComponent();
        }

        public IntervencijeForm(Stomatolozi s=null)
        {
            this.stomatolog = s;
            
            InitializeComponent();
        }
        
        private void IntervencijeForm_Load(object sender, EventArgs e)
        {
            listaIntervencija.Columns.Add("Sifra intervencije", 120);
            listaIntervencija.Columns.Add("MBR Pacijenta", 90);
            listaIntervencija.Columns.Add("Datum", 130);
            listaIntervencija.Columns.Add("Vrsta", 130);
            listaIntervencija.View = View.Details;
            popuniPodacima();

        }
        public void popuniPodacima()
        {
            listaIntervencija.Items.Clear();
            

            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Intervencija as i where i.Stomatolog.Mbr = :identifikator");
                q.SetInt32("identifikator", stomatolog.Mbr);

                IList<Intervencija> intervencije = q.List<Intervencija>();
               
                foreach (Intervencija i in intervencije)
                {
                    ListViewItem item = new ListViewItem(i.SifraIntervencije.ToString());
                    item.SubItems.Add(i.Pacijent.Mbr.ToString());
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

        private void btnNovaIntervencija_Click(object sender, EventArgs e)
        {
            NovaIntervencijaStomatologForm forma = new NovaIntervencijaStomatologForm(stomatolog);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
