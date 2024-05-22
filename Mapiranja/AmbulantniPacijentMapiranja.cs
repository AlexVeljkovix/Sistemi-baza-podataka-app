using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    public class AmbulantniPacijentMapiranja:SubclassMap<AmbulantniPacijent>
    {
        public AmbulantniPacijentMapiranja() 
        {
            Table("AMBULANTNI_PACIJENT");

            KeyColumn("MBR");
            
            Map(p => p.Adresa, "ADRESA");
            HasMany(x => x.ListaIntervencija).KeyColumn("MBR_AMBULANTNOG_PACIJENTA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
