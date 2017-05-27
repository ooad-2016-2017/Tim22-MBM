using SarajevoGO_.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SarajevoGO_.ViewModel
{
    class RezervacijaViewModel : INotifyPropertyChanged
    {
        public INavigation MyNavigationService { get; set; }
        public ICommand DostupnostKomanda { get; set; }
        public ICommand RezKonacnaKomanda { get; set; }
        public ICommand RezKodKomanda { get; set; }

        public RezervacijaViewModel()
        {
            MyNavigationService = new NavigationService();
            DostupnostKomanda = new RelayCommand<object>(dostupnost, canGo);
            RezKonacnaKomanda = new RelayCommand<object>(rezkonacna, canGo);
            RezKodKomanda = new RelayCommand<object>(rezsmjestaja, canGo);
        }

        private void dostupnost(object parameter)
        {
            // provjera dostupnosoti
        }

        private void rezkonacna(object parameter)
        {
            // messagedialog
            // var dialog = new MessageDialog("message");
            //await dialog.ShowAsync();
        }

        private void rezsmjestaja(object parameter)
        {
            MyNavigationService.Navigate(typeof(RezervacijaPotvrda));
        }

        private bool canGo(object parameter)
        {
            //neki uslov
            return true;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
