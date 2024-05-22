using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class StacionarniPacijent:Pacijent
    {
        public virtual DateTime DatumPrijema { get; set; }
        public virtual DateTime DatumOtpusta { get; set; }
        public virtual Odeljenje SifraOdeljenja { get; set; }
        public StacionarniPacijent() 
        {
            this.TipPacijenta = "Stacionarni";
        }
    }
}
