using SarajevoGO_.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SarajevoGO_.ViewModel
{
    public class GostViewModel : INotifyPropertyChanged
    {
        private MainViewModel parent;
        public INavigation MyNavigationService { get; set; }

        public ICommand BackKomanda { get; set; }
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
        public ICommand AdresaKomanda { get; set; }
        public ICommand MobKomanda { get; set; }
        public ICommand WebKomanda { get; set; }
        public ICommand InfoKomanda { get; set; }
        public ICommand RezSmjestajaKomanda { get; set; }
        public ICommand RezKaficaKomanda { get; set; }
        public ICommand RezKarataKomanda { get; set; }
        public ICommand MeniKomanda { get;  set;}
        public ICommand HomeKomanda { get; set; }
        public ICommand SearchKomanda { get; set; }
        public ICommand MjestoKomanda { get; set; }



        public GostViewModel(MainViewModel parent)
        {
            this.parent = parent;
            MyNavigationService = new NavigationService();
            HomeKomanda = new RelayCommand<object>(home, canGo);
            SearchKomanda = new RelayCommand<object>(search, canGo);
            MjestoKomanda = new RelayCommand<object>(mjesto, canGo);

            BackKomanda = new RelayCommand<object>(back, canGo);
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
            AktivnostListaKomanda = new RelayCommand<object>(listaaktivnosti, canGo);
            KulturaListaKomanda = new RelayCommand<object>(listakultura, canGo);
            ShoppingListaKomanda = new RelayCommand<object>(listashopping, canGo);

            AdresaKomanda = new RelayCommand<object>(adresa, canGo);
            MobKomanda = new RelayCommand<object>(mob, canGo);
            WebKomanda = new RelayCommand<object>(web, canGo);
            RezSmjestajaKomanda = new RelayCommand<object>(rezsmjestaja, canGo);
            RezKaficaKomanda = new RelayCommand<object>(rezkafica, canGo);
            RezKarataKomanda = new RelayCommand<object>(rezkarata, canGo);
            MeniKomanda = new RelayCommand<object>(meni, canGo);

        }
        public GostViewModel()
        {
            MyNavigationService = new NavigationService();
            HomeKomanda = new RelayCommand<object>(home, canGo);
            SearchKomanda = new RelayCommand<object>(search, canGo);
            MjestoKomanda = new RelayCommand<object>(mjesto, canGo);

            BackKomanda = new RelayCommand<object>(back, canGo);
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
            AktivnostListaKomanda = new RelayCommand<object>(listaaktivnosti, canGo);
            KulturaListaKomanda = new RelayCommand<object>(listakultura, canGo);
            ShoppingListaKomanda = new RelayCommand<object>(listashopping, canGo);

            AdresaKomanda = new RelayCommand<object>(adresa, canGo);
            MobKomanda = new RelayCommand<object>(mob, canGo);
            WebKomanda = new RelayCommand<object>(web, canGo);
            RezSmjestajaKomanda = new RelayCommand<object>(rezsmjestaja, canGo);
            RezKaficaKomanda = new RelayCommand<object>(rezkafica, canGo);
            RezKarataKomanda = new RelayCommand<object>(rezkarata, canGo);
            MeniKomanda = new RelayCommand<object>(meni, canGo);
        }
        private void back(object parameter)
        {
            MyNavigationService.GoBack();
        }

        private void home(object parameter)
        {
            MyNavigationService.Navigate(typeof(MainPage));
          
        }

        private void search(object parameter)
        {
            MyNavigationService.Navigate(typeof(Search));
        }
        private void mjesto(object parameter)
        {
            MyNavigationService.Navigate(typeof(CreatePlace));
        }

        private void rezsmjestaja(object parameter)
        {
            MyNavigationService.Navigate(typeof(RezervacijaSmjestaja));
        }
        private void rezkafica(object parameter)
        {
            MyNavigationService.Navigate(typeof(RezervacijaKafica));
        }
        private void rezkarata(object parameter)
        {
            MyNavigationService.Navigate(typeof(RezervacijaKarata));
        }
        
        private void meni(object parameter)
        {
            MyNavigationService.Navigate(typeof(MeniZaGosta));
        }

        private void adresa(object parameter)
        {
            MyNavigationService.Navigate(typeof(MapaAdresaInfo));
        }
        private void mob(object parameter)
        {
            //POZIV
        }
        private void web(object parameter)
        {
            //STRANICA
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
            MyNavigationService.Navigate(typeof(SmjestajZaGosta));
        }
        private void restoran(object parameter)
        {
            MyNavigationService.Navigate(typeof(RestoranZaGosta));
        }
        private void kafic(object parameter)
        {
            MyNavigationService.Navigate(typeof(NightlifeZaGosta));
        }
        private void aktivnost(object parameter)
        {
            MyNavigationService.Navigate(typeof(ActivityZaGosta));
        }
        private void kultura(object parameter)
        {
            MyNavigationService.Navigate(typeof(KulturaZaGosta));
        }
        private void shopping(object parameter)
        {
            MyNavigationService.Navigate(typeof(ShoppingZaGosta));
        }
        private void valute(object parameter)
        {
            MyNavigationService.Navigate(typeof(Currencies));
        }
        private void tips(object parameter)
        {
            MyNavigationService.Navigate(typeof(TipsZaGosta));
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
