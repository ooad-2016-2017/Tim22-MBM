using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SarajevoGO_.Model
{
    public class Supervizor : Korisnik
    {
        public List<Kategorija> listaObjekata { get; set; }
        public List<Kategorija> listaZahtjeva { get; set; }
        string tipSupervizora { get; set; }

        public Supervizor(string name, string pass, string tip) : base(name, pass)
        {
            listaObjekata = new List<Kategorija>();
            listaZahtjeva = new List<Kategorija>();
            tipSupervizora = tip;
        }

        public void dodajObjekat(Kategorija k, string tip, string naziv, Int32 broj, string web, string detalji, Image slika, Image meni)
        {
            if (Sistem.validirajObjekat(naziv).Equals(false))
                throw new Exception("Postoji objekat s istim nazivom");
            switch (tip)
            {
                case "JeloPice":
                    JeloIPice j = new JeloIPice(tip, naziv, "", web, detalji, broj, slika, meni);
                    listaObjekata.Add(j);
                    Sistem.listaKategorija.Add(j);
                    break;
                case "Aktivnost":
                    Aktivnost a = (Aktivnost)k;
                    listaObjekata.Add(a);
                    Sistem.listaKategorija.Add(a);
                    break;
                case "Shopping":
                    Shopping sh = (Shopping)k;
                    listaObjekata.Add(sh);
                    Sistem.listaKategorija.Add(sh);
                    break;
                case "Kultura":
                    Kultura kul = new Kultura(tip, naziv, "", web, detalji, broj, slika); // ukoliko se ne promijeni dizajn formi, podrazumijevane vr
                    listaObjekata.Add(kul);
                    Sistem.listaKategorija.Add(kul);
                    break;
                case "NocniZivot":
                    NocniZivot n = new NocniZivot(tip, naziv, "", web, detalji, broj, slika); //
                    listaObjekata.Add(n);
                    Sistem.listaKategorija.Add(n);
                    break;
                case "Smjestaj":
                    Smjestaj s = new Smjestaj(tip, naziv, "", web, detalji, broj, slika); //
                    listaObjekata.Add(s);
                    Sistem.listaKategorija.Add(s);
                    break;
            }
            listaZahtjeva.Remove(k);
        }

        public void obrisiZahtjev(Kategorija k)
        {
            listaZahtjeva.Remove(k);
        }
    }
}
