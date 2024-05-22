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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Test3.Forme
{
    public partial class HigijenicariUpdateForm : Form
    {
        Higijenicari h;
        public HigijenicariUpdateForm()
        {
            InitializeComponent();
        }
        public HigijenicariUpdateForm(Higijenicari h)
        {
            this.h= h;
            InitializeComponent();
        }
        private void HigijenicariUpdateForm_Load(object sender, EventArgs e)
        {
            listOdeljenja.Columns.Add("Odeljenja", 70);
            listOdeljenja.View = View.Details;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listOdeljenja.Items.Clear();
            List<OdrzavanjeOdeljenja> odeljenja = new List<OdrzavanjeOdeljenja>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<OdrzavanjeOdeljenja> od = from o in s.Query<OdrzavanjeOdeljenja>()
                                               select o;
                odeljenja = od.ToList();

                foreach (OdrzavanjeOdeljenja o in odeljenja)
                {
                    if (o.MbrHigijenicara.Mbr == h.Mbr)
                    {
                        ListViewItem item = new ListViewItem(o.SifraOdeljenja.SifraOdeljenja.ToString());
                        listOdeljenja.Items.Add(item);
                    }          
                }

                IQuery q = s.CreateQuery("from Odeljenje");
                IList<Odeljenje> listaOdeljenja = q.List<Odeljenje>();
                List<string> stringovi = new List<string>();

                foreach (Odeljenje o in listaOdeljenja)
                    stringovi.Add(o.SifraOdeljenja.ToString());
                cbxNovaOd.DataSource = stringovi;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            txbMbr.Text=h.Mbr.ToString();
            txbIme.Text = h.Ime;
            txbPrezime.Text = h.Prezime;
            
        }

        private void chkNovoOd_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNovoOd.Checked)
            {
                txbSifra.Enabled = true;
                cbxNovaOd.Enabled = true;
            }
            else
            {
                txbSifra.Enabled = false;
                cbxNovaOd.Enabled = false;
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmenu higijenicara?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    Higijenicari hig = s.Load<Higijenicari>(this.h.Mbr);
                    Odeljenje o = s.Load<Odeljenje>(int.Parse(cbxNovaOd.Text));
                    this.h.Mbr = int.Parse(txbMbr.Text);
                    this.h.Ime = txbIme.Text;
                    this.h.Prezime = txbPrezime.Text;
                    if(chkNovoOd.Checked )
                    {
                        OdrzavanjeOdeljenja odrzavanje = new OdrzavanjeOdeljenja()
                        {
                            SifraOdrzavanja = int.Parse(txbSifra.Text),
                            MbrHigijenicara = h,
                            SifraOdeljenja = o
                           
                        };
                        s.Save(odrzavanje);
                        s.Flush();
                    }

                    hig.Mbr = h.Mbr;
                    hig.Ime = h.Ime;
                    hig.Prezime = h.Prezime;
                    
                    s.Update(hig);
                    s.Flush();
                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }




                MessageBox.Show("Azuriranje higijenicara je uspesno izvrseno!");
                this.Close();
            }
        }

        private void btnObrisiOd_Click(object sender, EventArgs e)
        {
            try
            {
                if (listOdeljenja.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite odeljenje koje zelite da obrisete!");
                    return;
                }

                int idOdeljenja = Int32.Parse(listOdeljenja.SelectedItems[0].SubItems[0].Text);
                string poruka = "Da li zelite da uklonite higijenicara sa odeljenja?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    IQuery q = s.CreateQuery("from OdrzavanjeOdeljenja");
                    IList<OdrzavanjeOdeljenja> listaOdrzavanja = q.List<OdrzavanjeOdeljenja>();
                    int idOdrzavanja = 0;
                    foreach(OdrzavanjeOdeljenja oo in listaOdrzavanja)
                    {
                        if(oo.SifraOdeljenja.SifraOdeljenja==idOdeljenja && oo.MbrHigijenicara.Mbr==h.Mbr)
                        {
                            idOdrzavanja = oo.SifraOdrzavanja;
                        }
                    }
                    OdrzavanjeOdeljenja o = s.Load<OdrzavanjeOdeljenja>(idOdrzavanja);

                    s.Delete(o);
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Uklanjanje higijenicara sa odeljenja uspesno izvrseno!");
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
