using Microsoft.WindowsAzure.MobileServices;
using SarajevoGO_.Model;
using SarajevoGO_.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
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
        IMobileServiceTable<Supervizor> userObj = App.MobileService.GetTable<Supervizor>();
        public MainPage()
        {
            this.InitializeComponent();
            viewModel = new MainViewModel();
            NavigationCacheMode = NavigationCacheMode.Required;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        /*private async void bos_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Supervizor obj = new Supervizor("Ime", "sifra", "Kultura");
                await userObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspjesnoooo");
                msgDialog.ShowAsync();
            }
            catch(Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }*/
    }
}
