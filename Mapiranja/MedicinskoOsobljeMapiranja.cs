using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    public class MedicinskoOsobljeMapiranja:ClassMap<MedicinskoOsoblje>
    {
        public MedicinskoOsobljeMapiranja()
        {
            Table("MEDICINSKO_OSOBLJE");

            Id(p => p.Mbr, "MBR").GeneratedBy.Assigned();

            Map(p => p.Ime, "IME");
            Map(p => p.Prezime, "PREZIME");
            Map(p => p.TipMedicinskogOsoblja, "TIP_MED_OSOBLJA");
            Map(p => p.GodineRadnogStaza, "GODINE_RADNOG_STAZA");
        }
    }
}
