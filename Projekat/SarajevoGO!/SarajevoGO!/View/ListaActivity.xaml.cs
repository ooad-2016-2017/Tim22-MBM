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
    public sealed partial class ListaActivity : Page
    {
        GostViewModel viewModel;
        //Button bhome;
        public ListaActivity()
        {
            this.InitializeComponent();
            viewModel = new GostViewModel();
           // bhome = this.buttonHome;
           // var lastPage = Frame.BackStack.Last().SourcePageType;
            /*if (null!= lastPage && true==lastPage.ToString().Contains("AdminTab.xaml"))
            {
                buttonHome.Visibility = Visibility.Collapsed;
            }
            else buttonHome.Visibility = Visibility.Visible;*/
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /*private void buttonHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ActivityZaGosta));
        }*/
    }
}
