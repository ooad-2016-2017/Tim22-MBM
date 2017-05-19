using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace App1
{
    class Kultura : Kategorija
    {
        String tip, nazivObjekta, adresa, web, info;
        Int32 telefon;
        Image slika;
        Double cijenaOdrasli, cijenaDjeca;
        Int32 brojMjesta;

        public double CijenaOdrasli
        {
            get
            {
                return cijenaOdrasli;
            }

            set
            {
                cijenaOdrasli = value;
            }
        }

        public double CijenaDjeca
        {
            get
            {
                return cijenaDjeca;
            }

            set
            {
                cijenaDjeca = value;
            }
        }

        public int BrojMjesta
        {
            get
            {
                return brojMjesta;
            }

            set
            {
                brojMjesta = value;
            }
        }

        public Kultura(String t, String naziv, String adr, String www, String inf, Int32 tel, Image sl, Double cijenaO, Double cijenaD) : base(t, naziv, adr, www, inf, tel, sl)
        {
            CijenaOdrasli = cijenaO;
            CijenaDjeca = cijenaD;
            BrojMjesta = 50;
        }
    }
}
