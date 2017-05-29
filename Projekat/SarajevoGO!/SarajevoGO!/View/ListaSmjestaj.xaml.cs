using SarajevoGO_.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SarajevoGO_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListaSmjestaj : Page
    {
        GostViewModel viewModel;
        public ListaSmjestaj()
        {
            this.InitializeComponent();
            viewModel = new GostViewModel();
        }
        private bool CheckLastPage(Type desiredPage)
        {
            var lastPage = Frame.BackStack.LastOrDefault();
            return (lastPage != null && lastPage.SourcePageType.Equals(desiredPage)) ? true : false;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (CheckLastPage(typeof(AdminTab)))
            {
                this.buttonHome.Visibility = Visibility.Collapsed;
                this.buttonSearch.Visibility = Visibility.Collapsed;
                this.buttonCreate.Visibility = Visibility.Collapsed;
                //await new MessageDialog("Previous is AdminTab").ShowAsync();
            }

        }


    }
}
