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
    public partial class DodajOdeljenjeForm : Form
    {
        public DodajOdeljenjeForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
                string poruka = "Da li zelite da dodate novo odeljenje?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);


                if (result == DialogResult.OK)
                {
                    try
                    {
                        ISession s = DataLayer.GetSession();
                        
                        LekariSpecijalisti lekar=s.Load<LekariSpecijalisti>(int.Parse(cbxLekarSpecijalista.Text));
                        Odeljenje odeljenje = new Odeljenje()
                        {
                            SifraOdeljenja=int.Parse(txbSifraOdeljenja.Text),
                            DatumIzgradnje=dtpDatum.Value,
                            Tip=txbTipOdeljenja.Text,
                            LekarSpecijalista=lekar
                        };
                        
                        s.Save(odeljenje);
                        s.Flush();
                        s.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                MessageBox.Show("Uspesno ste dodali novo odeljenje!");

                this.Close();
            
        }

        private void DodajOdeljenjeForm_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from LekariSpecijalisti");

            IList<LekariSpecijalisti> lekari = q.List<LekariSpecijalisti>();
            List<string> lista = new List<string>();

            foreach (LekariSpecijalisti ls in lekari)
                lista.Add(ls.Mbr.ToString());

            cbxLekarSpecijalista.DataSource = lista;
        }
    }
}
