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
    public abstract class Korisnik
    {
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string password { get; set; }

        public Korisnik(string name, string pass)
        {
            username = name;
            password = pass;
        }
        public Korisnik() { }
    }
}
