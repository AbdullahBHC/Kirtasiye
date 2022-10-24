using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kırtasiye
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grdSatis.MouseLeftButtonDown += GrdSatis_MouseLeftButtonDown;
            grdRapor.MouseLeftButtonDown += GrdRapor_MouseLeftButtonDown;
            grdStokTakibi.MouseLeftButtonDown += GrdStokTakibi_MouseLeftButtonDown;
            grdUrunGiris.MouseLeftButtonDown += GrdUrunGiris_MouseLeftButtonDown;
            grdAyarlar.MouseLeftButtonDown += GrdAyarlar_MouseLeftButtonDown;
            grdCikis.MouseLeftButtonDown += GrdCikis_MouseLeftButtonDown;
        }

        #region sayfalara gidiş
        private void GrdAyarlar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Pages/Ayarlar.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void GrdUrunGiris_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Pages/UrunGirisi.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void GrdStokTakibi_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Pages/StokTakibi.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void GrdRapor_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Pages/Rapor.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void GrdSatis_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Pages/SatisIslemi.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void GrdCikis_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion   


    }
}
