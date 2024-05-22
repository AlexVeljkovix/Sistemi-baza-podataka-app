using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class Higijenicari
    {
        public virtual int Mbr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }

        public virtual IList<OdrzavanjeOdeljenja> OdrzavanaOdeljenja{get; set; }
        public Higijenicari() 
        {
            OdrzavanaOdeljenja = new List<OdrzavanjeOdeljenja>();
        }
    }
}
