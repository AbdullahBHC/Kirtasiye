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
    /// SatisIslemi.xaml etkileşim mantığı
    /// </summary>
    public partial class SatisIslemi : Page
    {
        Urun YeniUrun;
        public SatisIslemi()
        {
            InitializeComponent();
            BtnGeri.Click += BtnGeri_Click;
            MiSil.Click += MiSil_Click;

            btnTemizle.Click += (s,e) => LbSatislar.Items.Clear();

            btnUrunKaydet.Click += BtnUrunKaydet_Click; 

            txFiltrele.TextChanged += TxFiltrele_TextChanged;
            cbFiltreler.SelectionChanged += CbFiltreler_SelectionChanged;

            BtnKursunKalem.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[0]);
            BtnSilgi.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[1]);
            BtnDefter.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[2]);
            BtnKitap.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[3]);

            BtnCanta.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[4]);
            BtnCetvel.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[5]);
            BtnMakas.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[6]);
            BtnPrintYapistirici.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[7]);

            BtnFbPastelBoya.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[8]);
            BtnFbKuruBoya.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[9]);
            BtnFbSuluBoya.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[10]);
            BtnKeceliBoya.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[11]);

            BtnSuluk.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[12]);
            Btn07Uc.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[13]);
            BtnBeslenmeCantasi.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[14]);
            BtnFosforluKalem.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[15]);

            BtnKalemKutusu.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[16]);
            BtnBuroBandi.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[17]);
            BtnKalemtiras.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[18]);
            BtnA4.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[19]);

            BtnFbKirmiziKalem.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[20]);
            BtnTahtaKalemi.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[21]);
            BtnFonKartonu.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[22]);
            BtnFbParmakBoya.Click += (s, e) => LbSatislar.Items.Add(Veriler.Urunler[23]);
        }

        private void BtnUrunKaydet_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(txUrunFiyat.Text, out decimal urunfiyat);
             YeniUrun=new Urun() { 
            UrunAdi = txUrunAd.Text,
            UrunSatisFiyati = urunfiyat
           
             };
            LbSatislar.Items.Add(YeniUrun);
        }

        private void CbFiltreler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void TxFiltrele_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MiSil_Click(object sender, RoutedEventArgs e)
        {
            Urun SeciliUrun = (Urun)LbSatislar.SelectedItem;
            if (SeciliUrun != null)
            {
                var cevap = MessageBox.Show("Seçili Ürün Silinsin Mi ?", "Galeri Silme İşlemi", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (cevap == MessageBoxResult.Yes)
                {
                    LbSatislar.Items.Remove(SeciliUrun);
                }
            }        }

        private void BtnGeri_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.Visibility = Visibility.Visible;
            Window win = (Window)this.Parent;
            win.Close();
        }
    }
}
