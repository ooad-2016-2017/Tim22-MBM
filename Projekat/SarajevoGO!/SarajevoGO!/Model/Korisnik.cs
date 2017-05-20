using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoGO_.Model
{
    public abstract class Korisnik
    {
        public string username { get; set; }
        public string password { get; set; }
        public Korisnik(string name, string pass)
        {
            username = name;
            password = pass;
        }
    }
}
