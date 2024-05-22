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
    public partial class DodajMedOsobljeForm : Form
    {
        public DodajMedOsobljeForm()
        {
            InitializeComponent();
        }

        private void DodajMedOsobljeForm_Load(object sender, EventArgs e)
        {

            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from StomatoloskaStolica");
           
            IList<StomatoloskaStolica> stolice = q.List<StomatoloskaStolica>();
            

            List<string> lista = new List<string>();
            

            foreach (StomatoloskaStolica st in stolice)
                lista.Add(st.Id.ToString());


            cbxIdStolice.DataSource = lista;

            List<string> list = new List<string>();
            list.Add("Prva");
            list.Add("Druga");
            cbxSmena.DataSource = list;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog medicinskog radnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);


            if (result == DialogResult.OK)
            {
                ISession s = DataLayer.GetSession();

                if (rbtnLO.Checked)
                {
                    LekariOpstePrakse lo = new LekariOpstePrakse()
                    {
                        Mbr = int.Parse(tbxMbr.Text),
                        Ime = tbxIme.Text,
                        Prezime = tbxIme.Text,
                        GodineRadnogStaza = int.Parse(tbxGodine.Text),
                        BrOrdinacije = int.Parse(tbxBrordinacije.Text)
                    };

                    s.Save(lo);
                    s.Flush();
                    s.Close();
                }
                else if (rbtnLS.Checked)
                {
                    LekariSpecijalisti ls = new LekariSpecijalisti()
                    {
                        Mbr = int.Parse(tbxMbr.Text),
                        Ime = tbxIme.Text,
                        Prezime = tbxIme.Text,
                        GodineRadnogStaza = int.Parse(tbxGodine.Text),
                        Specijalnost = tbxSpecijalnost.Text
                    };
                    s.Save(ls);
                    s.Flush();
                    s.Close();
                }
                else if (rbtnStomatolog.Checked)
                {
                    int idStolice;
                    idStolice = int.Parse(cbxIdStolice.Text);
                    StomatoloskaStolica stolica = s.Load<StomatoloskaStolica>(idStolice);

                    Stomatolozi st = new Stomatolozi()
                    {
                        Mbr = int.Parse(tbxMbr.Text),
                        Ime = tbxIme.Text,
                        Prezime = tbxIme.Text,
                        GodineRadnogStaza = int.Parse(tbxGodine.Text),
                        Smena=cbxSmena.Text,
                        IdStolice=stolica
                    };
                    s.Save(st);
                    s.Flush();
                    s.Close();
                }
                
                MessageBox.Show("Uspesno ste dodali novog medicinskog radnika!");

                this.Close();
            }
        }

        private void rbtnLO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLO.Checked)
            {
                tbxBrordinacije.Enabled = true;
                tbxSpecijalnost.Enabled = false;
                cbxSmena.Enabled = false;
                cbxIdStolice.Enabled = false;
            }
        }

        private void rbtnLS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLS.Checked)
            {
                tbxSpecijalnost.Enabled= true;
                tbxBrordinacije.Enabled = false;
                cbxSmena.Enabled = false;
                cbxIdStolice.Enabled = false;
            }
        }

        private void rbtnStomatolog_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnStomatolog.Checked)
            {
                cbxSmena.Enabled = true;
                cbxIdStolice.Enabled = true;
                tbxSpecijalnost.Enabled = false;
                tbxBrordinacije.Enabled = false;
                
            }
        }
    }
}
