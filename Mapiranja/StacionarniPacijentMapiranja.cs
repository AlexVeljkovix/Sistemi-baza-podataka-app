using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Entiteti;

namespace Test3.Mapiranja
{
    public class StacionarniPacijentMapiranja:SubclassMap<StacionarniPacijent>
    {
        public StacionarniPacijentMapiranja()
        {
            Table("STACIONARNI_PACIJENT");

            KeyColumn("MBR");

            Map(p => p.DatumPrijema, "DATUM_PRIJEMA");
            Map(p => p.DatumOtpusta, "DATUM_OTPUSTA");

            References(x => x.SifraOdeljenja).Column("SIFRA_ODELJENJA").LazyLoad();

        }
    }
}
