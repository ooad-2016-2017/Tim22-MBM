using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoGO_.Model
{
    public class RezervacijaSmjestaja
    {
        public Smjestaj smjestaj;
        public DateTime dolazak { get; set; }
        public DateTime odlazak { get; set; }
        public bool dorucak, rucak, vecera;
        public string vrstaSobe { get; set; }
        public Int32 godiste { get; set; }
        public RezervacijaSmjestaja(string naziv, DateTime dol, DateTime odl, bool d, bool r, bool v, string vrsta, Int32 godine)
        {
            Kategorija k = Sistem.PretragaObjekata(naziv);
            if (k is Smjestaj)
                smjestaj = (Smjestaj)k;
            dolazak = dol;
            odlazak = odl;
            dorucak = d;
            rucak = r;
            vecera = v;
            vrstaSobe = vrsta;
            godiste = godine;
        }
        public double izracunajKonacnuCijenu()
        {
            double brojDana = (odlazak - dolazak).TotalDays;
            double cijena = smjestaj.cijenaPoNoci;
            if (vrstaSobe.Equals("Triple room"))
                cijena += 5;
            else cijena += 10;
            if (dorucak == true) cijena += 5;
            if (rucak == true) cijena += 5;
            if (vecera == true) cijena += 5;
            double konacno = cijena * brojDana;
            if (popust() == true)
                konacno *= 0.9;
            return konacno;

        }
        public bool provjeraDostupnosti()
        {
            Int32 koef;
            if (vrstaSobe.Equals("Double room"))
            {
                koef = 2;
                for (int i = dolazak.Day - 1; i < odlazak.Day - 1; i++)
                {
                    if (smjestaj.brojDvokrevetnih[i] - koef < 0)
                        return false;
                }
            }
            else if (vrstaSobe.Equals("Triple room"))
            {
                koef = 3;
                for (int i = dolazak.Day - 1; i < odlazak.Day - 1; i++)
                {
                    if (smjestaj.brojTrokrevetnih[i] - koef < 0)
                        return false;
                }
            }
            else
            {
                koef = 4;
                for (int i = dolazak.Day - 1; i < odlazak.Day - 1; i++)
                {
                    if (smjestaj.brojCetverokrevetnih[i] - koef < 0)
                        return false;
                }
            }
            return true;
        }
        public void generisiQRKod()
        {
            // sljedeci projektni
        }
        public bool popust()
        {
            return (godiste >= 18 && godiste <= 25);
        }

        public void rezervisi()
        {
            smjestaj.rezervisiSmjestaj(vrstaSobe, dolazak.Day, odlazak.Day);
        }
    }
}
