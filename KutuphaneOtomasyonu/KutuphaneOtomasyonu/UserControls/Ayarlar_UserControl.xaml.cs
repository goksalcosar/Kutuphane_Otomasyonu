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
using MySql.Data.MySqlClient;
using MySql.Data;
using KutuphaneOtomasyonu.DB_Islem;

namespace KutuphaneOtomasyonu.UserControls
{
    public partial class Ayarlar_UserControl : UserControl
    {
        public Ayarlar_UserControl()
        {
            InitializeComponent();
            txt_Ekleme_Kullanici_Adi.textbox.TextChanged += Textbox_TextChanged;
            txt_Ekleme_Sifre.textbox.TextChanged += Textbox_TextChanged1;
            txt_Ekleme_Sifre_Tekrar.textbox.TextChanged += Textbox_TextChanged2;
            txt_Ekleme_Sil_ID.textbox.TextChanged += Textbox_TextChanged3;
        }

        private void Textbox_TextChanged3(object sender, TextChangedEventArgs e)
        {
            txt_Ekleme_Sil_ID.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            txt_Ekleme_Sifre_Tekrar.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged1(object sender, TextChangedEventArgs e)
        {
            txt_Ekleme_Sifre.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_Ekleme_Kullanici_Adi.textbox.BorderBrush = btn.Background;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Sifre.textbox.Text == txt_SifreTekrar.textbox.Text)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                    {
                        con.Open();

                        MySqlCommand update = new MySqlCommand("update loginpage set KullaniciAdi='" + txt_KullanicAdi.textbox.Text + "',Sifre='" + txt_Sifre.textbox.Text + "' where KullaniciAdi='" + txt_Arama.textbox.Text + "'", con);
                        update.ExecuteNonQuery();
                        MessageBox.Show("Güncelleme Başarılı", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Hata! Şifreniz Şifre Tekrar İle Uyuşmuyor!", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Ekleme_Kullanici_Adi.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Ekleme_Sifre.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Ekleme_Sifre_Tekrar.textbox.Text))
            {
                if (txt_Ekleme_Sifre_Tekrar.textbox.Text == txt_Ekleme_Sifre.textbox.Text)
                {
                    using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                    {
                        try
                        {
                            con.Open();

                            MySqlCommand insert = new MySqlCommand("insert into loginpage(KullaniciAdi,Sifre)values(@KullaniciAdi,@Sifre)", con);
                            insert.Parameters.AddWithValue("@KullaniciAdi", txt_Ekleme_Kullanici_Adi.textbox.Text);
                            insert.Parameters.AddWithValue("@Sifre", txt_Ekleme_Sifre.textbox.Text);

                            insert.ExecuteNonQuery();

                            MessageBox.Show("Kullanıc Kayıdınız Başarılı Bir Şekilde Veri Tabanına Eklenmiştir.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                            con.Close();

                            DataGridDoldur.Kullanici_GirdDoldur(Dtg_Liste);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                            con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hata! Şifre Bilgileri Uyuşmuyor.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Hata! Lütfen Gerekli Alanları Doldulurunuz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_Ekleme_Kullanici_Adi.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_Ekleme_Sifre.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_Ekleme_Sifre_Tekrar.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Ekleme_Sil_ID.textbox.Text))
            {
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    try
                    {
                        con.Open();

                        MySqlCommand delete = new MySqlCommand("delete from loginpage where ID='"+ txt_Ekleme_Sil_ID.textbox.Text +"'", con);
                        delete.ExecuteNonQuery();

                        MessageBox.Show("Kullanıc Kayıdınız Başarılı Bir Şekilde Silinmiştir.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                        con.Close();

                        DataGridDoldur.Kullanici_GirdDoldur(Dtg_Liste);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                        con.Close();
                    }


                }
            }
            else
            {
                MessageBox.Show("Hata! Lütfen Gerekli Alanları Doldulurunuz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_Ekleme_Sil_ID.textbox.BorderBrush = new SolidColorBrush(Colors.Red);                
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DataGridDoldur.Kullanici_GirdDoldur(Dtg_Liste);
        }
    }
}
