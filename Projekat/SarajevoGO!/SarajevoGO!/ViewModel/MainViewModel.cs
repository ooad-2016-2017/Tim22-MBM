using SarajevoGO_.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SarajevoGO_.ViewModel
{
    public class MainViewModel
    {
        public INavigation MyNavigationService { get; set; }
        public ICommand NavigateToLogin { get; set; }
        public ICommand NavigateToKategorije { get; set; }

        public MainViewModel()
        {
            MyNavigationService = new NavigationService();
           
            NavigateToLogin = new RelayCommand<object>(login);
            NavigateToKategorije = new RelayCommand<object>(izbor);
        }

        private void izbor(object parameter)
        {
            MyNavigationService.Navigate(typeof(Gost), new GostViewModel(this));
        }
        private void login(object parameter)
        {
            MyNavigationService.Navigate(typeof(LoginForma), new LoginViewModel(this));
        }
    }
}
