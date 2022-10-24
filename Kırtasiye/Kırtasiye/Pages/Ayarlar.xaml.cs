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
    /// Ayarlar.xaml etkileşim mantığı
    /// </summary>
    public partial class Ayarlar : Page
    {
        public Ayarlar()
        {
            InitializeComponent();
            btngeri.Click += Btngeri_Click;
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
