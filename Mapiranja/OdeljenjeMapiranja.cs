using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    public class OdeljenjeMapiranja:ClassMap<Odeljenje>
    {
        public OdeljenjeMapiranja() 
        {
            Table("ODELJENJE");

            Id(p => p.SifraOdeljenja, "SIFRA_ODELJENJA").GeneratedBy.Assigned();

            Map(p => p.DatumIzgradnje, "DATUM_IZGRADNJE");
            Map(p => p.Tip, "TIP");

            References(x => x.LekarSpecijalista).Column("MBR_LEKARA_SP").LazyLoad();
            HasMany(x => x.StacionarniPacijenti).KeyColumn("SIFRA_ODELJENJA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ListaHigijenicara).KeyColumn("SIFRA_ODELJENJA").LazyLoad().Cascade.All().Inverse();


        }


    }
}
