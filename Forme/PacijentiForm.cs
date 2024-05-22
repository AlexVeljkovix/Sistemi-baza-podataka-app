using FluentNHibernate.Testing.Values;
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
    public partial class PacijentiForm : Form
    {
        public PacijentiForm()
        {
            InitializeComponent();
        }

        private void Pacijenti_Load(object sender, EventArgs e)
        {
            listaPacijenata.Columns.Add("MBR", 70);
            listaPacijenata.Columns.Add("Ime", 120);
            listaPacijenata.Columns.Add("Prezime", 120);
            listaPacijenata.Columns.Add("Tip pacijenta", 100);
            listaPacijenata.Columns.Add("Ime lekara OP", 100);
            listaPacijenata.Columns.Add("Prezime lekara OP", 120);
            listaPacijenata.Columns.Add("Lekar opste prakse", 120);
            listaPacijenata.View = View.Details;


            popuniPodacima();
        }

        public void popuniPodacima()
        {

            listaPacijenata.Items.Clear();
            List<Pacijent> pacijenti = new List<Pacijent>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Pacijent> sviPacijenti = from o in s.Query<Pacijent>()
                                                     select o;
                pacijenti = sviPacijenti.ToList();

                

                foreach (Pacijent p in pacijenti)
                {
                    ListViewItem item = new ListViewItem(p.Mbr.ToString());
                    item.SubItems.Add(p.Ime);
                    item.SubItems.Add(p.Prezime);
                    item.SubItems.Add(p.TipPacijenta);
                    if (p.LekarOP != null)
                    {
                        item.SubItems.Add(p.LekarOP.Ime);
                        item.SubItems.Add(p.LekarOP.Prezime);
                        item.SubItems.Add(p.LekarOP.Mbr.ToString());
                    }
                    else
                    {
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                        item.SubItems.Add("Nema lekara OP");
                    }

                    listaPacijenata.Items.Add(item);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnObrisiPacijenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaPacijenata.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite MBR pacijenta kog zelite da obrisete!");
                    return;
                }

                int idPacijenta = Int32.Parse(listaPacijenata.SelectedItems[0].SubItems[0].Text);
                string poruka = "Da li zelite da obrisete izabranog pacijenta?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    Pacijent p = s.Load<Pacijent>(idPacijenta);

                    s.Delete(p);
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Brisanje pacijenta je uspesno obavljeno!");
                    this.popuniPodacima();
                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void BtnIzmeniPacijenta_Click(object sender, EventArgs e)
        {
            if (listaPacijenata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pacijenta cije podatke zelite da izmenite!");
                return;
            }

            int idPacijenta = Int32.Parse(listaPacijenata.SelectedItems[0].SubItems[0].Text);

            ISession s = DataLayer.GetSession();
            Pacijent p = s.Load<Pacijent>(idPacijenta);

            PacijentUpdateForm formaUpdate = new PacijentUpdateForm(p);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnStacPacijenti_Click(object sender, EventArgs e)
        {
            StacPacijentiForm forma = new StacPacijentiForm();
            forma.ShowDialog();
        }

        private void btnAmbPacijenti_Click(object sender, EventArgs e)
        {
            AmbulPacForm forma = new AmbulPacForm();
            forma.ShowDialog();
        }

        private void btnDodajPacijenta_Click(object sender, EventArgs e)
        {
            DodajPacijentaForm form = new DodajPacijentaForm();
            form.ShowDialog();
            this.popuniPodacima();
        }

        private void btnLekar_Click(object sender, EventArgs e)
        {
            if (listaPacijenata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite pacijenta cijeg lekara zelite da pogledate!");
                return;
            }
            
            try
            {
                ISession session=DataLayer.GetSession();
                int idPacijenta = Int32.Parse(listaPacijenata.SelectedItems[0].SubItems[0].Text);
                Pacijent p = session.Load<Pacijent>(idPacijenta);
                if(p.LekarOP!=null)
                {
                    LekarInfo forma = new LekarInfo(p.LekarOP);
                    forma.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Morate izabrati ambulantnog pacijenta!", "Pogresan unos!");
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
