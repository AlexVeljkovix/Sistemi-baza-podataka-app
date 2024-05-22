using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    public class HigijenicariMapiranja:ClassMap<Higijenicari>
    {
        HigijenicariMapiranja()
        {
            Table("HIGIJENICARI");

            Id(p => p.Mbr, "MBR").GeneratedBy.Assigned();


            Map(p => p.Ime, "IME");
            Map(p => p.Prezime, "PREZIME");
            HasMany(x => x.OdrzavanaOdeljenja).KeyColumn("MBR_HIGIJENICARA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
