using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class LekariSpecijalisti:MedicinskoOsoblje
    {
        public virtual string Specijalnost { get; set; }

        public virtual IList<Odeljenje>Odeljenja { get; set; }
        public LekariSpecijalisti() 
        {
            this.TipMedicinskogOsoblja = "Lekari_specijalisti";
            Odeljenja = new List<Odeljenje>();
        }

    }
}
