using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    public class LekariSpecijalistiMapiranja:SubclassMap<LekariSpecijalisti>
    {
        public LekariSpecijalistiMapiranja()
        {
            Table("LEKARI_SPECIJALISTI");

            KeyColumn("MBR");

            Map(p => p.Specijalnost, "SPECIJALNOST");

            HasMany(x => x.Odeljenja).KeyColumn("MBR_LEKARA_SP").LazyLoad().Cascade.All().Inverse();

        }
    }
}
