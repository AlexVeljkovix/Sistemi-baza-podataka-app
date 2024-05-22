using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3.Forme
{
    public partial class NeMedOsobljeForm : Form
    {
        public NeMedOsobljeForm()
        {
            InitializeComponent();
        }

        private void NeMedOsobljeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTehnickoOdrzavanje_Click(object sender, EventArgs e)
        {
            TehnickoOdrzavanjeForm forma=new TehnickoOdrzavanjeForm();
            forma.ShowDialog();
        }

        private void btnHigijenicari_Click(object sender, EventArgs e)
        {
            HigijenicariForm forma = new HigijenicariForm();
            forma.ShowDialog();
        }
    }
}
