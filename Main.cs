using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test3.Forme;

namespace Test3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDeveloperMode_Click(object sender, EventArgs e)
        {
            DemoModeForm forma = new DemoModeForm();
            forma.ShowDialog();
        }

        private void btnPacijenti_Click(object sender, EventArgs e)
        {
            PacijentiForm forma = new PacijentiForm();
            forma.ShowDialog();
        }

        private void btnMedicinskoOsoblje_Click(object sender, EventArgs e)
        {
            MedicinskoOsobljeForm forma = new MedicinskoOsobljeForm();
            forma.ShowDialog();
        }

        private void btnNemedicinskoOsoblje_Click(object sender, EventArgs e)
        {
            NeMedOsobljeForm forma = new NeMedOsobljeForm();
            forma.ShowDialog();
        }

        private void btnStolice_Click(object sender, EventArgs e)
        {
            StoliceForm forma= new StoliceForm();
            forma.ShowDialog();
        }

        private void btnOdeljenja_Click(object sender, EventArgs e)
        {
            OdeljenjaForm forma =new OdeljenjaForm();
            forma.ShowDialog();
        }
    }
}
