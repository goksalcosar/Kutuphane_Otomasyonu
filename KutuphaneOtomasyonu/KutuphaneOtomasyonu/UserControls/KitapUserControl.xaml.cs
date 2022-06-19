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
    /// Interaction logic for KitapUserControl.xaml
    /// </summary>
    public partial class KitapUserControl : UserControl
    {
        public KitapUserControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txt_K_Barkod.textbox.TextChanged += Textbox_TextChanged;
            txt_K_Ad.textbox.TextChanged += Textbox_TextChanged1;
            txt_Yazar.textbox.TextChanged += Textbox_TextChanged2;
            txt_K_YayinEvi.textbox.TextChanged += Textbox_TextChanged3;
            txt_K_Sayfa.textbox.TextChanged += Textbox_TextChanged4;
            txt_K_Turu.textbox.TextChanged += Textbox_TextChanged5;
            txt_K_Stok.textbox.TextChanged += Textbox_TextChanged6;
            txt_K_Raf.textbox.TextChanged += Textbox_TextChanged7;
            txt_K_Aciklama.textbox.TextChanged += Textbox_TextChanged8;
        }

        private void Textbox_TextChanged8(object sender, TextChangedEventArgs e)
        {
            txt_K_Aciklama.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged7(object sender, TextChangedEventArgs e)
        {
            txt_K_Raf.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged6(object sender, TextChangedEventArgs e)
        {
            txt_K_Stok.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged5(object sender, TextChangedEventArgs e)
        {
            txt_K_Turu.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged4(object sender, TextChangedEventArgs e)
        {
            txt_K_Sayfa.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged3(object sender, TextChangedEventArgs e)
        {
            txt_K_YayinEvi.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            txt_Yazar.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged1(object sender, TextChangedEventArgs e)
        {
            txt_K_Ad.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_K_Barkod.textbox.BorderBrush = btn.Background;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_K_Barkod.textbox.Text) && !string.IsNullOrEmpty(txt_K_Ad.textbox.Text) && !string.IsNullOrEmpty(txt_Yazar.textbox.Text) && !string.IsNullOrEmpty(txt_K_YayinEvi.textbox.Text) && !string.IsNullOrEmpty(txt_K_Sayfa.textbox.Text) && !string.IsNullOrEmpty(txt_K_Turu.textbox.Text) && !string.IsNullOrEmpty(txt_K_Stok.textbox.Text) && !string.IsNullOrEmpty(txt_K_Raf.textbox.Text) && !string.IsNullOrEmpty(txt_K_Aciklama.textbox.Text))
            {
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    try
                    {
                        con.Open();

                        MySqlCommand insert = new MySqlCommand("insert into kitaplar(BarkodNo,KitapAdi,Yazar,YayinEvi,SayfaSayisi,Turu,StokSayisi,RafNo,Aciklama)values(@BarkodNo,@KitapAdi,@Yazar,@YayinEvi,@SayfaSayisi,@Turu,@StokSayisi,@RafNo,@Aciklama)", con);
                        insert.Parameters.AddWithValue("@BarkodNo", txt_K_Barkod.textbox.Text);
                        insert.Parameters.AddWithValue("@KitapAdi", txt_K_Ad.textbox.Text);
                        insert.Parameters.AddWithValue("@Yazar", txt_Yazar.textbox.Text);
                        insert.Parameters.AddWithValue("@YayinEvi", txt_K_YayinEvi.textbox.Text);
                        insert.Parameters.AddWithValue("@SayfaSayisi", txt_K_Sayfa.textbox.Text);
                        insert.Parameters.AddWithValue("@Turu", txt_K_Turu.textbox.Text);
                        insert.Parameters.AddWithValue("@StokSayisi", txt_K_Stok.textbox.Text);
                        insert.Parameters.AddWithValue("@RafNo", txt_K_Raf.textbox.Text);
                        insert.Parameters.AddWithValue("@Aciklama", txt_K_Aciklama.textbox.Text);
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Kitap Kayıdınız Başarılı Bir Şekilde Veri Tabanına Eklenmiştir.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                        con.Close();

                        DataGridDoldur.Kitap_GridDoldur(Dtg_Liste);
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
                txt_K_Barkod.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Ad.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_Yazar.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_YayinEvi.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Sayfa.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Turu.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Stok.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Raf.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Aciklama.textbox.BorderBrush = new SolidColorBrush(Colors.Red);

            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_G_ID.textbox.Text))
            {
                txt_G_ID.textbox.BorderBrush = btn.Background;
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    try
                    {
                        con.Open();

                        MySqlCommand update = new MySqlCommand("update kitaplar set BarkodNo=@BarkodNo,KitapAdi=@KitapAdi,Yazar=@Yazar,YayinEvi=@YayinEvi,SayfaSayisi=@SayfaSayisi,Turu=@Turu,StokSayisi=@StokSayisi,RafNo=@RafNo,Aciklama=@Aciklama where ID='" + txt_G_ID.textbox.Text + "'", con);
                        update.Parameters.AddWithValue("@BarkodNo", txt_K_Barkod.textbox.Text);
                        update.Parameters.AddWithValue("@KitapAdi", txt_K_Ad.textbox.Text);
                        update.Parameters.AddWithValue("@Yazar", txt_Yazar.textbox.Text);
                        update.Parameters.AddWithValue("@YayinEvi", txt_K_YayinEvi.textbox.Text);
                        update.Parameters.AddWithValue("@SayfaSayisi", txt_K_Sayfa.textbox.Text);
                        update.Parameters.AddWithValue("@Turu", txt_K_Turu.textbox.Text);
                        update.Parameters.AddWithValue("@StokSayisi", txt_K_Stok.textbox.Text);
                        update.Parameters.AddWithValue("@RafNo", txt_K_Raf.textbox.Text);
                        update.Parameters.AddWithValue("@Aciklama", txt_K_Aciklama.textbox.Text);
                        update.ExecuteNonQuery();
                        MessageBox.Show("Kitap Kayınız Başarılı Bir Şekilde Güncellenmiştir.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                        con.Close();

                        DataGridDoldur.Kitap_GridDoldur(Dtg_Liste);
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
                txt_G_ID.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_S_ID.textbox.Text))
            {
                txt_S_ID.textbox.BorderBrush = btn.Background;
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    try
                    {
                        con.Open();

                        MySqlCommand update = new MySqlCommand("delete from kitaplar where ID='" + txt_S_ID.textbox.Text + "'", con);
                        update.ExecuteNonQuery();
                        MessageBox.Show(txt_S_ID.textbox.Text + " No'lu Kitap Bilginiz Başarılı Bir Şekilde Veri Tabanından Kaldırılmıştır.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                        con.Close();

                        DataGridDoldur.Kitap_GridDoldur(Dtg_Liste);
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
                txt_S_ID.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataGridDoldur.Kitap_GridDoldur(Dtg_Liste);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Temilze();
        }

        public void Temilze()
        {
            txt_K_ID.textbox.Text = "";
            txt_K_Barkod.textbox.Text = "";
            txt_K_Ad.textbox.Text = "";
            txt_Yazar.textbox.Text = "";
            txt_K_YayinEvi.textbox.Text = "";
            txt_K_Sayfa.textbox.Text = "";
            txt_K_Turu.textbox.Text = "";
            txt_K_Stok.textbox.Text = "";
            txt_K_Raf.textbox.Text = "";
            txt_K_Aciklama.textbox.Text = "";
            txt_G_ID.textbox.Text = "";
            txt_S_ID.textbox.Text = "";
        }

        private void Dtg_Liste_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string barkod = ((TextBlock)Dtg_Liste.Columns[1].GetCellContent(Dtg_Liste.SelectedItem)).Text;
            Veriler_TextBox_Gonder(barkod);
        }

        public void Veriler_TextBox_Gonder(string barkod)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    con.Open();

                    MySqlCommand select = new MySqlCommand("select*from kitaplar where BarkodNo='" + barkod + "'", con);
                    MySqlDataReader rdr = select.ExecuteReader();
                    while (rdr.Read())
                    {
                        txt_K_ID.textbox.Text = rdr["ID"].ToString();
                        txt_K_Barkod.textbox.Text = rdr["BarkodNo"].ToString();
                        txt_K_Ad.textbox.Text = rdr["KitapAdi"].ToString();
                        txt_Yazar.textbox.Text = rdr["Yazar"].ToString();
                        txt_K_YayinEvi.textbox.Text = rdr["YayinEvi"].ToString();
                        txt_K_Sayfa.textbox.Text = rdr["SayfaSayisi"].ToString();
                        txt_K_Turu.textbox.Text = rdr["Turu"].ToString();
                        txt_K_Stok.textbox.Text = rdr["StokSayisi"].ToString();
                        txt_K_Raf.textbox.Text = rdr["RafNo"].ToString();
                        txt_K_Aciklama.textbox.Text = rdr["Aciklama"].ToString();
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }
    }
}
