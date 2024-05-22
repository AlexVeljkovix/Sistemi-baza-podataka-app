﻿using NHibernate;
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
    public partial class PacijentiNaOdeljenjuForm : Form
    {
        Odeljenje odeljenje;
        public PacijentiNaOdeljenjuForm()
        {
            InitializeComponent();
        }
        public PacijentiNaOdeljenjuForm(Odeljenje o)
        {
            this.odeljenje = o;
            InitializeComponent();
        }

        private void PacijentiNaOdeljenjuForm_Load(object sender, EventArgs e)
        {
            listaStacPacijenata.Columns.Add("MBR", 70);
            listaStacPacijenata.Columns.Add("Ime", 120);
            listaStacPacijenata.Columns.Add("Prezime", 120);
            listaStacPacijenata.Columns.Add("Datum prijema", 130);
            listaStacPacijenata.Columns.Add("Datum otpusta", 130);
            listaStacPacijenata.View = View.Details;


            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listaStacPacijenata.Items.Clear();
            List<StacionarniPacijent> pacijenti = new List<StacionarniPacijent>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<StacionarniPacijent> sviPacijenti = from o in s.Query<StacionarniPacijent>()
                                                                select o;
                pacijenti = sviPacijenti.ToList();



                foreach (StacionarniPacijent p in pacijenti)
                {
                    if(p.SifraOdeljenja.SifraOdeljenja==odeljenje.SifraOdeljenja)
                    {
                        ListViewItem item = new ListViewItem(p.Mbr.ToString());
                        item.SubItems.Add(p.Ime);
                        item.SubItems.Add(p.Prezime);
                        item.SubItems.Add(p.DatumPrijema.ToString());
                        item.SubItems.Add(p.DatumOtpusta.ToString());

                        listaStacPacijenata.Items.Add(item);
                    }
                    
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}