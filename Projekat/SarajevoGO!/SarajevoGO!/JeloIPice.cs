using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace App1
{
    class JeloIPice : Kategorija
    {

        String tip, nazivObjekta, adresa, web, info;
        Int32 telefon;
        Image slika;
        Image meni;

        public Image Meni
        {
            get
            {
                return meni;
            }

            set
            {
                meni = value;
            }
        }

        public JeloIPice(String t, String naziv, String adr, String www, String inf, Int32 tel, Image sl, Image m) : base(t, naziv, adr, www, inf, tel, sl)
        {
            meni = m;
        }
    }
}
