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
    public class LoginViewModel : INotifyPropertyChanged
    {
        private MainViewModel parent;
        public INavigation MyNavigationService { get; set; }
        public ICommand BackKomanda { get; set; }
        public ICommand LogovanjeKomanda { get; set; }

        public LoginViewModel(MainViewModel parent)
        {
            this.parent = parent;
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

        private void log(object parameter)
        {
            //MyNavigationService.Navigate(typeof(SupervisorTab));
             MyNavigationService.Navigate(typeof(AdminTab));
        }

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
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
