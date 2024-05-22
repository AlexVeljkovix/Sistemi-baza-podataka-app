using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    public class IntervencijaMapiranja:ClassMap<Intervencija>
    {
        public IntervencijaMapiranja()
        {

            Table("INTERVENCIJA");
            Id(x => x.SifraIntervencije, "SIFRA_INTERVENCIJE").GeneratedBy.Assigned();
            
            Map(x => x.Datum, "DATUM");
            Map(x => x.Vrsta, "VRSTA");

            References(x => x.Stomatolog).Column("MBR_STOMATOLOGA").LazyLoad();
            References(x => x.Pacijent).Column("MBR_AMBULANTNOG_PACIJENTA").LazyLoad();
        }
    }
}
