using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    internal class StomatoloziMapiranja:SubclassMap<Stomatolozi>
    {
        public StomatoloziMapiranja() 
        {
            Table("STOMATOLOZI");

            KeyColumn("MBR");

            Map(p => p.Smena, "SMENA");

            References(x => x.IdStolice).Column("ID_STOLICE").LazyLoad();
            HasMany(x => x.ListaIntervencija).KeyColumn("MBR_STOMATOLOGA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
