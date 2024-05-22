using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class MedicinskoOsoblje
    {
        public virtual int Mbr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int GodineRadnogStaza { get; set; }
        public virtual string TipMedicinskogOsoblja { get; set; }
        public MedicinskoOsoblje() { }
    }
}
