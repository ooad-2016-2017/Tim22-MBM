using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoGO_.Model
{
    public class RezervacijaKafica
    {
        public NocniZivot kafic;
        public DateTime vrijemeDolaska { get; set; }
        public Int32 brojStolova { get; set; }
        public RezervacijaKafica(string naziv, DateTime vrijeme, string broj)
        {
            Kategorija k = Sistem.PretragaObjekata(naziv);
            if (k is NocniZivot)
                kafic = (NocniZivot)k;
            vrijemeDolaska = vrijeme;
            brojStolova = Convert.ToInt32(broj);
        }

        public bool provjeraDostupnosti()
        {
            Int32 dan = vrijemeDolaska.Day;
            return (kafic.brojStolova[dan - 1] - brojStolova >= 0);
        }
        public void rezervisi()
        {
            kafic.rezervisiSto(brojStolova, vrijemeDolaska.Day);
        }
    }
}
