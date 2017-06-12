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
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;using SarajevoGO_.Model;
using Microsoft.Data.Entity.Metadata;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SarajevoGO_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodavanjeSupervizora : Page
    {
        IMobileServiceTable<Supervizor> userTableObj = App.MobileService.GetTable<Supervizor>();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                bool a = postojiLiVec();
                if (a == true)
                {
                    var messageDialog = new MessageDialog("Postoji vec taj supervizor!");
                    await messageDialog.ShowAsync();
                }
                else if (this.textBox1.Text == "" || this.textBox.Text == "")
                {
                    var messageDialog = new MessageDialog("Sva polja moraju bit popunjena!");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    Supervizor obj = new Supervizor();
                    obj.username = this.textBox.Text;
                    obj.password = this.textBox1.Text;
                    //obj.ti txtIndeks.Text;
                 //   await userTableObj.InsertAsync(obj);
                    Sistem.listaSupervizora.Add(new Supervizor(this.textBox.Text, this.textBox1.Text));
                    MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog supervizora.");

                    await msgDialog.ShowAsync();
                    this.textBox.Text = "";
                    this.textBox1.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                await msgDialogError.ShowAsync();
            }
        }
        public bool postojiLiVec()
        {
            bool a = false;
            foreach (Supervizor s in Sistem.listaSupervizora)
            {
                if (s.username == this.textBox.Text)
                    a = true;
            }
            return a;
        }

        public DodavanjeSupervizora()
        {
            this.InitializeComponent();
            
        }
    }
}
