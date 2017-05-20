using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SarajevoGO_.Model
{
    public class NocniZivot : Kategorija
    {
        public Int32[] brojStolova { get; set; }
        public NocniZivot(String tip, String naziv, String adr, String www, String detalji, Int32 tel, Image sl) : base(tip, naziv, adr, www, detalji, tel, sl)
        {
            brojStolova = Enumerable.Repeat(15, 31).ToArray();
        }
        public void rezervisiSto(Int32 broj, Int32 dan)
        {
            brojStolova[dan - 1] -= broj;
        }
    }
}
