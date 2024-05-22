using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class Intervencija
    {


        public virtual int SifraIntervencije { get; set; }
        public virtual DateTime Datum {  get; set; }
        public virtual string Vrsta { get; set; }

        public virtual AmbulantniPacijent Pacijent {  get; set; }
        public virtual Stomatolozi Stomatolog {  get; set; }
        public Intervencija() {}
    }
}
