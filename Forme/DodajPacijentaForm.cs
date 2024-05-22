using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Test3.Entiteti;

namespace Test3.Forme
{
    public partial class DodajPacijentaForm : Form
    {
        public DodajPacijentaForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog pacijenta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            
            if (result == DialogResult.OK)
            {
                ISession s = DataLayer.GetSession();
                int Mbr;
                Mbr = int.Parse(cbxLekarOpstePrakse.Text);
                LekariOpstePrakse l = s.Load<LekariOpstePrakse>(Mbr);

                if (rbtnAP.Checked)
                {
                   
                    AmbulantniPacijent a = new AmbulantniPacijent()
                    {
                        Mbr = int.Parse(tbxMbr.Text),
                        Ime = tbxIme.Text,
                        Prezime = tbxIme.Text,
                        Adresa = tbxAdresa.Text,
                        LekarOP = l
                    };
                    
                    s.Save(a);
                    s.Flush();
                    s.Close();
                }
                else if (rbtnSP.Checked)
                {
                    
                    int idOdeljenja;
                    idOdeljenja = int.Parse(cbxSifraOdeljenja.Text);
                    Odeljenje o = s.Load<Odeljenje>(idOdeljenja);

                    StacionarniPacijent st = new StacionarniPacijent()
                    {
                        Mbr = int.Parse(tbxMbr.Text),
                        Ime = tbxIme.Text,
                        Prezime = tbxPrezime.Text,
                        LekarOP = l,
                        SifraOdeljenja = o,
                        DatumPrijema = dateTimePicker1.Value,
                        DatumOtpusta = dateTimePicker2.Value
                    };
                    s.Save(st);
                    s.Flush();
                    s.Close();
                }
                MessageBox.Show("Uspesno ste dodali novog pacijenta!");
                
                this.Close();
            }
            
        }

        private void rbtnAP_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnAP.Checked)
            {
                tbxAdresa.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                cbxSifraOdeljenja.Enabled = false;
            }
            else if (rbtnSP.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                cbxSifraOdeljenja.Enabled = true;
                tbxAdresa.Enabled = false;
            }
        }

        private void rbtnSP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAP.Checked)
            {
                tbxAdresa.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                cbxSifraOdeljenja.Enabled = false;
            }
            else if (rbtnSP.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                cbxSifraOdeljenja.Enabled = true;
                tbxAdresa.Enabled = false;
            }
        }

        private void DodajPacijentaForm_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from Odeljenje");
            IQuery q1 = s.CreateQuery("from LekariOpstePrakse");


            IList<Odeljenje> odeljenja = q.List<Odeljenje>();
            IList<LekariOpstePrakse> lo=q1.List<LekariOpstePrakse>();

            List<string> lista = new List<string>();
            List<string> lista1 = new List<string>();

            foreach (Odeljenje od in odeljenja)
                lista.Add(od.SifraOdeljenja.ToString());

            foreach (LekariOpstePrakse l in lo)
                lista1.Add(l.Mbr.ToString());

            cbxSifraOdeljenja.DataSource = lista;
            cbxLekarOpstePrakse.DataSource = lista1;
        }
    }
}
