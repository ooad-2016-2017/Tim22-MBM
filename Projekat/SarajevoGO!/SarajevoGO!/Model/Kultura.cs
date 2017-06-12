using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SarajevoGO_.Model
{
    public class Kultura : Kategorija
    {
        public Double cijenaOdrasli { get; set; }
        public Double cijenaDjeca { get; set; }
        public Int32[] brojMjesta { get; set; }

        public Kultura(String tip, String naziv, String adr, String www, String inf, Int32 tel, Image sl, Double cijenaO = 10, Double cijenaD = 5) : base(tip, naziv, adr, www, inf, tel, sl)
        {
            cijenaOdrasli = cijenaO;
            cijenaDjeca = cijenaD;
            brojMjesta = Enumerable.Repeat(50, 31).ToArray();
        }

        /*public void rezervisiKartu(Int32 broj, Int32 dan)
        {
            brojMjesta[dan - 1] -= broj;
        }*/
    }
}
