using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoGO_.Model
{
    public static class Gost
    {
        public static bool provjeriKarte(RezervacijaKartee rk)
        {
            return rk.provjeraDostupnosti();
        }
        public static void rezervisiKarte(RezervacijaKartee rk)
        {
            if (provjeriKarte(rk).Equals(true))
                rk.rezervisi();
            else throw new Exception("Nije slobodno");
        }
        public static bool provjeriKafic(RezervacijaKaficaa kk)
        {
            return kk.provjeraDostupnosti();
        }
        public static void rezervisiKafic(RezervacijaKaficaa kk)
        {
            if (provjeriKafic(kk).Equals(true))
                kk.rezervisi();
            else throw new Exception("Nije slobodno");
        }
        public static bool provjeriSmjestaj(RezervacijaSmjestajaa s)
        {
            return s.provjeraDostupnosti();
        }
        public static void rezervisiSmjestaj(RezervacijaSmjestajaa s)
        {
            if (provjeriSmjestaj(s).Equals(true))
                s.rezervisi();
            else throw new Exception("Nije slobodno");
        }
    }
}
