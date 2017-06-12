using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SarajevoGO_.Helper
{
    public class NavigationService : INavigation
    {
        int p;
        public void GoBack()
        {
            var frame = (Frame)Window.Current.Content;
            frame.GoBack();
        }

        public void Navigate(Type sourcePage)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage);
        }
        public void Navigate(Type sourcePage, int pomoc)
        {
            p = pomoc;
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage);
        }
        public void NavigateRez(Type sourcePage)
        {
            var frame = (Frame)Window.Current.Content;
            if(sourcePage == typeof(RezervacijaKafica))
            {
                RezervacijaKafica rez = new RezervacijaKafica();
                rez.b1.Visibility = Visibility.Visible;
            }
            frame.Navigate(sourcePage);
        }

        public void Navigate(Type sourcePage, object parameter)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage, parameter);
        }
    }
}
