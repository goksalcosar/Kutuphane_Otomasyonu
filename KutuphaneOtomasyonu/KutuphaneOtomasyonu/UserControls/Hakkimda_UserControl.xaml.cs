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

namespace KutuphaneOtomasyonu.UserControls
{
    /// <summary>
    /// Interaction logic for Hakkimda_UserControl.xaml
    /// </summary>
    public partial class Hakkimda_UserControl : UserControl
    {
        public Hakkimda_UserControl()
        {
            InitializeComponent();           
        }

        private void txt_1_Loaded(object sender, RoutedEventArgs e)
        {
            txt_1.textbox.IsReadOnly = true;
            txt_2.textbox.IsReadOnly = true;
            txt_3.textbox.IsReadOnly = true;
            txt_4.textbox.IsReadOnly = true;
            txt_5.textbox.IsReadOnly = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txt_4.Hint);
            MessageBox.Show("LinkedIn Linki Başarılı Bir Şekilde Kopyalandı", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txt_5.Hint);
            MessageBox.Show("GitHub Linki Başarılı Bir Şekilde Kopyalandı", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
