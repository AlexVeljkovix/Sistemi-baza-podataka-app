using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Test3.Entiteti;
using NHibernate;

namespace Test3.Forme
{
    public partial class DodajHigijenicaraForm : Form
    {
        public DodajHigijenicaraForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog higijenicara?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);


            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    Higijenicari higijenicar = new Higijenicari()
                    {
                        Mbr = int.Parse(txbMbr.Text),
                        Ime = txbIme.Text,
                        Prezime = txbPrezime.Text,
                    };
                    Odeljenje odeljenje = s.Load<Odeljenje>(int.Parse(cbxNovaOd.Text));
                    OdrzavanjeOdeljenja odrzavanje = new OdrzavanjeOdeljenja()
                    {
                        SifraOdrzavanja = int.Parse(txbSifra.Text),
                        MbrHigijenicara = higijenicar,
                        SifraOdeljenja = odeljenje
                    };
                    s.Save(higijenicar);
                    s.Save(odrzavanje);
                    s.Flush();
                    s.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
                MessageBox.Show("Uspesno ste dodali novog higijenicara!");

                this.Close();
            
        }

        private void DodajHigijenicaraForm_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from Odeljenje");

            IList<Odeljenje> odeljenja = q.List<Odeljenje>();
            List<string> lista = new List<string>();

            foreach (Odeljenje o in odeljenja)
                lista.Add(o.SifraOdeljenja.ToString());

            cbxNovaOd.DataSource = lista;
        }
    }
}



