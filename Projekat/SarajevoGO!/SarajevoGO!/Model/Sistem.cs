using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SarajevoGO_.Model
{
    public static class Sistem
    {
        public static List<RezervacijaKafica> listaRezervacijaKafica;
        public static List<RezervacijaKarte> listaRezervacijaKarte;
        public static List<RezervacijaSmjestaja> listaRezervacijaSmjestaja;
        public static List<Supervizor> listaSupervizora;
        public static List<Kategorija> listaKategorija;
        

        static Sistem()
        {
            Image slika = new Image();
            listaKategorija = new List<Kategorija>();
            // PRIMJERI ZBOG KRAHIRANJA
            listaKategorija.Add(new NocniZivot("Kafic", "Drinks", "Negdje", "stranica", "blabla", 062, slika));
            listaKategorija.Add(new Kultura("Muzej", "Culture", "Negdje", "stranica", "blabla", 062, slika));
            listaKategorija.Add(new Smjestaj("Krevet", "Acc", "Negdje", "stranica", "blabla", 062, slika));

            listaRezervacijaKafica = new List<RezervacijaKafica>();
            listaRezervacijaKarte = new List<RezervacijaKarte>();
            listaRezervacijaSmjestaja = new List<RezervacijaSmjestaja>();
            listaSupervizora = new List<Supervizor>();
            listaSupervizora.Add(new Supervizor("Supervizor", "Supervizor", "smjestaj"));
        }
        public static Kategorija PretragaObjekata(string naziv)
        {
            Kategorija k = listaKategorija.Find(x => x.nazivObjekt == naziv);
            return k;
        }
        public static bool validacijaLoginAdmin(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin"))
                return true;
            return false;
        }
        public static bool validacijaLoginSupervizor(string username, string password)
        {
            foreach (Supervizor s in listaSupervizora)
            {
                if (s.username.Equals(username) && s.password.Equals(password))
                    return true;
            }
            return false;
        }
        // dodati na formu prilikom slanja rezervacije
        public static bool validirajDatume(DateTime prvi, DateTime drugi)
        {
            if (DateTime.Compare(prvi, drugi) <= 0)
                return false;
            return true;
        }
        public static bool validirajSupervizora(string username)
        {
            return !listaSupervizora.Exists(x => x.username.Equals(username));
        }
        public static bool validirajObjekat(string naziv)
        {
            return !listaKategorija.Exists(x => x.nazivObjekt.Equals(naziv));
        }
    }
}
