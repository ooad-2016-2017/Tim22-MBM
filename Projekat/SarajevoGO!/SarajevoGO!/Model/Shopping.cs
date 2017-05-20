using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SarajevoGO_.Model
{
    public class Shopping : Kategorija
    {
        public Shopping(String tip, String naziv, String adr, String www, String detalji, Int32 tel, Image sl) : base(tip, naziv, adr, www, detalji, tel, sl) { }
    }

}