using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace App1
{
    class NocniZivot : Kategorija
    {

        String tip, nazivObjekta, adresa, web, info;
        Int32 telefon;
        Image slika;
        Int32 brojStolova;

        public int BrojStolova
        {
            get
            {
                return brojStolova;
            }

            set
            {
                brojStolova = value;
            }
        }

        public NocniZivot(String t, String naziv, String adr, String www, String inf, Int32 tel, Image sl) : base(t, naziv, adr, www, inf, tel, sl)
        {
            BrojStolova = 15;
        }
    }
}
