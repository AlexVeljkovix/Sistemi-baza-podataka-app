using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class Odeljenje
    {
        public virtual int SifraOdeljenja { get; set; }
        public virtual DateTime DatumIzgradnje { get; set; }
        public virtual string Tip { get; set; }

        public virtual LekariSpecijalisti LekarSpecijalista { get; set; }

        public virtual IList<StacionarniPacijent> StacionarniPacijenti { get; set; }
        public virtual IList<OdrzavanjeOdeljenja> ListaHigijenicara {  get; set; }
        public Odeljenje() 
        {
            StacionarniPacijenti = new List<StacionarniPacijent>();
            ListaHigijenicara = new List<OdrzavanjeOdeljenja>();
        }
    }
}
