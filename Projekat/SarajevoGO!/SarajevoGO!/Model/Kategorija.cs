using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SarajevoGO_.Model
{
    public abstract class Kategorija
    {
        public String tip { get; set; }
        public string nazivObjekt { get; set; }
        public string adresa { get; set; }
        public string web { get; set; }
        public string info { get; set; }
        public Int32 telefon { get; set; }
        public Image slika { get; set; }

        public Kategorija() { }
        public Kategorija(String vrsta, String naziv, String adr, String www, String detalji, Int32 tel, Image sl)
        {
            tip = vrsta;
            nazivObjekt = naziv;
            adresa = adr;
            web = www;
            info = detalji;
            slika = sl;
        }
        public Kategorija(Kategorija k)
        {
            tip = k.tip;
            nazivObjekt = k.nazivObjekt;
            adresa = k.adresa;
            web = k.web;
            info = k.info;
            slika = k.slika;
        }
    }
}

