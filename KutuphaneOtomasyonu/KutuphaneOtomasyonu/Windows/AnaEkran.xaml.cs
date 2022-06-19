using KutuphaneOtomasyonu.Classlar;
using KutuphaneOtomasyonu.UserControls;
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
using System.Windows.Shapes;

namespace KutuphaneOtomasyonu
{
    /// <summary>
    /// Interaction logic for AnaEkran.xaml
    /// </summary>
    public partial class AnaEkran : Window
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        int secim = 0;
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            secim = 1;
            CheckedStatus();            
            uc_cagir.Uc_Ekle(AnaMenu,new UyeUserControl());            
        }

        private void btn_Kitap_Click(object sender, RoutedEventArgs e)
        {
            secim = 2;
            CheckedStatus();
            uc_cagir.Uc_Ekle(AnaMenu, new KitapUserControl());
        }

        private void btn_KitapK_Click(object sender, RoutedEventArgs e)
        {
            secim = 3;
            CheckedStatus();
            uc_cagir.Uc_Ekle(AnaMenu, new KitapK_UserControl());
        }

        private void btn_GecK_Click(object sender, RoutedEventArgs e)
        {
            secim = 4;
            CheckedStatus();
            uc_cagir.Uc_Ekle(AnaMenu, new GecK_UserControl());
        }
        private void btn_Ayarlar_Click(object sender, RoutedEventArgs e)
        {
            secim = 5;
            CheckedStatus();
            uc_cagir.Uc_Ekle(AnaMenu, new Ayarlar_UserControl());
        }

        public void CheckedStatus()
        {
            if (secim == 1)
            {
                btn_Kitap.IsChecked = false;
                btn_KitapK.IsChecked = false;
                btn_Uye.IsChecked = true;
                btn_GecK.IsChecked = false;
                btn_İstatislikler.IsChecked = false;
                btn_Ayarlar.IsChecked = false;
                btn_Hakkında.IsChecked = false;
            }
            else if (secim == 2)
            {
                btn_Kitap.IsChecked = true;
                btn_KitapK.IsChecked = false;
                btn_Uye.IsChecked = false;
                btn_GecK.IsChecked = false;
                btn_İstatislikler.IsChecked = false;
                btn_Ayarlar.IsChecked = false;
                btn_Hakkında.IsChecked = false;
            }
            else if (secim == 3)
            {
                btn_Kitap.IsChecked = false;
                btn_KitapK.IsChecked = true;
                btn_Uye.IsChecked = false;
                btn_GecK.IsChecked = false;
                btn_İstatislikler.IsChecked = false;
                btn_Ayarlar.IsChecked = false;
                btn_Hakkında.IsChecked = false;
            }
            else if (secim == 4)
            {
                btn_Kitap.IsChecked = false;
                btn_KitapK.IsChecked = false;
                btn_Uye.IsChecked = false;
                btn_GecK.IsChecked = true;
                btn_İstatislikler.IsChecked = false;
                btn_Ayarlar.IsChecked = false;
                btn_Hakkında.IsChecked = false;
            }
            else if (secim == 5)
            {
                btn_Kitap.IsChecked = false;
                btn_KitapK.IsChecked = false;
                btn_Uye.IsChecked = false;
                btn_GecK.IsChecked = false;
                btn_İstatislikler.IsChecked = false;
                btn_Ayarlar.IsChecked = true;
                btn_Hakkında.IsChecked = false;
            }
            else if(secim == 6)
            {
                btn_Kitap.IsChecked = false;
                btn_KitapK.IsChecked = false;
                btn_Uye.IsChecked = false;
                btn_GecK.IsChecked = false;
                btn_İstatislikler.IsChecked = true;
                btn_Ayarlar.IsChecked = false;
                btn_Hakkında.IsChecked = false;
            }
            else if(secim == 7)
            {
                btn_Kitap.IsChecked = false;
                btn_KitapK.IsChecked = false;
                btn_Uye.IsChecked = false;
                btn_GecK.IsChecked = false;
                btn_İstatislikler.IsChecked = false;
                btn_Ayarlar.IsChecked = false;
                btn_Hakkında.IsChecked = true;
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_İstatislikler_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lütfen Biraz Bekleyiniz.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);
            secim = 6;
            CheckedStatus();
            uc_cagir.Uc_Ekle(AnaMenu, new İstatisliker_UserControl());
        }

        private void btn_Hakkında_Click(object sender, RoutedEventArgs e)
        {
            secim = 7;
            CheckedStatus();
            uc_cagir.Uc_Ekle(AnaMenu, new Hakkimda_UserControl());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            btn_Hakkında.IsChecked = true;
            btn_Hakkında_Click(sender, e);
        }
    }
}
