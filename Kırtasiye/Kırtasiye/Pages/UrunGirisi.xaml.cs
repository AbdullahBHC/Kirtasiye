using Kırtasiye.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kırtasiye.Pages
{
    /// <summary>
    /// UrunGirisi.xaml etkileşim mantığı
    /// </summary>
    public partial class UrunGirisi : Page
    {
        Urun Urun;

        public UrunGirisi()
        {
            InitializeComponent();
            CbKategori.ItemsSource = Veriler.Kategoriler;
            btngeri.Click += Btngeri_Click;
            BtnKaydet.Click += BtnKaydet_Click;
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(TxUrunAlisFiyati.Text, out decimal UrunAlisFiyati);
            decimal.TryParse(TxUrunSatisFiyati.Text, out decimal UrunSatisFiyati);
            int.TryParse(TxUrunAdet.Text, out int UrunAdet);
            if (Urun == null)
            {
                Urun = new Urun()
                {
                    UrunAdi = TxUrunAdi.Text,
                    UrunAlisFiyati = UrunAlisFiyati,
                    UrunSatisFiyati = UrunSatisFiyati,
                    UrunAdeti = UrunAdet,
                    UrunKategorisi = (Kategori)CbKategori.SelectedItem
                };
                Veriler.Urunler.Add(Urun);
            }
            else
            {
                Urun.UrunAdi = TxUrunAdi.Text;
                Urun.UrunAlisFiyati = UrunAlisFiyati;
                Urun.UrunSatisFiyati = UrunSatisFiyati;
                Urun.UrunAdeti = UrunAdet;
                Urun.UrunKategorisi = (Kategori)CbKategori.SelectedItem;
            }
            NavigationService.Content = new StokTakibi();
        }

        private void Btngeri_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.Visibility = Visibility.Visible;
            Window win = (Window)this.Parent;
            win.Close();
        }
    }
}
