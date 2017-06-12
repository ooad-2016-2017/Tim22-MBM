using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoGO_.Model
{
    public class RezervacijaKarte
    {
        public Kultura mjesto;
        public int brojOdraslih { get; set; }
        public int brojDjece { get; set; }
        public DateTime vrijemeDolaska { get; set; }
        public RezervacijaKarte() { }
        public RezervacijaKarte(string naziv, string odrasli, string djeca, DateTime dolazak)
        {
            Kategorija k = Sistem.PretragaObjekata(naziv);
            if (k is Kultura)
                mjesto = (Kultura)k;
            brojOdraslih = Convert.ToInt32(odrasli);
            brojDjece = Convert.ToInt32(djeca);
            vrijemeDolaska = dolazak;
        }
        /*public bool provjeraDostupnosti()
        {
            int dan = vrijemeDolaska.Day;
            return (mjesto.brojMjesta[dan - 1] - brojDjece - brojOdraslih >= 0);
        }
        public double izracunajCijenu()
        {
            return brojDjece * mjesto.cijenaDjeca + brojOdraslih * mjesto.cijenaOdrasli;
        }

        public void rezervisi()
        {
            mjesto.rezervisiKartu(brojDjece + brojOdraslih, vrijemeDolaska.Day);
        }*/
    }
}
