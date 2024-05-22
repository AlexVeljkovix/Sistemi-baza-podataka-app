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
using FluentNHibernate;
using NHibernate;

namespace Test3.Forme
{
    public partial class MedicinskoOsobljeForm : Form
    {
        public MedicinskoOsobljeForm()
        {
            InitializeComponent();
        }

        private void MedicinskoOsobljeForm_Load(object sender, EventArgs e)
        {
            listaMOsoblje.Columns.Add("MBR", 70);
            listaMOsoblje.Columns.Add("Ime", 120);
            listaMOsoblje.Columns.Add("Prezime", 120);
            listaMOsoblje.Columns.Add("Godine radnog staza", 120);
            listaMOsoblje.Columns.Add("Tip medicinskog osoblja", 130);
            listaMOsoblje.View = View.Details;
            popuniPodacima();
        }

        public void popuniPodacima()
        {

            listaMOsoblje.Items.Clear();
            List<MedicinskoOsoblje> mo = new List<MedicinskoOsoblje>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<MedicinskoOsoblje> mos = from o in s.Query<MedicinskoOsoblje>()
                                                     select o;
                mo = mos.ToList();

                foreach (MedicinskoOsoblje m in mo)
                {
                    ListViewItem item = new ListViewItem(m.Mbr.ToString());
                    item.SubItems.Add(m.Ime);
                    item.SubItems.Add(m.Prezime);
                    item.SubItems.Add(m.GodineRadnogStaza.ToString());
                    item.SubItems.Add(m.TipMedicinskogOsoblja);


                    listaMOsoblje.Items.Add(item);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajMo_Click(object sender, EventArgs e)
        {
            DodajMedOsobljeForm forma=new DodajMedOsobljeForm(); 
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisiMo_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaMOsoblje.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite MBR medicinskog radnika kog zelite da obrisete!");
                    return;
                }

                int idDoktora = Int32.Parse(listaMOsoblje.SelectedItems[0].SubItems[0].Text);
                string poruka = "Da li zelite da obrisete izabranog medicinskog radnika?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    MedicinskoOsoblje p = s.Load<MedicinskoOsoblje>(idDoktora);

                    s.Delete(p);
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Brisanje medicinskog radnika je uspesno obavljeno!");
                    this.popuniPodacima();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnIzmeniMo_Click(object sender, EventArgs e)
        {
            if (listaMOsoblje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite medicinskog radnika cije podatke zelite da izmenite!");
                return;
            }

            int idDoktora = int.Parse(listaMOsoblje.SelectedItems[0].SubItems[0].Text);
            string tip = listaMOsoblje.SelectedItems[0].SubItems[4].Text;
            ISession s = DataLayer.GetSession();
            if (tip == "Lekari_OP")
            {
                LekariOpstePrakse lo= s.Load<LekariOpstePrakse>(idDoktora);
                UpdateLOForm forma=new UpdateLOForm(lo);
                forma.ShowDialog();
            }
            else if (tip == "Lekari_specijalisti")
            {
                LekariSpecijalisti ls= s.Load<LekariSpecijalisti>(idDoktora);
                UpdateLSForm forma = new UpdateLSForm(ls);
                forma.ShowDialog();
            }
            else
            {
                Stomatolozi st = s.Load<Stomatolozi>(idDoktora);
                UpdateStomatologForm forma = new UpdateStomatologForm(st);
                forma.ShowDialog();
            }
            this.popuniPodacima();

        }

        private void btnDetaljniInfo_Click(object sender, EventArgs e)
        {
            if (listaMOsoblje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite medicinskog radnika cije podatke zelite da prikazete!");
                return;
            }

            int idDoktora = int.Parse(listaMOsoblje.SelectedItems[0].SubItems[0].Text);
            string tip = listaMOsoblje.SelectedItems[0].SubItems[4].Text;
            ISession s = DataLayer.GetSession();
            if (tip == "Lekari_OP")
            {
                LekariOpstePrakse lo = s.Load<LekariOpstePrakse>(idDoktora);
                DetaljneInformacijeLOForm forma = new DetaljneInformacijeLOForm(lo);
                forma.ShowDialog();
            }
            else if (tip == "Lekari_specijalisti")
            {
                LekariSpecijalisti ls = s.Load<LekariSpecijalisti>(idDoktora);
                DetaljneInformacijeLSForm forma = new DetaljneInformacijeLSForm(ls);
                forma.ShowDialog();
            }
            else
            {
                Stomatolozi st = s.Load<Stomatolozi>(idDoktora);
                DetaljneInformacijeStomatologForm forma = new DetaljneInformacijeStomatologForm(st);
                forma.ShowDialog();
            }
            this.popuniPodacima();
        }
    }
}
