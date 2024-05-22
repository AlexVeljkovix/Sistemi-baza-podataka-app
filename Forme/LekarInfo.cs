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
    public partial class LekarInfo : Form
    {
        public LekariOpstePrakse lekar;
        public LekarInfo()
        {
            InitializeComponent();
        }

        public LekarInfo(LekariOpstePrakse lekar)
        {
            this.lekar = lekar;
            InitializeComponent();
        }

        private void LekarInfo_Load(object sender, EventArgs e)
        {

            tbxMbr.Text = this.lekar.Mbr.ToString();
            tbxIme.Text = this.lekar.Ime;
            tbxPrezime.Text = this.lekar.Prezime;
            tbxGodRS.Text = this.lekar.GodineRadnogStaza.ToString();
            tbxTipMO.Text = this.lekar.TipMedicinskogOsoblja;
            tbxBrojOrdinacije.Text = lekar.BrOrdinacije.ToString();
        }
    }
}
