using SarajevoGO_.Helper;
using SarajevoGO_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace SarajevoGO_.ViewModel
{
    class AdminViewModel : INotifyPropertyChanged
    {

        private string username;
        private string pass;
        private string tipSupervizora;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
              //  NotifyPropertyChanged("Username");
            }
        }

        Supervizor sup = new Supervizor();
        Administrator admin = new Administrator();
        public INavigation MyNavigationService { get; set; }
        public ICommand DodajKomanda { get; set; }
        public ICommand SmjestajKomanda { get; set; }
        public ICommand RestoranKomanda { get; set; }
        public ICommand KaficKomanda { get; set; }
        public ICommand AktivnostKomanda { get; set; }
        public ICommand KulturaKomanda { get; set; }
        public ICommand ShoppingKomanda { get; set; }
        public ICommand ValuteKomanda { get; set; }
        public ICommand TipsKomanda { get; set; }
        public ICommand SmjestajListaKomanda { get; set; }
        public ICommand RestoranListaKomanda { get; set; }
        public ICommand KaficListaKomanda { get; set; }
        public ICommand AktivnostListaKomanda { get; set; }
        public ICommand KulturaListaKomanda { get; set; }
        public ICommand ShoppingListaKomanda { get; set; }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public string TipSupervizora
        {
            get
            {
                return tipSupervizora;
            }

            set
            {
                tipSupervizora = value;
            }
        }

        public AdminViewModel()
        {
            MyNavigationService = new NavigationService();
            DodajKomanda = new RelayCommand<object>(dodaj, canGo);

            SmjestajKomanda = new RelayCommand<object>(smjestaj, canGo);
            RestoranKomanda = new RelayCommand<object>(restoran, canGo);
            KaficKomanda = new RelayCommand<object>(kafic, canGo);
            AktivnostKomanda = new RelayCommand<object>(aktivnost, canGo);
            KulturaKomanda = new RelayCommand<object>(kultura, canGo);
            ShoppingKomanda = new RelayCommand<object>(shopping, canGo);
            ValuteKomanda = new RelayCommand<object>(valute, canGo);
            TipsKomanda = new RelayCommand<object>(tips, canGo);

            SmjestajListaKomanda = new RelayCommand<object>(listasmjestaja, canGo);
            RestoranListaKomanda = new RelayCommand<object>(listarestorana, canGo);
            KaficListaKomanda = new RelayCommand<object>(listakafica, canGo);
            AktivnostListaKomanda = new RelayCommand<object>(listaaktivnosti);
            KulturaListaKomanda = new RelayCommand<object>(listakultura, canGo);
            ShoppingListaKomanda = new RelayCommand<object>(listashopping, canGo);
        }
        public void dodaj(object parameter)
        {
            MyNavigationService.Navigate(typeof(DodavanjeSupervizora));
        }



        private bool canGo(object parameter)
        {
            //neki uslov
            return true;
        }

        private void listasmjestaja(object parameter)
        {
            MyNavigationService.Navigate(typeof(ListaSmjestaj));
        }
        private void listarestorana(object parameter)
        {
            MyNavigationService.Navigate(typeof(ListaRestoran));
        }
        private void listakafica(object parameter)
        {
            MyNavigationService.Navigate(typeof(ListaNightlife));
        }
        private void listaaktivnosti(object parameter)
        {
            MyNavigationService.Navigate(typeof(ListaActivity));
        }
        private void listakultura(object parameter)
        {
            MyNavigationService.Navigate(typeof(ListaKultura));
        }
        private void listashopping(object parameter)
        {
            MyNavigationService.Navigate(typeof(ListaShopping));
        }

        private void smjestaj(object parameter)
        {
            MyNavigationService.Navigate(typeof(SmjestajZaAdmina));
        }
        private void restoran(object parameter)
        {
            MyNavigationService.Navigate(typeof(RestoranZaAdmina));
        }
        private void kafic(object parameter)
        {
            MyNavigationService.Navigate(typeof(NightlifeZaAdmina));
        }
        private void aktivnost(object parameter)
        {
            MyNavigationService.Navigate(typeof(ActivityZaAdmina));
        }
        private void kultura(object parameter)
        {
            MyNavigationService.Navigate(typeof(KulturaZaAdmina));
        }
        private void shopping(object parameter)
        {
            MyNavigationService.Navigate(typeof(ShoppingZaAdmina));
        }
        private void valute(object parameter)
        {
            MyNavigationService.Navigate(typeof(Currencies));
        }
        private void tips(object parameter)
        {
            MyNavigationService.Navigate(typeof(TipsZaAdmina));
        }

        public async void dodaj(string name, string password, string type)
        {
            bool a = postojiLiVec(name);
            if (a == true)
            {
                var messageDialog = new MessageDialog("Postoji vec taj supervizor!");
                await messageDialog.ShowAsync();
            }
           else if(name=="" || password=="" ||type == "")
            {
                var messageDialog = new MessageDialog("Sva polja moraju bit popunjena!");
                await messageDialog.ShowAsync();
            }
            else
            {
                admin.dodajSupervizora(name, password, type);
                var messageDialog = new MessageDialog("Uspjesno ste dodali supervizora!");
                await messageDialog.ShowAsync();
            }
        }
        public bool postojiLiVec(string username)
        {
            bool a = false;
            foreach(Supervizor s in admin.listaSupervizora)
            {
                if (s.username == username)
                    a = true;
            }
            return a;
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
