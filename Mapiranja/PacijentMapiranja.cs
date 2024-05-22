using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;


namespace Test3.Mapiranja
{
    public class PacijentMapiranja:ClassMap<Pacijent>
    {
        PacijentMapiranja() 
        {
            Table("PACIJENT");


            Id(p => p.Mbr, "MBR").GeneratedBy.Assigned();


            Map(p => p.Ime, "IME");
            Map(p => p.Prezime, "PREZIME");
            Map(p => p.TipPacijenta, "TIP_PACIJENTA");

            References(x => x.LekarOP).Column("MBR_LEKARA_OP").LazyLoad();
        }
    }
}
