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

namespace Test3
{
    public partial class DemoModeForm : Form
    {
        public DemoModeForm()
        {
            InitializeComponent();
        }

        private void btnUcitajPacijenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pacijent p = s.Load<Pacijent>(775485269);

                MessageBox.Show($"Prikaz pacijenta\nIme: {p.Ime}, prezime: {p.Prezime}");


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajPacijenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Pacijent p = new Pacijent();

                p.Mbr = 222222222;
                p.Ime = "Proba";
                p.Prezime = "Proba";
                p.TipPacijenta = "Ambulantni";
                
                

                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Pacijent p = s.Load<Pacijent>(775485269);

                MessageBox.Show($"Pacijent:{p.Ime}");
                MessageBox.Show($"Ima lekara koji je u ordinaciji:{p.LekarOP.BrOrdinacije}");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PrikaziLekaraOP_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                LekariOpstePrakse l = s.Load<LekariOpstePrakse>(659824367);

                MessageBox.Show($"Lekar opste prakse sa JMBG-om:{l.Mbr} radi u ordinaciji:{l.BrOrdinacije}");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnVezaOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                LekariOpstePrakse l = s.Load<LekariOpstePrakse>(123456789);

                MessageBox.Show($"Lekar sa JMBG-om:{l.Mbr} ima pacijente:");
                foreach (Pacijent p in l.Pacijenti)
                {
                    MessageBox.Show($"Ime: {p.Ime}, prezime: {p.Prezime}");
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        
        

        }

        private void btnDodavanjeOdrIStolica_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoOdrzavanje t = new TehnickoOdrzavanje();

                t.Mbr = 7878787;
                t.Ime = "Slavisa";
                t.Prezime = "Ilic";
                t.Struka = "Majstor za stolice";


                StomatoloskaStolica s1 = new StomatoloskaStolica();
                s1.Id = 10;
                s1.Proizvodjac = "STOLMax";

                StomatoloskaStolica s2 = new StomatoloskaStolica();
                s2.Id = 11;
                s2.Proizvodjac = "StolMax";




                s1.OdrzavanjeStolice = t;
                s2.OdrzavanjeStolice = t;

                t.listaStolica.Add(s1);
                t.listaStolica.Add(s2);

                s.Save(t);
                s.Flush();
                s.Close();
                

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnOneToManyTO_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                TehnickoOdrzavanje t = s.Load<TehnickoOdrzavanje>(7878787);

                MessageBox.Show($"Radnik TO sa JMBG-om:{t.Mbr} odrzava stolice:");
                foreach (StomatoloskaStolica st in t.listaStolica)
                {
                    MessageBox.Show($"Stolica: {st.Id}, proizvodjac: {st.Proizvodjac}");
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVezaManyToMany_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            Higijenicari h = s.Load<Higijenicari>(222222222);
            Odeljenje o = s.Load<Odeljenje>(4);

            OdrzavanjeOdeljenja oo = new OdrzavanjeOdeljenja();
            oo.SifraOdrzavanja = 52;
            oo.SifraOdeljenja = o;
            oo.MbrHigijenicara = h;


            s.Save(oo);

            s.Flush();
            s.Close();
        }

        private void btnIntervencija_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            Stomatolozi st = s.Load<Stomatolozi>(254224875);
            AmbulantniPacijent a= s.Load<AmbulantniPacijent>(775884585);

            Intervencija i = new Intervencija();
            i.Vrsta = "Intervencija2";
            i.Pacijent= a;
            i.Stomatolog = st;
            i.SifraIntervencije = 25;
            i.Datum=DateTime.Now;


            s.Save(i);
            s.Flush();

            MessageBox.Show($"Kreirana je nova intervencija:{i.Vrsta}, koju obavlja stomatolog:{st.Mbr}, nad pacijentom:{a.Mbr}");
            s.Close();
        }

        private void btnDodajLekaraOP_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                LekariOpstePrakse lo = new LekariOpstePrakse();


                lo.Mbr = 111111111;
                lo.Ime = "Jovan";
                lo.Prezime = "Nikolic";
                lo.GodineRadnogStaza = 15;
                lo.BrOrdinacije = 77;


                s.Save(lo);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnProstiUpit_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Odeljenje");

                IList<Odeljenje> odeljenja = q.List<Odeljenje>();

                foreach (Odeljenje o in odeljenja)
                {
                    MessageBox.Show($"Datum izgradnje odeljenja je:{o.DatumIzgradnje}");
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnSlozenijiUpit_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

  
                IQuery q = s.CreateQuery("from MedicinskoOsoblje as m where m.Prezime = :prezime");
                q.SetString("prezime", "Jovanovic");
                
                IList<MedicinskoOsoblje> medOs = q.List<MedicinskoOsoblje>();

                foreach (MedicinskoOsoblje mo in medOs)
                {
                    MessageBox.Show(mo.Mbr.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVisestrukiRezultati_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select o.Tip, o.LekarSpecijalista.Mbr from Odeljenje o "
                                        + " where o.LekarSpecijalista.Mbr > 521789654 ");

                
                IList<object[]> result = q.List<object[]>();

                foreach (object[] r in result)
                {
                    string tip = (string)r[0];
                    int mbr = (int)r[1];
                    

                    MessageBox.Show(tip + " " + mbr.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnCriteria_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<MedicinskoOsoblje>();

                c.Add(Expression.Le("GodineRadnogStaza", 4));
                c.Add(Expression.Eq("TipMedicinskogOsoblja", "Lekari_specijalisti"));

                IList<MedicinskoOsoblje> medOs = c.List<MedicinskoOsoblje>();

                foreach (MedicinskoOsoblje m in medOs)
                {
                    MessageBox.Show(m.Mbr.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StomatoloskaStolica st = s.Load<StomatoloskaStolica>(2);

                s.Close();
                
                st.Proizvodjac = "Novi proizvodjac";

               
                ISession s1 = DataLayer.GetSession();

                s1.Update(st);

                s1.Flush();
                s1.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
