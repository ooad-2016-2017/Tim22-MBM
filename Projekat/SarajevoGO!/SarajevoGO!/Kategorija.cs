using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace App1
{
    abstract class Kategorija
    {
        String tip, nazivObjekta, adresa, web, info;
        Int32 telefon;
        Image slika;

        public Kategorija(String t, String naziv, String adr, String www, String inf, Int32 tel, Image sl)
        {
            tip = t;
            nazivObjekta = naziv;
            adresa = adr;
            web = www;
            info = inf;
            telefon = tel;
            slika = sl;
        }
        public string Tip
        {
            get
            {
                return tip;
            }

            set
            {
                tip = value;
            }
        }

        public string NazivObjekta
        {
            get
            {
                return nazivObjekta;
            }

            set
            {
                nazivObjekta = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }

        public string Web
        {
            get
            {
                return web;
            }

            set
            {
                web = value;
            }
        }

        public string Info
        {
            get
            {
                return info;
            }

            set
            {
                info = value;
            }
        }

        public int Telefon
        {
            get
            {
                return telefon;
            }

            set
            {
                telefon = value;
            }
        }

        public Image Slika
        {
            get
            {
                return slika;
            }

            set
            {
                slika = value;
            }
        }
    }
}

