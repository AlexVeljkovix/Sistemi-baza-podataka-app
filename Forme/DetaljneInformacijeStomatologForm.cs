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
    public partial class DetaljneInformacijeStomatologForm : Form
    {
        public Stomatolozi stomatolog;
        public DetaljneInformacijeStomatologForm()
        {
            InitializeComponent();
        }

        public DetaljneInformacijeStomatologForm(Stomatolozi s)
        {
            this.stomatolog = s;
            InitializeComponent();
        }

        private void DetaljneInformacijeStomatologForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"DETALJNE INFORMACIJE O STOMATOLOGU {stomatolog.Ime.ToUpper()} {stomatolog.Prezime.ToUpper()}";
        }

        public void popuniPodacima()
        {
            tbxMbr.Text = stomatolog.Mbr.ToString();
            tbxIme.Text = stomatolog.Ime;
            tbxPrezime.Text = stomatolog.Prezime;
            tbxGodine.Text = stomatolog.GodineRadnogStaza.ToString();
            txbStomStolica.Text = stomatolog.IdStolice.Id.ToString();
            txbSmena.Text = stomatolog.Smena;
        }

        private void btnStolica_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            StomatoloskaStolica st = s.Load<StomatoloskaStolica>(stomatolog.IdStolice.Id);
            StomatoloskaStolicaInfoForm forma=new StomatoloskaStolicaInfoForm(st);
            forma.ShowDialog();
        }

        private void btnIntervencije_Click(object sender, EventArgs e)
        {
            IntervencijeForm forma = new IntervencijeForm(stomatolog);
            forma.ShowDialog();
        }
    }
}
