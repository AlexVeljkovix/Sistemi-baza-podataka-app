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
    public partial class UpdateStomatologForm : Form
    {
        public Stomatolozi stomatolog;
        public UpdateStomatologForm()
        {
            InitializeComponent();
        }

        public UpdateStomatologForm(Stomatolozi s)
        {
            InitializeComponent();
            this.stomatolog = s;
        }

        private void UpdateStomatologForm_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from StomatoloskaStolica");

            IList<StomatoloskaStolica> stolice = q.List<StomatoloskaStolica>();
            List<string> lista = new List<string>();

            foreach (StomatoloskaStolica st in stolice)
                lista.Add(st.Id.ToString());

            cbxStomatoloskaStolica.DataSource = lista;

            List<string> list = new List<string>();
            list.Add("Prva");
            list.Add("Druga");
            cbxSmena.DataSource = list;
            popuniPodacima();
            this.Text = $"AZURIRANJE STOMATOLOGA {stomatolog.Ime.ToUpper()} {stomatolog.Prezime.ToUpper()}";
        }
        public void popuniPodacima()
        {
            tbxMbr.Text = stomatolog.Mbr.ToString();
            tbxIme.Text = stomatolog.Ime;
            tbxPrezime.Text = stomatolog.Prezime;
            tbxGodine.Text = stomatolog.GodineRadnogStaza.ToString();
            cbxStomatoloskaStolica.Text=stomatolog.IdStolice.Id.ToString();
            cbxSmena.Text = stomatolog.Smena;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmenu stomatologa?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    Stomatolozi st = s.Load<Stomatolozi>(this.stomatolog.Mbr);
                    StomatoloskaStolica stolica=s.Load<StomatoloskaStolica>(int.Parse(cbxStomatoloskaStolica.Text));
                    this.stomatolog.Mbr = int.Parse(tbxMbr.Text);
                    this.stomatolog.Ime = tbxIme.Text;
                    this.stomatolog.Prezime = tbxPrezime.Text;
                    this.stomatolog.GodineRadnogStaza = int.Parse(tbxGodine.Text);
                    this.stomatolog.Smena=cbxSmena.Text;
                    this.stomatolog.IdStolice = stolica;


                    st.Mbr = stomatolog.Mbr;
                    st.Ime = stomatolog.Ime;
                    st.Prezime = stomatolog.Prezime;
                    st.GodineRadnogStaza = stomatolog.GodineRadnogStaza;
                    st.Smena = stomatolog.Smena;
                    st.IdStolice = stomatolog.IdStolice;

                    s.Update(st);
                    s.Flush();
                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }




                MessageBox.Show("Azuriranje stomatologa je uspesno izvrseno!");
                this.Close();
            }
        }
    }
}
