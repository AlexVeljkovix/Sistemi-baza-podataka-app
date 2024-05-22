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
    public partial class AmbulPacForm : Form
    {
        public AmbulPacForm()
        {
            InitializeComponent();
        }

        private void AmbulPac_Load(object sender, EventArgs e)
        {
            listaAmbulPacijenata.Columns.Add("MBR", 70);
            listaAmbulPacijenata.Columns.Add("Ime", 120);
            listaAmbulPacijenata.Columns.Add("Prezime", 120);
            listaAmbulPacijenata.Columns.Add("Tip pacijenta", 100);
            listaAmbulPacijenata.Columns.Add("Adresa", 100);

            listaAmbulPacijenata.View = View.Details;
            popuniPodacima();
        }

        public void popuniPodacima()
        {


            listaAmbulPacijenata.Items.Clear();
            List<AmbulantniPacijent> pacijenti = new List<AmbulantniPacijent>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<AmbulantniPacijent> sviPacijenti = from o in s.Query<AmbulantniPacijent>()
                                                     select o;

                pacijenti = sviPacijenti.ToList();

                

                foreach (AmbulantniPacijent p in pacijenti)
                {
                    ListViewItem item = new ListViewItem(p.Mbr.ToString());
                    item.SubItems.Add(p.Ime);
                    item.SubItems.Add(p.Prezime);
                    item.SubItems.Add(p.TipPacijenta);
                    item.SubItems.Add(p.Adresa);

                    listaAmbulPacijenata.Items.Add(item);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnIntervencije_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaAmbulPacijenata.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite MBR pacijenta cije intervencije zelite da pogledate!");
                    return;
                }

                int idPacijenta = Int32.Parse(listaAmbulPacijenata.SelectedItems[0].SubItems[0].Text);
                ISession s = DataLayer.GetSession();
                AmbulantniPacijent p = s.Load<AmbulantniPacijent>(idPacijenta);



                IntervencijePacijentForma forma = new IntervencijePacijentForma(p);
                forma.ShowDialog();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
