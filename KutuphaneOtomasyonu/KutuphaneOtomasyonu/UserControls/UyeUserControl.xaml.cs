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
using MySql.Data.MySqlClient;
using MySql.Data;

namespace KutuphaneOtomasyonu.UserControls
{
    /// <summary>
    /// Interaction logic for UyeUserControl.xaml
    /// </summary>
    public partial class UyeUserControl : UserControl
    {
        string path = DB_Baglanti.Path1;
        public UyeUserControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txt_ID.textbox.IsReadOnly = true;
            txt_TcNo.textbox.MaxLength = 11;
            txt_AdSoyad.textbox.TextChanged += Textbox_TextChanged;
            txt_Yas.textbox.TextChanged += Textbox_TextChanged1;
            txt_TcNo.textbox.TextChanged += Textbox_TextChanged2;
            txt_TelefonNo.textbox.TextChanged += Textbox_TextChanged6;
            txt_Adres.textbox.TextChanged += Textbox_TextChanged7;
            txt_Eposta.textbox.TextChanged += Textbox_TextChanged8;
        }

        private void Textbox_TextChanged8(object sender, TextChangedEventArgs e)
        {
            txt_Eposta.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged7(object sender, TextChangedEventArgs e)
        {
            txt_Adres.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged6(object sender, TextChangedEventArgs e)
        {
            txt_TelefonNo.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            txt_TcNo.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged1(object sender, TextChangedEventArgs e)
        {
            txt_Yas.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_AdSoyad.textbox.BorderBrush = btn.Background;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_AdSoyad.textbox.Text) && !string.IsNullOrEmpty(txt_Yas.textbox.Text) && !string.IsNullOrEmpty(txt_TcNo.textbox.Text) && !string.IsNullOrEmpty(txt_TelefonNo.textbox.Text) && !string.IsNullOrEmpty(txt_Adres.textbox.Text) && !string.IsNullOrEmpty(txt_Eposta.textbox.Text))
            {
                using (MySqlConnection con = new MySqlConnection(path))
                {
                    try
                    {
                        con.Open();

                        MySqlCommand insert = new MySqlCommand("insert into ogrenci(IsimSoyisim,Yas,TcNo,TelefonNo,Adres,Eposta)values(@isim_soyisim,@yas,@tc_no,@telefon_no,@adres,@eposta)", con);
                        insert.Parameters.AddWithValue("@isim_soyisim", txt_AdSoyad.textbox.Text);
                        insert.Parameters.AddWithValue("@yas", txt_Yas.textbox.Text);
                        insert.Parameters.AddWithValue("@tc_no", txt_TcNo.textbox.Text);
                        insert.Parameters.AddWithValue("@telefon_no", txt_TelefonNo.textbox.Text);
                        insert.Parameters.AddWithValue("@adres", txt_Adres.textbox.Text);
                        insert.Parameters.AddWithValue("@eposta", txt_Eposta.textbox.Text);

                        insert.ExecuteNonQuery();

                        MessageBox.Show("Öğrenci Kayıdınız Başarılı Bir Şekilde Veri Tabanına Eklenmiştir.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                        con.Close();

                        DataGridDoldur.Ogrenci_GridDoldur(Dtg_Liste);
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
                txt_AdSoyad.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_Yas.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_TcNo.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_TelefonNo.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_Adres.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_Eposta.textbox.BorderBrush = new SolidColorBrush(Colors.Red);

            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataGridDoldur.Ogrenci_GridDoldur(Dtg_Liste);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Sil_ID.textbox.Text))
            {
                txt_Sil_ID.textbox.BorderBrush = btn.Background;
                using (MySqlConnection con = new MySqlConnection(path))
                {
                    try
                    {
                        con.Open();

                        MySqlCommand delete = new MySqlCommand("delete from ogrenci where ID='" + txt_Sil_ID.textbox.Text + "'", con);
                        delete.ExecuteNonQuery();

                        MessageBox.Show("Öğrenci Veri Tabanından Silinmiştir.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                        con.Close();

                        DataGridDoldur.Ogrenci_GridDoldur(Dtg_Liste);
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
                txt_Sil_ID.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Guncelle_ID.textbox.Text))
            {
                txt_Guncelle_ID.textbox.BorderBrush = btn.Background;
                using (MySqlConnection con = new MySqlConnection(path))
                {
                    try
                    {
                        con.Open();

                        MySqlCommand update = new MySqlCommand("update ogrenci set ID='" + int.Parse(txt_ID.textbox.Text) + "',IsimSoyisim='" + txt_AdSoyad.textbox.Text + "',Yas='" + txt_Yas.textbox.Text + "',TcNo='" + txt_TcNo.textbox.Text + "',TelefonNo='" + txt_TelefonNo.textbox.Text + "',Adres='" + txt_Adres.textbox.Text + "',Eposta='" + txt_Eposta.textbox.Text + "' where ID='" + txt_Guncelle_ID.textbox.Text + "'", con);
                        update.ExecuteNonQuery();

                        MessageBox.Show("Öğrenci Başarılı Bir Şekilde Güncellenmiştir.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                        con.Close();

                        DataGridDoldur.Ogrenci_GridDoldur(Dtg_Liste);
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
                txt_Guncelle_ID.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            
        }

        private void Dtg_Liste_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string ogrTc = ((TextBlock)Dtg_Liste.Columns[3].GetCellContent(Dtg_Liste.SelectedItem)).Text;
            Veriler_TextBox_Gonder(ogrTc);
        }

        public void Veriler_TextBox_Gonder(string tc)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    con.Open();

                    MySqlCommand select = new MySqlCommand("select*from ogrenci where TcNo='" + tc + "'", con);
                    MySqlDataReader rdr = select.ExecuteReader();
                    while (rdr.Read())
                    {
                        txt_ID.textbox.Text = rdr["ID"].ToString();
                        txt_AdSoyad.textbox.Text = rdr["IsimSoyisim"].ToString();
                        txt_Yas.textbox.Text = rdr["Yas"].ToString();
                        txt_TcNo.textbox.Text = rdr["TcnO"].ToString();
                        txt_TelefonNo.textbox.Text = rdr["TelefonNo"].ToString();
                        txt_Adres.textbox.Text = rdr["Adres"].ToString();
                        txt_Eposta.textbox.Text = rdr["Eposta"].ToString();
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            txt_ID.textbox.Text = "";
            txt_AdSoyad.textbox.Text = "";
            txt_Yas.textbox.Text = "";
            txt_TcNo.textbox.Text = "";
            txt_TelefonNo.textbox.Text = "";
            txt_Adres.textbox.Text = "";
            txt_Eposta.textbox.Text = "";
            txt_Sil_ID.textbox.Text = "";
            txt_Guncelle_ID.textbox.Text = "";
        }
    }
}
