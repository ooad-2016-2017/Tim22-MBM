using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoGO_.Helper
{
    public interface INavigation
    {
        void Navigate(Type sourcePage);
        void Navigate(Type sourcePage, object parameter);
        void NavigateRez(Type sourcePage);
        void GoBack();
    }
}
