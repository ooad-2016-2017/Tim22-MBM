using SarajevoGO_.Helper;
using SarajevoGO_.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace SarajevoGO_.ViewModel
{
    class RezervacijaViewModel : INotifyPropertyChanged
    {
        SarajevoGO_.Model.RezervacijaKarte rezkarata;
        SarajevoGO_.Model.RezervacijaSmjestaja rezsmjestaj;
        SarajevoGO_.Model.RezervacijaKafica nova;


        private String _Naziv;
        private String _Age;
        public String _Table;
        public DateTime _Date;
        public String _Tip;
        bool dostupna;
        bool dostupnakarta;
        bool popust;
        bool dostupnismjestaj;
        public DateTime _Dolazak;
        public DateTime _Odlazak;

        public string Tip
        {
            get { return _Tip; }
            set
            {
                _Tip = value;
                OnPropChanged("Tip");
            }
        }

        public string Naziv
        {
            get { return _Naziv; }
            set
            {
                _Naziv = value;
                OnPropChanged("Naziv");
            }
        }
        public string Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                OnPropChanged("Age");
            }
        }
        public string Table
        {
            get { return _Table; }
            set
            {
                _Table = value;
                OnPropChanged("Table");
            }
        }
        public DateTime Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                OnPropChanged("Date");
            }
        }
        public DateTime Dolazak
        {
            get { return _Dolazak; }
            set
            {
                _Dolazak = value;
                OnPropChanged("Dolazak");
            }
        }
        public DateTime Odlazak
        {
            get { return _Odlazak; }
            set
            {
                _Odlazak = value;
                OnPropChanged("Odlazak");
            }
        }

        private bool? _CheckPrvi;
        public bool? CheckPrvi
        {
            get { return _CheckPrvi; }
            set
            {
                _CheckPrvi = value;
                OnPropChanged("CheckPrvi");
            }
        }
        private bool? _CheckDrugi;
        public bool? CheckDrugi
        {
            get { return _CheckDrugi; }
            set
            {
                _CheckDrugi = value;
                OnPropChanged("CheckDrugi");
            }
        }
        private bool? _CheckTreci;
        public bool? CheckTreci
        {
            get { return _CheckTreci; }
            set
            {
                _CheckTreci = value;
                OnPropChanged("CheckTreci");
            }
        }

        public ICommand OKKomanda { get; set; }

        public INavigation MyNavigationService { get; set; }
        public ICommand RezKonacnaKomanda { get; set; }
        public ICommand QRKomanda { get; set; }

        public ICommand RezKodKomanda { get; set; }
        public ICommand RezKonacnaKarataKomanda { get; set; }

        public string TypeAcc { get; set; }
        public List<string> TypesOfAccount { get; set; }
        public string Godina { get; set; }
        public List<string> TypesOfGodine { get; set; }
        public string KartaD { get; set; }
        public List<string> TypesOfKarteD{ get; set; }
        public string KartaO { get; set; }
        public List<string> TypesOfKarteO { get; set; }
        public string Soba { get; set; }
        public List<string> TypesOfSobe { get; set; }

        


        public RezervacijaViewModel()
        {
            MyNavigationService = new NavigationService();
            RezKonacnaKomanda = new RelayCommand<object>(rezkonacna, canGo);
            RezKonacnaKarataKomanda = new RelayCommand<object>(rezkonacnakarata, canGo);
            RezKodKomanda = new RelayCommand<object>(rezsmjestaja, canGo);
           // QRKomanda = new RelayCommand<object>(yes, canGo);

            dostupna = false;
            dostupnakarta = false;
            popust = false;
            dostupnismjestaj = true;
        
            Date = DateTime.Now;
            Dolazak = DateTime.Now;
            Odlazak = DateTime.Now;

            TypesOfAccount = new List<string>();
            TypesOfAccount.Add("1");
            TypesOfAccount.Add("2");
            TypesOfAccount.Add("3");
            TypesOfAccount.Add("4");
            TypesOfAccount.Add("5");
            TypesOfAccount.Add("6");
            TypesOfAccount.Add("7");
            TypesOfAccount.Add("8");
            TypesOfAccount.Add("9");
            TypesOfAccount.Add("10");
            TypesOfAccount.Add("11");
            TypesOfAccount.Add("12");
            TypesOfAccount.Add("13");
            TypesOfAccount.Add("14");
            TypesOfAccount.Add("15");
            TypeAcc = "1";
            TypesOfGodine = new List<string>();
            Godina = "< 18";
            TypesOfGodine.Add("< 18");
            TypesOfGodine.Add("18 - 25");
            TypesOfGodine.Add("> 25");
            TypesOfKarteD = new List<string>();
            KartaD = "1";
            TypesOfKarteD.Add("1");
            TypesOfKarteD.Add("2");
            TypesOfKarteD.Add("3");
            TypesOfKarteD.Add("4");
            TypesOfKarteD.Add("5");
            TypesOfKarteD.Add("6");
            TypesOfKarteD.Add("7");
            TypesOfKarteD.Add("8");
            TypesOfKarteD.Add("9");
            TypesOfKarteD.Add("10");
            TypesOfKarteO = new List<string>();
            KartaO = "1";
            TypesOfKarteO.Add("1");
            TypesOfKarteO.Add("2");
            TypesOfKarteO.Add("3");
            TypesOfKarteO.Add("4");
            TypesOfKarteO.Add("5");
            TypesOfKarteO.Add("6");
            TypesOfKarteO.Add("7");
            TypesOfKarteO.Add("8");
            TypesOfKarteO.Add("9");
            TypesOfKarteO.Add("10");
            TypesOfSobe = new List<string>();
            Soba = "Double";
            TypesOfSobe.Add("Double");
            TypesOfSobe.Add("Triple");
            TypesOfSobe.Add("Quadruple");

            nova = new SarajevoGO_.Model.RezervacijaKafica();
            rezkarata = new SarajevoGO_.Model.RezervacijaKarte();
            rezsmjestaj = new SarajevoGO_.Model.RezervacijaSmjestaja();

            CheckPrvi = false;
            CheckDrugi = false;
            CheckTreci = false;
        }


        private async void rezkonacna(object parameter)
        {
            
            // nova.kafic.tip = Tip;
            nova.brojStolova = Convert.ToInt32(TypeAcc);
            nova.vrijemeDolaska = Date;

            //primjer radi krahiranja
            NocniZivot kafic = (NocniZivot)Sistem.listaKategorija.Where(x => x.nazivObjekt == "Drinks").FirstOrDefault();
            nova.kafic = kafic;
            Int32 dan = nova.vrijemeDolaska.Day;
            
            // provjera dostupnosoti
            if (nova.kafic.brojStolova[dan - 1] - nova.brojStolova >= 0) dostupna = true;
            if (Naziv == "")
            {
                var messageDialog1 = new MessageDialog("Popunite sva polja.");
                await messageDialog1.ShowAsync();
            }
            else
            {
                if (dostupna == true)
                {
                    // smanjiti karte, mozda ovako ???
                    // ovako je u funkciji u klasi bilo : brojStolova[dan - 1] -= broj;
                    nova.kafic.brojStolova[dan - 1] = nova.kafic.brojStolova[dan - 1] - nova.brojStolova;

                    var dialog = new MessageDialog("Uspjesno ste rezervisali kafic.");
                    await dialog.ShowAsync();
                    Sistem.listaRezervacijaKafica.Add(nova);
                }
                else
                {
                    var dialog = new MessageDialog("Nazalost nemamo slobodnog mjesta.");
                    await dialog.ShowAsync();
                }
            }
        }
        private async void rezkonacnakarata(object parameter)
        {
            rezkarata.brojDjece = Convert.ToInt32(KartaD);
            rezkarata.brojOdraslih = Convert.ToInt32(KartaO);
            
            //primjer radi krahiranja
            Kultura kultura = (Kultura)Sistem.listaKategorija.Where(x => x.nazivObjekt == "Culture").FirstOrDefault();
            rezkarata.mjesto = kultura;

            //dostupnost
            int dan = rezkarata.vrijemeDolaska.Day;
            if (rezkarata.mjesto.brojMjesta[dan - 1] - rezkarata.brojDjece - rezkarata.brojOdraslih >= 0) dostupnakarta = true;

            //cijena
            double cijena = rezkarata.brojDjece * rezkarata.mjesto.cijenaDjeca + rezkarata.brojOdraslih * rezkarata.mjesto.cijenaOdrasli;

            if (Naziv == "")
            {
                var messageDialog1 = new MessageDialog("Popunite sva polja.");
                await messageDialog1.ShowAsync();
            }
            else
            {
                // rezervisi
                if (dostupnakarta == true)
                {
                    // u klasi Kultura je rezervisi bilo : brojMjesta[dan - 1] -= broj;
                    // rezkarata.mjesto.rezervisiKartu(rezkarata.brojDjece + rezkarata.brojOdraslih, rezkarata.vrijemeDolaska.Day);
                    rezkarata.mjesto.brojMjesta[dan - 1] = rezkarata.mjesto.brojMjesta[dan - 1] - rezkarata.brojDjece + rezkarata.brojOdraslih;
                    var dialog = new MessageDialog("Uspjesno ste rezervisali karte. Cijena je " + cijena + " BAM.");
                    await dialog.ShowAsync();
                    Sistem.listaRezervacijaKarte.Add(rezkarata);

                }
                else
                {
                    var dialog = new MessageDialog("Nazalost nemamo slobodnog mjesta.");
                    await dialog.ShowAsync();
                }
            }
        }


        private async void rezsmjestaja(object parameter)
        {
            rezsmjestaj.dolazak = Dolazak;
            rezsmjestaj.odlazak = Odlazak;
            dostupnismjestaj = true;

            
            //primjer radi krahiranja
            Smjestaj s = (Smjestaj)Sistem.listaKategorija.Where(x => x.nazivObjekt == "Acc").FirstOrDefault();
            rezsmjestaj.smjestaj = s;

            // popust
            if(Godina.Equals("18 - 25"))
            {
                popust = true;
            }
            
            // cijena
            double brojDana = (Odlazak - Dolazak).TotalDays;
            double cijena = rezsmjestaj.smjestaj.cijenaPoNoci;
            if (Soba.Equals("Triple room"))
                cijena += 5;
            else cijena += 10;
            if (CheckPrvi == true) cijena += 5;
            if (CheckDrugi == true) cijena += 5;
            if (CheckTreci == true) cijena += 5;
            double konacno = cijena * brojDana;
            if (popust == true)
                konacno *= 0.9;
            konacno = Math.Round(konacno, 2);

            // dostupnost
            Int32 koef;
            if (Soba.Equals("Double room"))
            {
                koef = 2;
                for (int i = Dolazak.Day - 1; i < Odlazak.Day - 1; i++)
                {
                    if (rezsmjestaj.smjestaj.brojDvokrevetnih[i] - koef < 0)
                        dostupnismjestaj = false;
                }
            }
            else if (Soba.Equals("Triple room"))
            {
                koef = 3;
                for (int i = Dolazak.Day - 1; i < Odlazak.Day - 1; i++)
                {
                    if (rezsmjestaj.smjestaj.brojTrokrevetnih[i] - koef < 0)
                        dostupnismjestaj = false;
                }
            }
            else
            {
                koef = 4;
                for (int i = Dolazak.Day - 1; i < Odlazak.Day - 1; i++)
                {
                    if (rezsmjestaj.smjestaj.brojCetverokrevetnih[i] - koef < 0)
                        dostupnismjestaj = false;
                }
            }

            //rezervacija
            if(dostupnismjestaj == true)
            {
                if (Soba.Equals("Double room"))
                    for (int i = Dolazak.Day - 1; i < Odlazak.Day - 1; i++) // smanjuje broj soba izmedju dva datuma za 1
                        rezsmjestaj.smjestaj.brojDvokrevetnih[i]--;

                else if (Soba.Equals("Triple room"))
                    for (int i = Dolazak.Day - 1; i < Odlazak.Day - 1; i++)
                        rezsmjestaj.smjestaj.brojTrokrevetnih[i]--;
                else
                    for (int i = Dolazak.Day - 1; i < Odlazak.Day - 1; i++)
                        rezsmjestaj.smjestaj.brojCetverokrevetnih[i]--;

                Sistem.listaRezervacijaSmjestaja.Add(rezsmjestaj);
                
               

                if (popust == true)
                {
                    if (Naziv == "")
                    {
                        var messageDialog1 = new MessageDialog("Popunite sva polja.");
                        await messageDialog1.ShowAsync();
                    }
                    else
                    {
                        if (brojDana <= 0 && Naziv != "")
                        {
                            var messageDialog1 = new MessageDialog("Provjerite datum.");
                            await messageDialog1.ShowAsync();
                        }
                        else
                        {
                            var dialog = new MessageDialog("Uspjesno ste rezervisali smjestaj i ostvarili popust. Cijena je " + konacno + " BAM.");
                            await dialog.ShowAsync();
                            MyNavigationService.Navigate(typeof(RezervacijaPotvrda));
                        }
                    }
                    popust = false;
                    dostupnismjestaj = true;

                }
                else
                {
                    if (Naziv == "")
                    {
                        var messageDialog1 = new MessageDialog("Popunite sva polja.");
                        await messageDialog1.ShowAsync();
                    }
                    else
                    {
                        if (brojDana <= 0 && Naziv != "")
                        {
                            var messageDialog1 = new MessageDialog("Provjerite datum.");
                            await messageDialog1.ShowAsync();
                        }
                        else
                        {
                            var dialog = new MessageDialog("Uspjesno ste rezervisali smjestaj. Cijena je " + konacno + " BAM.");
                            await dialog.ShowAsync();
                            MyNavigationService.Navigate(typeof(RezervacijaPotvrda));
                        }
                    }
                    popust = false;
                    dostupnismjestaj = true;
                }

            }
            else
            {
                var dialog = new MessageDialog("Nazalost nemamo slobodnog mjesta.");
                await dialog.ShowAsync();
                popust = false;
                dostupnismjestaj = true;
             
            }

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
