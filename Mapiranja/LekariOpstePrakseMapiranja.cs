using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    public class LekariOpstePrakseMapiranja:SubclassMap<LekariOpstePrakse>
    {
        LekariOpstePrakseMapiranja() 
        {
            Table("LEKARI_OPSTE_PRAKSE");

            KeyColumn("MBR");

            Map(p => p.BrOrdinacije, "BR_ORDINACIJE");

            HasMany(x => x.Pacijenti).KeyColumn("MBR_LEKARA_OP").LazyLoad().Cascade.All().Inverse();
        }
    }
}
