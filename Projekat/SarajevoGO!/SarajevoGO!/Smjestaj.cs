using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace App1
{
    class Smjestaj : Kategorija

    {

        String tip, nazivObjekta, adresa, web, info;
        Int32 telefon;
        Image slika;
        Boolean dorucak, rucak, vecera;
        Int32 brojDvokrevetnih, brojTrokrevetnih, brojCetverokrevetnih;
        Int32 cijenaPoNoci;

        public bool Dorucak
        {
            get
            {
                return dorucak;
            }

            set
            {
                dorucak = value;
            }
        }

        public bool Rucak
        {
            get
            {
                return rucak;
            }

            set
            {
                rucak = value;
            }
        }

        public bool Vecera
        {
            get
            {
                return vecera;
            }

            set
            {
                vecera = value;
            }
        }

        public int BrojDvokrevetnih
        {
            get
            {
                return brojDvokrevetnih;
            }

            set
            {
                brojDvokrevetnih = value;
            }
        }

        public int BrojTrokrevetnih
        {
            get
            {
                return brojTrokrevetnih;
            }

            set
            {
                brojTrokrevetnih = value;
            }
        }

        public int BrojCetverokrevetnih
        {
            get
            {
                return brojCetverokrevetnih;
            }

            set
            {
                brojCetverokrevetnih = value;
            }
        }

        public int CijenaPoNoci
        {
            get
            {
                return cijenaPoNoci;
            }

            set
            {
                cijenaPoNoci = value;
            }
        }

        public Smjestaj(String t, String naziv, String adr, String www, String inf, Int32 tel, Image sl, Boolean dor, Boolean ruc, Boolean vec, Int32 cijena) : base(t, naziv, adr, www, inf, tel, sl)
        {
            dorucak = dor;
            rucak = ruc;
            vecera = vec;
            cijenaPoNoci = cijena;
            brojDvokrevetnih = brojTrokrevetnih = brojCetverokrevetnih = 5;
        }
    }
}
