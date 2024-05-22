using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class Pacijent
    {
        public virtual int Mbr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string TipPacijenta { get; set; }


        public virtual LekariOpstePrakse LekarOP { get; set; }

        public Pacijent() { }

    }
}
