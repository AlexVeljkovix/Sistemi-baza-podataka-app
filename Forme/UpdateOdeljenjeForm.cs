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

namespace Test3
{
    public partial class UpdateOdeljenjeForm : Form
    {
        public Odeljenje odeljenje;
        public UpdateOdeljenjeForm()
        {
            InitializeComponent();
        }
        public UpdateOdeljenjeForm(Odeljenje odelj)
        {
            this.odeljenje = odelj;
            InitializeComponent();
        }
        private void UpdateOdeljenjeForm_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from LekariSpecijalisti");

            IList<LekariSpecijalisti> lekari = q.List<LekariSpecijalisti>();
            List<string> lista = new List<string>();

            foreach (LekariSpecijalisti l in lekari)
                lista.Add(l.Mbr.ToString());

            cbxLekarSpecijalista.DataSource = lista;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            txbSifraOdeljenja.Text = this.odeljenje.SifraOdeljenja.ToString();
            txbTipOdeljenja.Text = this.odeljenje.Tip;
            cbxLekarSpecijalista.Text = this.odeljenje.LekarSpecijalista.Mbr.ToString();
            dtpDatum.Value = this.odeljenje.DatumIzgradnje;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene odeljenja?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    Odeljenje o = s.Load<Odeljenje>(this.odeljenje.SifraOdeljenja);
                    LekariSpecijalisti sp = s.Load<LekariSpecijalisti>(int.Parse(cbxLekarSpecijalista.Text));
                    this.odeljenje.SifraOdeljenja = int.Parse(txbSifraOdeljenja.Text);
                    this.odeljenje.Tip = txbTipOdeljenja.Text;
                    this.odeljenje.LekarSpecijalista = sp;
                    this.odeljenje.DatumIzgradnje = dtpDatum.Value;

                    o.SifraOdeljenja = this.odeljenje.SifraOdeljenja;
                    o.Tip = this.odeljenje.Tip;
                    o.LekarSpecijalista = this.odeljenje.LekarSpecijalista;
                    o.DatumIzgradnje = this.odeljenje.DatumIzgradnje;

                    s.Update(o);
                    s.Flush();
                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }




                MessageBox.Show("Azuriranje odeljenja je uspesno izvrseno!");
                this.Close();
            }
        }
    }
}
