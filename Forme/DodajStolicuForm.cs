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
    public partial class DodajStolicuForm : Form
    {
        public DodajStolicuForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu stolicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);


            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    StomatoloskaStolica stolica = new StomatoloskaStolica()
                    {
                        Id = int.Parse(txbId.Text),
                        DatumProizvodnje = dtpDatum.Value,
                        Proizvodjac = txbProizvodjac.Text,
                        OdrzavanjeStolice = null
                    };

                    s.Save(stolica);
                    s.Flush();
                    s.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Uspesno ste dodali novu stolicu!");
            this.Close();
        }
    }
}
