using Kırtasiye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// StokTakibi.xaml etkileşim mantığı
    /// </summary>
    public partial class StokTakibi : Page
    {
        public StokTakibi()
        {
            InitializeComponent();
            btngeri.Click += Btngeri_Click;
            MiDüzenle.Click += MiDüzenle_Click;
            MiSil.Click += MiSil_Click;
            lbStokTakibi.ItemsSource = Veriler.Urunler;

            TxFiltrele.SelectionChanged += TxFiltrele_SelectionChanged;
            CbFiltrele.SelectionChanged += CbFiltrele_SelectionChanged;
        }

        private void TxFiltrele_SelectionChanged(object sender, RoutedEventArgs e)
        {
            IEnumerable<Urun> Urunler = Veriler.Urunler.AsEnumerable();
            if (string.IsNullOrWhiteSpace(TxFiltrele.Text) == false)
            {
                Urunler = Urunler.Where
                (u => u.UrunAdi.StartsWith(TxFiltrele.Text, StringComparison.CurrentCultureIgnoreCase));
            }
            lbStokTakibi.ItemsSource = Urunler;
        }

        private void CbFiltrele_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IEnumerable<Urun> Urunler = Veriler.Urunler.AsEnumerable();

            switch (CbFiltrele.SelectedIndex)
            {
                case 0:
                    Urunler = Urunler.OrderBy(a => a.UrunAdi);
                    break;

                case 1:
                    Urunler = Urunler.OrderByDescending(a => a.UrunAdi);
                    break;

                case 2:
                    Urunler = Urunler.OrderBy(a => a.UrunAdeti);
                    break;

                case 3:
                    Urunler = Urunler.OrderByDescending(a => a.UrunAdeti);
                    break;

                case 4:
                    Urunler = Urunler.OrderByDescending(a => a.UrunSatisFiyati);
                    break;

                case 5:
                    Urunler = Urunler.OrderBy(a => a.UrunSatisFiyati);
                    break;
            }
            lbStokTakibi.ItemsSource = Urunler;
        }

        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            Urun SeciliUrun = (Urun)lbStokTakibi.SelectedItem;
            if (SeciliUrun != null)
            {
                var cevap = MessageBox.Show("Seçili Ürün Silinsin Mi ?", "Galeri Silme İşlemi", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    Veriler.Urunler.Remove(SeciliUrun);
                    lbStokTakibi.Items.Refresh();
                }
            }
        }

        private void MiDüzenle_Click(object sender, RoutedEventArgs e)
        {
            //Galeri SeçiliGaleri = (Galeri)LbGaleriler.SelectedItem;
            //if (SeçiliGaleri != null)
            //{
            //    NavigationService.Content = new GaleriKayıtPage(SeçiliGaleri);
            //}

            Urun SeciliUrun = (Urun)lbStokTakibi.SelectedItem;
            if (SeciliUrun != null)
            {
                //NavigationService.Content = new UrunGirisi(SeciliUrun);
            }

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
