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
using Test3.Mapiranja;

namespace Test3.Forme
{
    public partial class OdeljenjaForm : Form
    {
        public OdeljenjaForm()
        {
            InitializeComponent();
        }

        private void OdeljenjaForm_Load(object sender, EventArgs e)
        {
            listaOdeljenja.Columns.Add("Sifra odeljenja", 70);
            listaOdeljenja.Columns.Add("Datum izgradnje", 120);
            listaOdeljenja.Columns.Add("Tip", 120);
            listaOdeljenja.Columns.Add("Mbr lekara specijaliste", 120);
            listaOdeljenja.View = View.Details;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listaOdeljenja.Items.Clear();
            List<Odeljenje> odeljenja = new List<Odeljenje>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Odeljenje> svaOdeljenja = from o in s.Query<Odeljenje>()
                                                     select o;
                odeljenja = svaOdeljenja.ToList();



                foreach (Odeljenje o in odeljenja)
                {
                    ListViewItem item = new ListViewItem(o.SifraOdeljenja.ToString());
                    item.SubItems.Add(o.DatumIzgradnje.ToString());
                    item.SubItems.Add(o.Tip);
                    item.SubItems.Add(o.LekarSpecijalista.Mbr.ToString());
                    if (o.LekarSpecijalista != null)
                        item.SubItems.Add(o.LekarSpecijalista.Mbr.ToString());
                    else item.SubItems.Add("Nema lekara SPECIJALISTE");

                    listaOdeljenja.Items.Add(item);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnObrisiOdeljenje_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaOdeljenja.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite Sifru odeljenja koje zelite da obrisete!");
                    return;
                }

                int idOdeljenja = Int32.Parse(listaOdeljenja.SelectedItems[0].SubItems[0].Text);
                string poruka = "Da li zelite da obrisete izabrano odeljenje?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    Odeljenje o = s.Load<Odeljenje>(idOdeljenja);

                    s.Delete(o);
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Brisanje odeljenja je uspesno obavljeno!");
                    this.popuniPodacima();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajOdeljenje_Click(object sender, EventArgs e)
        {
            DodajOdeljenjeForm forma=new DodajOdeljenjeForm();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void BtnIzmeniPacijenta_Click(object sender, EventArgs e)
        {
            if (listaOdeljenja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite odeljenje cije podatke zelite da izmenite!");
                return;
            }

            int idOdeljenja = Int32.Parse(listaOdeljenja.SelectedItems[0].SubItems[0].Text);

            ISession s = DataLayer.GetSession();
            Odeljenje o = s.Load<Odeljenje>(idOdeljenja);

            UpdateOdeljenjeForm formaUpdate = new UpdateOdeljenjeForm(o);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnPacijenti_Click(object sender, EventArgs e)
        {
            if (listaOdeljenja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite odeljenje cije pacijente zelite da pogledate!");
                return;
            }

            int idOdeljenja = Int32.Parse(listaOdeljenja.SelectedItems[0].SubItems[0].Text);

            ISession s = DataLayer.GetSession();
            Odeljenje o = s.Load<Odeljenje>(idOdeljenja);
            PacijentiNaOdeljenjuForm forma = new PacijentiNaOdeljenjuForm(o);
            forma.ShowDialog();
        }
    }
}
