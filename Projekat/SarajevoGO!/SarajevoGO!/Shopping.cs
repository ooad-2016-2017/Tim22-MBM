using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace App1
{
    class Shopping : Kategorija
    {
        String tip, nazivObjekta, adresa, web, info;
        Int32 telefon;
        Image slika;
        public Shopping(String t, String naziv, String adr, String www, String inf, Int32 tel, Image sl) : base(t, naziv, adr, www, inf, tel, sl) { }
    }

}