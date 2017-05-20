using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SarajevoGO_.Model
{
    public class JeloIPice : Kategorija
    {
        public Image meni { get; set; }

        public JeloIPice(String tip, String naziv, String adr, String www, String inf, Int32 tel, Image sl, Image m) : base(tip, naziv, adr, www, inf, tel, sl)
        {
            meni = m;
        }
    }
}
