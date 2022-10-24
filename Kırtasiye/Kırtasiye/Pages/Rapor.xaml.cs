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
    /// Rapor.xaml etkileşim mantığı
    /// </summary>
    public partial class Rapor : Page
    {
        public Rapor()
        {
            InitializeComponent();
            BtnGeri.Click += BtnGeri_Click;

            brdSatis.MouseEnter += (s, e) => brdSatis.BorderBrush = new SolidColorBrush(Colors.Black);
            brdSatis.MouseLeave += (s, e) => brdSatis.BorderBrush = new SolidColorBrush(Colors.Transparent);

            brdGelirGider.MouseEnter += (s, e) => brdGelirGider.BorderBrush = new SolidColorBrush(Colors.Black);
            brdGelirGider.MouseLeave += (s, e) => brdGelirGider.BorderBrush = new SolidColorBrush(Colors.Transparent);

            brdSatis.MouseLeftButtonDown += BrdSatis_MouseLeftButtonDown;
            brdGelirGider.MouseLeftButtonDown += BrdGelirGider_MouseLeftButtonDown;
        }

        private void BrdGelirGider_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            brdSatis.Background = new SolidColorBrush(Colors.LightPink);
            brdGelirGider.Background = new SolidColorBrush(Colors.DarkGray);

            grdGelirGider.Visibility = Visibility.Visible;
            grdSatis.Visibility = Visibility.Hidden;
        }

        private void BrdSatis_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            brdSatis.Background = new SolidColorBrush(Colors.DarkGray);
            brdGelirGider.Background = new SolidColorBrush(Colors.LightPink);

            grdGelirGider.Visibility = Visibility.Hidden;
            grdSatis.Visibility = Visibility.Visible;
        }

        private void BtnGeri_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.Visibility = Visibility.Visible;
            Window win = (Window)this.Parent;
            win.Close();
        }
    }
}
