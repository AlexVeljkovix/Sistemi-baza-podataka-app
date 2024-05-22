using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Entiteti
{
    public class StomatoloskaStolica
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumProizvodnje { get; set; }
        public virtual string Proizvodjac { get; set; }    
        public virtual TehnickoOdrzavanje OdrzavanjeStolice { get; set; }

        public virtual IList<Stomatolozi> Stomatolozi { get; set; } 

        public StomatoloskaStolica() 
        {
            Stomatolozi = new List<Stomatolozi>();
        }
    }
}
