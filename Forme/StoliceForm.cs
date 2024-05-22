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
    public partial class StoliceForm : Form
    {
        public StoliceForm()
        {
            InitializeComponent();
        }

        private void StoliceForm_Load(object sender, EventArgs e)
        {
            listStolice.Columns.Add("Id stolice", 80);
            listStolice.Columns.Add("Datum proizvodnje", 120);
            listStolice.Columns.Add("Proizvodjac", 130);
            listStolice.Columns.Add("MBR radnika TO", 140);
            listStolice.View = View.Details;
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            listStolice.Items.Clear();


            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from StomatoloskaStolica");
                
                IList<StomatoloskaStolica> stolice = q.List<StomatoloskaStolica>();

                foreach (StomatoloskaStolica st in stolice)
                {
                    ListViewItem item = new ListViewItem(st.Id.ToString());
                    item.SubItems.Add(st.DatumProizvodnje.ToString());
                    item.SubItems.Add(st.Proizvodjac);
                        if (st.OdrzavanjeStolice != null)
                        {
                            item.SubItems.Add(st.OdrzavanjeStolice.Mbr.ToString());
                        }
                        else 
                        {
                            item.SubItems.Add("Nema odrzavanja stolice");
                        }
                           

                    listStolice.Items.Add(item);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
