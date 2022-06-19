using KutuphaneOtomasyonu.DB_Islem;
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

namespace KutuphaneOtomasyonu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                this.WindowState = WindowState.Normal;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Parametreler prm = new Parametreler();
            LoginIslem lgl = new LoginIslem();
            AnaEkran Aekran = new AnaEkran();
            prm.KullaniciAdi1 = txt_KullaniciAdi.textbox.Text;
            prm.Sifre1 = txt_Sifre.textbox.Text;
            var sonuc = lgl.Select(prm);
            MessageBox.Show(sonuc, "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);
            if (sonuc == "Başarılı")
            {
                this.Hide();
                Aekran.Show();
            }               

        }
    }
}
