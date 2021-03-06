﻿using SarajevoGO_.Helper;
using SarajevoGO_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace SarajevoGO_.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        //Korisnik user, admin;
        bool a;
        private String _Username;
        private String _Password;

        public string Username
        {
            get { return _Username; }
            set
            {
                _Username = value;
                OnPropChanged("Username");
            }
        }

        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                OnPropChanged("Password");
            }
        }

        private MainViewModel parent;
        public INavigation MyNavigationService { get; set; }
        public ICommand BackKomanda { get; set; }
        public ICommand LogovanjeKomanda { get; set; }

        public LoginViewModel(MainViewModel parent)
        {
            this.parent = parent;
            a = false;
            MyNavigationService = new NavigationService();
            BackKomanda = new RelayCommand<object>(back,canGo);
            LogovanjeKomanda = new RelayCommand<object>(log, canGo);
        }
        public LoginViewModel()
        {
            MyNavigationService = new NavigationService();
            BackKomanda = new RelayCommand<object>(back, canGo);
            BackKomanda = new RelayCommand<object>(back, canGo);
            LogovanjeKomanda = new RelayCommand<object>(log, canGo);
        }
        private async void log(object parametar)
        {
            
            if (DaLiJeSupervizor())
            {
                MyNavigationService.Navigate(typeof(SupervisorTab));
            }
            else if (Username == "Admin" && Password == "Admin")
            {
                MyNavigationService.Navigate(typeof(AdminTab));
            }
            else if (Password == "" || Username == "")
            {
                var messageDialog1 = new MessageDialog("Morate popuniti sva polja!");
                await messageDialog1.ShowAsync();
            }
            else 
            {
                var messageDialog = new MessageDialog("Username/password nije ispravan!");
                await messageDialog.ShowAsync();
            }
           // MyNavigationService.Navigate(typeof(RezervacijaKarata));

        }

        public bool DaLiJeSupervizor()
        {
           
            foreach (Supervizor s in Sistem.listaSupervizora)
            {
                if (s.username == Username && s.password == Password)
                    a = true;
            }
            return a;

        }
        /*private async void log(object parameter)
        {

            /*user = Sistem.listaSupervizora.Where(x => x.username == Username && x.password == Password).FirstOrDefault();
            if (user!=null){
               MyNavigationService.Navigate(typeof(SupervisorTab));
            }

            if(Username == "Admin" && Password == "Admin")
              {
                  MyNavigationService.Navigate(typeof(AdminTab));
              }*/

      /*      MyNavigationService.Navigate(typeof(RezervacijaSmjestaja));
            //MyNavigationService.Navigate(typeof(AdminTab));
        }*/

        private void back(object parameter)
        {
            /*using (var db = new BankDbContext())
            {
                List<Person> list = db.Persons.ToList<Person>();
                User = (Person)list.Where(x => x.Username == Username && x.Password == Password).FirstOrDefault();
            }
            if (User != null)
            {
                if (User.Validated == false)
                {
                    var message = new MessageDialog("Vas racun jos nije verifikovan!", "Greska!");
                    message.ShowAsync();
                    return;
                }
                if (User.Type == "Supervisor") MyNavigationService.Navigate(typeof(SupervisorPanel), new SupervisorPanelViewModel(this));
                else if (User.Type == "User") MyNavigationService.Navigate(typeof(UserAccount), new UserAccountViewModel(this, ref User));
                else if (User.Type == "Referent") MyNavigationService.Navigate(typeof(ReferentAccountMain), new ReferentAccount(this, ref User));
            }*/
            MyNavigationService.Navigate(typeof(MainPage), new MainViewModel());
        }
        private bool canGo(object parameter)
        {
            //neki uslov
            return true;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropChanged([CallerMemberName] string property = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
