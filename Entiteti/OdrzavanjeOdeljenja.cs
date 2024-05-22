using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3
{
    public class OdrzavanjeOdeljenja
    {
        public virtual int SifraOdrzavanja {  get; set; }
        
        
        public virtual Odeljenje SifraOdeljenja { get; set; }
        public virtual Higijenicari MbrHigijenicara { get; set; }

        public OdrzavanjeOdeljenja()
        {
            
        }
    }
}
