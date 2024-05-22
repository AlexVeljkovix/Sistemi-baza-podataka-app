using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    public class StomatoloskaStolicaMapiranja:ClassMap<StomatoloskaStolica>
    {
        public StomatoloskaStolicaMapiranja()
        {
            Table("STOMATOLOSKA_STOLICA");

            Id(p => p.Id, "ID").GeneratedBy.Assigned();

            Map(p => p.DatumProizvodnje, "DATUM_PROIZVODNJE");
            Map(p => p.Proizvodjac, "PROIZVODJAC");

            References(x => x.OdrzavanjeStolice).Column("MBR_TO").LazyLoad();
            HasMany(x => x.Stomatolozi).KeyColumn("ID_STOLICE").LazyLoad().Cascade.All().Inverse();

        }
    }
}
