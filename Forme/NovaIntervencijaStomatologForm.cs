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
using Test3.Forme;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Test3.Forme
{
    public partial class NovaIntervencijaStomatologForm : Form
    {
        public Stomatolozi stomatolog;
        public NovaIntervencijaStomatologForm()
        {
            InitializeComponent();
        }

        public NovaIntervencijaStomatologForm(Stomatolozi s)
        {
            this.stomatolog = s;
            InitializeComponent();
        }
        private void NovaIntervencijaStomatologForm_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from AmbulantniPacijent");


            IList<AmbulantniPacijent> pacijenti = q.List<AmbulantniPacijent>();
            List<string> lista = new List<string>();

            foreach (AmbulantniPacijent p in pacijenti)
                if (0 != null)
                    lista.Add(p.Mbr.ToString());

            cbxPacijent.DataSource = lista;
        }

        private void btnKreirajIntervenciju_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu intervenciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);


            if (result == DialogResult.OK)
            {
                ISession s = DataLayer.GetSession();
                AmbulantniPacijent pacijent = s.Load<AmbulantniPacijent>(int.Parse(cbxPacijent.Text));
                Intervencija i = new Intervencija()
                {
                    SifraIntervencije = int.Parse(txbSifra.Text),
                    Vrsta = txbVrsta.Text,
                    Datum = dtpDatum.Value,
                    Pacijent = pacijent,
                    Stomatolog = this.stomatolog
                    
                };

                s.Save(i);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno ste dodali novu intervenciju!");

                this.Close();
            }
        }

    }
} 
             
                   


                
               
               
    
        
    

