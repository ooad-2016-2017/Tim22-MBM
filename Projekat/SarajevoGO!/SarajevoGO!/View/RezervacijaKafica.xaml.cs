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
    public sealed partial class RezervacijaKafica : Page
    {
        RezervacijaViewModel viewModel;
        public Button b1;
       
        public RezervacijaKafica()
        {
            this.InitializeComponent();
            //b1 = this.button_konacno;
           // this.text_availability.Visibility = Visibility.Collapsed;
            //this.text_odluka.Visibility = Visibility.Collapsed;
            //this.button_konacno.Visibility = Visibility.Collapsed;
            //b1.Visibility = Visibility.Collapsed; 
            viewModel = new RezervacijaViewModel();
            this.DataContext = viewModel;
        }

        /*private void button_Click(object sender, RoutedEventArgs e)
        {
            this.button_konacno.Visibility = Visibility.Visible;
            this.text_availability.Visibility = Visibility.Visible;
            this.text_odluka.Visibility = Visibility.Visible;
        }*/
    }
}
