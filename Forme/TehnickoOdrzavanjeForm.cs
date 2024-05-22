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
    public partial class TehnickoOdrzavanjeForm : Form
    {
        public TehnickoOdrzavanjeForm()
        {
            InitializeComponent();
        }

        private void TehnickoOdrzavanjeForm_Load(object sender, EventArgs e)
        {
            listaTO.Columns.Add("MBR", 70);
            listaTO.Columns.Add("Ime", 120);
            listaTO.Columns.Add("Prezime", 120);
            listaTO.Columns.Add("Struka", 180);
            listaTO.View = View.Details;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listaTO.Items.Clear();
            List<TehnickoOdrzavanje> to = new List<TehnickoOdrzavanje>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<TehnickoOdrzavanje> teh = from o in s.Query<TehnickoOdrzavanje>()
                                               select o;
                to = teh.ToList();

                foreach (TehnickoOdrzavanje t in to)
                {
                    ListViewItem item = new ListViewItem(t.Mbr.ToString());
                    item.SubItems.Add(t.Ime);
                    item.SubItems.Add(t.Prezime);
                    item.SubItems.Add(t.Struka);
                    listaTO.Items.Add(item);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaTO.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite MBR radnika tehnickog odrzavanja kog zelite da obrisete!");
                    return;
                }

                int idTo = Int32.Parse(listaTO.SelectedItems[0].SubItems[0].Text);
                string poruka = "Da li zelite da obrisete izabranog radnika tehnickog odrzavanja?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    TehnickoOdrzavanje t = s.Load<TehnickoOdrzavanje>(idTo);

                    s.Delete(t);
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Brisanje radnika tehnickog odrzavanja je uspesno obavljeno!");
                    this.popuniPodacima();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaTO.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite MBR radnika tehnickog odrzavanja cije podatke zelite da izmenite!");
                return;
            }

            int idTo = Int32.Parse(listaTO.SelectedItems[0].SubItems[0].Text);

            ISession s = DataLayer.GetSession();
            TehnickoOdrzavanje t = s.Load<TehnickoOdrzavanje>(idTo);

            TehnickoOdrzavanjeUpdateForm formaUpdate = new TehnickoOdrzavanjeUpdateForm(t);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajTehnickoOdrzavanjeForm form = new DodajTehnickoOdrzavanjeForm();
            form.ShowDialog();
            this.popuniPodacima();
        }
    }
}
