using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    public class TehnickoOdrzavanjeMapiranja:ClassMap<TehnickoOdrzavanje>
    {
        TehnickoOdrzavanjeMapiranja()
        {
            Table("TEHNICKO_ODRZAVANJE");

            Id(p => p.Mbr, "MBR").GeneratedBy.Assigned();

            Map(p => p.Ime, "IME");
            Map(p => p.Prezime, "PREZIME");
            Map(p => p.Struka, "STRUKA");

            HasMany(x => x.listaStolica).KeyColumn("MBR_TO").LazyLoad().Cascade.All().Inverse();
        }
    }
}
