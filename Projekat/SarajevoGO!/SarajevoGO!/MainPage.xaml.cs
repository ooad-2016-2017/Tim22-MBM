
using Microsoft.WindowsAzure.MobileServices;
using SarajevoGO_.Model;
using SarajevoGO_.ViewModel;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SarajevoGO_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainViewModel viewModel;
        IMobileServiceTable<Supervizor> userTableObj = App.MobileService.GetTable<Supervizor>();

        
        public MainPage()
        {
            this.InitializeComponent();
            viewModel = new MainViewModel();
            NavigationCacheMode = NavigationCacheMode.Required;


            /*IMobileServiceTableQuery<String> query = userTableObj.Where(t => t.username == "Semra");
            var res = await query.ToListAsync();
            var item = res.First();
            //fName is a string in your object MyTable just get it like this
            string fname = item.fname;

            /*foreach (Supervizor sup in userTableObj.ExecuteQuery(query))
            {
                Console.WriteLine("{0}, {1}\t{2}\t{3}", entity.PartitionKey, entity.RowKey,
                                    entity.Field1, entity.Field2);
            }
            Supervizor obj = new Supervizor();
            obj.username = this.textBox.Text;
            obj.password = this.textBox1.Text;
            //obj.ti txtIndeks.Text;
            userTableObj.InsertAsync(obj);
            MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog supervizora.");

            msgDialog.ShowAsync();*/
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

    }
}
