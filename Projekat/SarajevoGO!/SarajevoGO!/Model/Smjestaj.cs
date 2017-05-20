using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SarajevoGO_.Model
{
    public class Smjestaj : Kategorija
    {
        public Int32[] brojDvokrevetnih { get; set; }
        public Int32[] brojTrokrevetnih { get; set; }
        public Int32[] brojCetverokrevetnih { get; set; }
        public Int32 cijenaPoNoci { get; set; }

        public Smjestaj(String tip, String naziv, String adr, String www, String detalji, Int32 tel, Image sl, Int32 cijena = 20) : base(tip, naziv, adr, www, detalji, tel, sl)
        {
            cijenaPoNoci = cijena;
            brojDvokrevetnih = brojTrokrevetnih = brojCetverokrevetnih = Enumerable.Repeat(5, 31).ToArray();
        }
        public void rezervisiSmjestaj(string vrstaSobe, Int32 danDolaska, Int32 danOdlaska)
        {
            if (vrstaSobe.Equals("Double room"))
                for (int i = danDolaska - 1; i < danOdlaska - 1; i++) // smanjuje broj soba izmedju dva datuma za 1
                    brojDvokrevetnih[i]--;
            else if (vrstaSobe.Equals("Triple room"))
                for (int i = danDolaska - 1; i < danOdlaska - 1; i++)
                    brojTrokrevetnih[i]--;
            else
                for (int i = danDolaska - 1; i < danOdlaska - 1; i++)
                    brojCetverokrevetnih[i]--;
        }
    }
}
