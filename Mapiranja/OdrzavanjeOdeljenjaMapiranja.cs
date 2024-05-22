using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.Mapiranja
{
    public class OdrzavanjeOdeljenjaMapiranja : ClassMap<OdrzavanjeOdeljenja>
    {
        OdrzavanjeOdeljenjaMapiranja()
        {

            Table("ODRZAVANJE_ODELJENJA");

            Id(x => x.SifraOdrzavanja, "SIFRA_ODRZAVANJA").GeneratedBy.Assigned();

            References(x => x.MbrHigijenicara).Column("MBR_HIGIJENICARA").LazyLoad();
            References(x => x.SifraOdeljenja).Column("SIFRA_ODELJENJA").LazyLoad();

        }
    }
}
