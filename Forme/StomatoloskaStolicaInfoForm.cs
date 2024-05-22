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
    public partial class StomatoloskaStolicaInfoForm : Form
    {
        public StomatoloskaStolica stolica;
        public StomatoloskaStolicaInfoForm()
        {
            InitializeComponent();
        }
        public StomatoloskaStolicaInfoForm(StomatoloskaStolica s)
        {
            this.stolica= s;
            InitializeComponent();
        }
        private void StomatoloskaStolicaInfoForm_Load(object sender, EventArgs e)
        {
            prikaziPodatke();
        }

        public void prikaziPodatke()
        {
            txbId.Text = stolica.Id.ToString();
            txbDatumP.Text=stolica.DatumProizvodnje.ToString();
            txbProizvodjac.Text = stolica.Proizvodjac;
            txbTehnickoOdrzavanje.Text=stolica.OdrzavanjeStolice.Mbr.ToString();
        }
    }
}
