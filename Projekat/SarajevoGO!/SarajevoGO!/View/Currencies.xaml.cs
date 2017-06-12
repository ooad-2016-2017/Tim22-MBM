using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SarajevoGO_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Currencies : Page
    {
        public Currencies()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += (s, a) =>
            {
                Debug.WriteLine("BackRequested");
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                    a.Handled = true;
                }
            };
        }

        private async void button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string a = textBox.Text;
            Double rez=0;
          
            
            if (a == "")
            {
                var messageDialog1 = new MessageDialog("Morate unijeti iznos novca!");
                await messageDialog1.ShowAsync();
            }
            else
            {
                if (comboBox.SelectedIndex.ToString() == "1" && comboBox1.SelectedIndex.ToString() == "0")
                {
                    rez += (Convert.ToDouble(a) * 1.75);
                    textBox1.Text = rez.ToString();
                }
                else if (comboBox.SelectedIndex.ToString() == "0" && comboBox1.SelectedIndex.ToString() == "0")
                {
                    rez += (Convert.ToDouble(a) * 1.95);
                    textBox1.Text = rez.ToString();
                }
                else if (comboBox.SelectedIndex.ToString() == "2" && comboBox1.SelectedIndex.ToString() == "0")
                {
                    rez += (Convert.ToDouble(a) * 0.26);
                    textBox1.Text = rez.ToString();
                }
            }
        }
    }
}
