using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class Stomatolozi:MedicinskoOsoblje
    {
        public virtual string Smena { get; set; }
        public virtual StomatoloskaStolica IdStolice { get; set; }
        public virtual IList<Intervencija> ListaIntervencija { get; set; }

        public Stomatolozi() 
        {
            this.TipMedicinskogOsoblja = "Stomatolozi";
            ListaIntervencija = new List<Intervencija>();
        }
    }
}
