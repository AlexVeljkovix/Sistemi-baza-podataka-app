using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class AmbulantniPacijent:Pacijent
    {
        public virtual string Adresa { get; set; }

        public virtual IList<Intervencija> ListaIntervencija { get; set; }

        
        public AmbulantniPacijent() 
        {
            this.TipPacijenta = "Ambulantni";
            ListaIntervencija = new List<Intervencija>();
        }
    }
}
