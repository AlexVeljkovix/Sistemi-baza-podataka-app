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
    public partial class HigijenicariForm : Form
    {
        public HigijenicariForm()
        {
            InitializeComponent();
        }

        private void HigijenicariForm_Load(object sender, EventArgs e)
        {
            listaHigijenicari.Columns.Add("MBR", 70);
            listaHigijenicari.Columns.Add("Ime", 120);
            listaHigijenicari.Columns.Add("Prezime", 120);
            listaHigijenicari.View = View.Details;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listaHigijenicari.Items.Clear();
            List<Higijenicari> hig = new List<Higijenicari>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Higijenicari> hi = from o in s.Query<Higijenicari>()
                                                     select o;
                hig = hi.ToList();

                foreach (Higijenicari h in hig)
                {
                    ListViewItem item = new ListViewItem(h.Mbr.ToString());
                    item.SubItems.Add(h.Ime);
                    item.SubItems.Add(h.Prezime);
                    
                    listaHigijenicari.Items.Add(item);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajHigijenicaraForm form = new DodajHigijenicaraForm();
            form.ShowDialog();
            this.popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaHigijenicari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite higijenicara cije podatke zelite da izmenite!");
                return;
            }

            int idHig = Int32.Parse(listaHigijenicari.SelectedItems[0].SubItems[0].Text);

            ISession s = DataLayer.GetSession();
            Higijenicari h = s.Load<Higijenicari>(idHig);

            HigijenicariUpdateForm formaUpdate = new HigijenicariUpdateForm(h);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaHigijenicari.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite MBR higijenicara da obrisete!");
                    return;
                }

                int idHig = Int32.Parse(listaHigijenicari.SelectedItems[0].SubItems[0].Text);
                string poruka = "Da li zelite da obrisete izabranog higijenicara?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    Higijenicari h = s.Load<Higijenicari>(idHig);

                    s.Delete(h);
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Brisanje higijenicara je uspesno obavljeno!");
                    this.popuniPodacima();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
