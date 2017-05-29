using SarajevoGO_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace SarajevoGO_.Model
{
    [DataContract]
    public class Administrator : Korisnik
    {
        [DataMember]
        public List<Supervizor> listaSupervizora;
        [DataMember]
        public List<Kategorija> listaKategorija;
        public Administrator(string name, string pass) : base(name, pass)
        {
            listaSupervizora = new List<Supervizor>();
            listaKategorija = new List<Kategorija>();
        }
        public void dodajSupervizora(string username, string password, string tip)
        {
            if (Sistem.validirajSupervizora(username))
            {
                Supervizor s = new Supervizor(username, password, tip);
                listaSupervizora.Add(s);
                Sistem.listaSupervizora.Add(s);
            }
            else throw new Exception("Supervizor sa istim username vec postoji!");
        }
        public void obrisiSupervizora(Supervizor s)
        {
            listaSupervizora.Remove(s);
            Sistem.listaSupervizora.Remove(s);
        }
        public Administrator() { }
    }
}
