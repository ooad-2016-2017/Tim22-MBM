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
    public sealed partial class TipsZaAdmina : Page
    {
        public TipsZaAdmina()
        {
            this.InitializeComponent();
            listView.Items.Add("Posjetite Bašcaršiju!");
            listView.Items.Add("Jedite ćevape!");
            listView.Items.Add("Naučite historiju Sarajeva!");
            listView.Items.Add("Probajte bosansku kahvu!");
            listView.Items.Add("Probajte tradiconalne bosanske slatkiše (tufahija, baklava..)!");
            listView.Items.Add("Hranite golubove kod Sebilja!");
            listView.Items.Add("Posjetite mjesto gdje je započeo Prvi svjetski rat!");
            listView.Items.Add("Posjetite Olimpijsku bob stazu!");
        }
    }
}
