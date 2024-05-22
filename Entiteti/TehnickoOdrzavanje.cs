using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class TehnickoOdrzavanje
    {
        public virtual int Mbr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Struka { get; set; }


        public virtual IList<StomatoloskaStolica> listaStolica {  get; set; }

        public TehnickoOdrzavanje() 
        {
            listaStolica=new List<StomatoloskaStolica>();
        }
    }
}
