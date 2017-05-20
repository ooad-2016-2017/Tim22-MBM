using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SarajevoGO_.Model
{
    public class Aktivnost : Kategorija
    {
        public Aktivnost(String tip, String naziv, String adr, String www, String inf, Int32 tel, Image sl) : base(tip, naziv, adr, www, inf, tel, sl) { }
    }
}