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
    public partial class TehnickoOdrzavanjeUpdateForm : Form
    {
        TehnickoOdrzavanje tehnickoOdrzavanje;
        public TehnickoOdrzavanjeUpdateForm()
        {
            InitializeComponent();
        }
        public TehnickoOdrzavanjeUpdateForm(TehnickoOdrzavanje t)
        {
            this.tehnickoOdrzavanje = t;
            InitializeComponent();
        }

        private void TehnickoOdrzavanjeUpdateForm_Load(object sender, EventArgs e)
        {
            listStolica.Columns.Add("Id stolice", 70);
            listStolica.Columns.Add("Proizvodjac", 100);
            listStolica.View = View.Details;
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listStolica.Items.Clear();
            List<StomatoloskaStolica> stolice = new List<StomatoloskaStolica>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<StomatoloskaStolica> ss = from o in s.Query<StomatoloskaStolica>()
                                                      select o;
                stolice = ss.ToList();

                foreach (StomatoloskaStolica stolica in stolice)
                {
                    if (stolica.OdrzavanjeStolice != null)
                    {
                        if (stolica.OdrzavanjeStolice.Mbr == tehnickoOdrzavanje.Mbr)
                        {
                            ListViewItem item = new ListViewItem(stolica.Id.ToString());
                            listStolica.Items.Add(item);
                            item.SubItems.Add(stolica.Proizvodjac);
                        }
                    }
                    
                }

                IQuery q = s.CreateQuery("from StomatoloskaStolica");
                IList<StomatoloskaStolica> listaStolica = q.List<StomatoloskaStolica>();
                List<string> stringovi = new List<string>();

                foreach (StomatoloskaStolica st in listaStolica)
                {
                    if(st.OdrzavanjeStolice==null)
                        stringovi.Add(st.Id.ToString());
                }      
                cbxStolica.DataSource = stringovi;
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            txbMbr.Text = tehnickoOdrzavanje.Mbr.ToString();
            txbIme.Text = tehnickoOdrzavanje.Ime;
            txbPrezime.Text = tehnickoOdrzavanje.Prezime;
            txbStruka.Text = tehnickoOdrzavanje.Struka;
        }

        private void chkNovaStolica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNovaStolica.Checked)
            {
                cbxStolica.Enabled = true;
            }
            else { cbxStolica.Enabled = false;}
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmenu radnika tehnickog odrzavanja?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    TehnickoOdrzavanje to = s.Load<TehnickoOdrzavanje>(this.tehnickoOdrzavanje.Mbr);                 
                    this.tehnickoOdrzavanje.Mbr = int.Parse(txbMbr.Text);
                    this.tehnickoOdrzavanje.Ime = txbIme.Text;
                    this.tehnickoOdrzavanje.Prezime = txbPrezime.Text;
                    this.tehnickoOdrzavanje.Struka=txbStruka.Text;
                    if (chkNovaStolica.Checked)
                    {
                        StomatoloskaStolica stom = s.Load<StomatoloskaStolica>(int.Parse(cbxStolica.Text));
                        stom.OdrzavanjeStolice = this.tehnickoOdrzavanje;

                    }

                    to.Mbr = tehnickoOdrzavanje.Mbr;
                    to.Ime = tehnickoOdrzavanje.Ime;
                    to.Prezime = tehnickoOdrzavanje.Prezime;
                    
                    s.Update(to);
                    s.Flush();
                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }




                MessageBox.Show("Azuriranje radnika tehnickog odrzavanja je uspesno izvrseno!");
                this.Close();
            }
        }

        private void btnObrisiSt_Click(object sender, EventArgs e)
        {
            try
            {
                if (listStolica.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite stolicu koju zelite da obrisete!");
                    return;
                }

                int idStolice = Int32.Parse(listStolica.SelectedItems[0].SubItems[0].Text);
                string poruka = "Da li zelite da uklonite radnika tehnickog odrzavanja sa stolice?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    StomatoloskaStolica stolica = s.Load<StomatoloskaStolica>(idStolice);
                    stolica.OdrzavanjeStolice = null;
                    s.Save(stolica);
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Uklanjanje tehnickog odrzavanja sa stolice uspesno izvrseno!");
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
