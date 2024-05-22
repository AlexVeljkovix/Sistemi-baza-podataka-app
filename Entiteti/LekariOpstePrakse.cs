using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class LekariOpstePrakse:MedicinskoOsoblje
    {
        public virtual int BrOrdinacije { get; set; }
        public virtual IList<Pacijent> Pacijenti { get; set; }


        public LekariOpstePrakse() 
        {
            this.TipMedicinskogOsoblja = "Lekari_OP";
            Pacijenti= new List<Pacijent>();
        }
    }
}
