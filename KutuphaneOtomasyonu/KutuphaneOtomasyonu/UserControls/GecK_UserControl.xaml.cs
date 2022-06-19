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
using System.Globalization;
using System.Data;

namespace KutuphaneOtomasyonu.UserControls
{
    public partial class GecK_UserControl : UserControl
    {
        public GecK_UserControl()
        {
            InitializeComponent();
            txt_TcNo.textbox.MaxLength = 11;
            txt_TcNo.textbox.TextChanged += Textbox_TextChanged;
            txt_K_Barkod.textbox.TextChanged += Textbox_TextChanged1;
            txt_ID.textbox.TextChanged += Textbox_TextChanged2;
            txt_AdSoyad.textbox.TextChanged += Textbox_TextChanged3;
            txt_Yas.textbox.TextChanged += Textbox_TextChanged4;
            txt_Adres.textbox.TextChanged += Textbox_TextChanged5;
            txt_Eposta.textbox.TextChanged += Textbox_TextChanged6;
            txt_TelefonNo.textbox.TextChanged += Textbox_TextChanged7;
            txt_K_ID.textbox.TextChanged += Textbox_TextChanged8;
            txt_K_Ad.textbox.TextChanged += Textbox_TextChanged9;
            txt_Yazar.textbox.TextChanged += Textbox_TextChanged10;
            txt_K_YayinEvi.textbox.TextChanged += Textbox_TextChanged11;
            txt_K_Sayfa.textbox.TextChanged += Textbox_TextChanged12;
            txt_K_Turu.textbox.TextChanged += Textbox_TextChanged13;
            txt_K_Raf.textbox.TextChanged += Textbox_TextChanged14;
            txt_K_Aciklama.textbox.TextChanged += Textbox_TextChanged15;
            txt_VerilisTarihi.SelectedDateChanged += Txt_VerilisTarihi_SelectedDateChanged;
            txt_TeslimTarihi.SelectedDateChanged += Txt_TeslimTarihi_SelectedDateChanged;
            cmb_Kitap_Durum.combobox.SelectionChanged += Combobox_SelectionChanged;
            cmb_Teslim_Durum.combobox.SelectionChanged += Combobox_SelectionChanged1;
            txt_TeslimAlimTarihi.SelectedDateChanged += Txt_TeslimAlimTarihi_SelectedDateChanged;
        }

        #region Chnageds Events

        private void Txt_TeslimAlimTarihi_SelectedDateChanged(object? sender, SelectionChangedEventArgs e)
        {
            txt_TeslimAlimTarihi.BorderBrush = btn.Background;
        }

        private void Combobox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            cmb_Teslim_Durum.combobox.BorderBrush = btn.Background;
        }

        private void Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmb_Kitap_Durum.combobox.BorderBrush = btn.Background;
        }

        private void Txt_TeslimTarihi_SelectedDateChanged(object? sender, SelectionChangedEventArgs e)
        {
            txt_TeslimTarihi.BorderBrush = btn.Background;
        }

        private void Txt_VerilisTarihi_SelectedDateChanged(object? sender, SelectionChangedEventArgs e)
        {
            txt_VerilisTarihi.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged15(object sender, TextChangedEventArgs e)
        {
            txt_K_Aciklama.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged14(object sender, TextChangedEventArgs e)
        {
            txt_K_Raf.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged13(object sender, TextChangedEventArgs e)
        {
            txt_K_Turu.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged12(object sender, TextChangedEventArgs e)
        {
            txt_K_Sayfa.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged11(object sender, TextChangedEventArgs e)
        {
            txt_K_YayinEvi.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged10(object sender, TextChangedEventArgs e)
        {
            txt_Yazar.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged9(object sender, TextChangedEventArgs e)
        {
            txt_K_Ad.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged8(object sender, TextChangedEventArgs e)
        {
            txt_K_ID.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged7(object sender, TextChangedEventArgs e)
        {
            txt_TelefonNo.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged6(object sender, TextChangedEventArgs e)
        {
            txt_Eposta.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged5(object sender, TextChangedEventArgs e)
        {
            txt_Adres.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged4(object sender, TextChangedEventArgs e)
        {
            txt_Yas.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged3(object sender, TextChangedEventArgs e)
        {
            txt_AdSoyad.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            txt_ID.textbox.BorderBrush = btn.Background;
        }

        #endregion

        private void Textbox_TextChanged1(object sender, TextChangedEventArgs e)
        {
            txt_K_Barkod.textbox.BorderBrush = btn.Background;
            try
            {
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    MySqlCommand select = DB_Querys.ogrLike("kiralanan_kitaplar", "ktpBarkod", txt_K_Barkod.textbox.Text, con);
                    con.Open();
                    MySqlDataReader rdr = select.ExecuteReader();
                    while (rdr.Read())
                    {
                        txt_K_ID.textbox.Text = rdr["ktpID"].ToString();
                        txt_K_Ad.textbox.Text = rdr["ktpKitapAdi"].ToString();
                        txt_Yazar.textbox.Text = rdr["ktpYazar"].ToString();
                        txt_K_YayinEvi.textbox.Text = rdr["ktpYayinEvi"].ToString();
                        txt_K_Sayfa.textbox.Text = rdr["ktpSayfa"].ToString();
                        txt_K_Turu.textbox.Text = rdr["ktpTuru"].ToString();
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

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_TcNo.textbox.BorderBrush = btn.Background;
            try
            {
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    MySqlCommand select = DB_Querys.ogrLike("kiralanan_kitaplar", "ogrTc", txt_TcNo.textbox.Text, con);
                    con.Open();
                    MySqlDataReader rdr = select.ExecuteReader();
                    while (rdr.Read())
                    {
                        txt_ID.textbox.Text = rdr["ogrID"].ToString();
                        txt_AdSoyad.textbox.Text = rdr["ogrIsimSoyisim"].ToString();
                        txt_Yas.textbox.Text = rdr["ogrYas"].ToString();
                        txt_Adres.textbox.Text = rdr["ogrAdres"].ToString();
                        txt_Eposta.textbox.Text = rdr["ogrEposta"].ToString();
                        txt_TelefonNo.textbox.Text = rdr["ogrTelefon"].ToString();
                        txt_VerilisTarihi.Text = rdr["VerilisZamani"].ToString();
                        txt_TeslimTarihi.Text = rdr["TeslimZamani"].ToString();

                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataGridDoldur.EmanetListesi_GridDoldur(Dtg_Liste, 0);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> KitapDurumu = new List<string>();
            KitapDurumu.Add("Hasarlı");
            KitapDurumu.Add("Hasarsız");
            foreach (var item in KitapDurumu)
            {
                cmb_Kitap_Durum.combobox.Items.Add(item);
            }

            List<string> TeslimDurum = new List<string>();
            TeslimDurum.Add("Teslim Alındı");
            TeslimDurum.Add("Teslim Alınmadı");
            foreach (var item2 in TeslimDurum)
            {
                cmb_Teslim_Durum.combobox.Items.Add(item2);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ID.textbox.Text) && !string.IsNullOrEmpty(txt_AdSoyad.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Yas.textbox.Text) && !string.IsNullOrEmpty(txt_TcNo.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Adres.textbox.Text) && !string.IsNullOrEmpty(txt_Eposta.textbox.Text) &&
                !string.IsNullOrEmpty(txt_TelefonNo.textbox.Text) && !string.IsNullOrEmpty(txt_K_ID.textbox.Text) &&
                !string.IsNullOrEmpty(txt_K_Barkod.textbox.Text) && !string.IsNullOrEmpty(txt_K_Ad.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Yazar.textbox.Text) && !string.IsNullOrEmpty(txt_K_YayinEvi.textbox.Text) &&
                !string.IsNullOrEmpty(txt_K_Sayfa.textbox.Text) && !string.IsNullOrEmpty(txt_K_Turu.textbox.Text) &&
                !string.IsNullOrEmpty(txt_K_Raf.textbox.Text) && !string.IsNullOrEmpty(txt_K_Aciklama.textbox.Text) &&
                !string.IsNullOrEmpty(txt_VerilisTarihi.Text) && !string.IsNullOrEmpty(txt_TeslimTarihi.Text) &&
                !string.IsNullOrEmpty(cmb_Kitap_Durum.combobox.Text) && !string.IsNullOrEmpty(cmb_Teslim_Durum.combobox.Text) &&
                !string.IsNullOrEmpty(txt_TeslimAlimTarihi.Text))
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                    {

                        bool varMi = DB_Querys.Kiralanan_Kitap_Sorgusu(con, txt_K_Barkod.textbox.Text, txt_TcNo.textbox.Text);

                        if (varMi == true)
                        {
                            con.Open();

                            MySqlCommand update = new MySqlCommand("update kiralanan_kitaplar set KitapDurumu='" + cmb_Kitap_Durum.combobox.SelectedItem + "',TeslimDurumu='" + cmb_Teslim_Durum.combobox.SelectedItem + "',TeslimAlimTarihi='" + txt_TeslimAlimTarihi.Text + "' where ogrTc='" + txt_TcNo.textbox.Text + "' AND ktpBarkod='" + txt_K_Barkod.textbox.Text + "'", con);
                            update.ExecuteNonQuery();
                            MessageBox.Show("Kitap Başarılı Bir Şekilde Teslim Alındı.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);
                            DataGridDoldur.EmanetListesi_GridDoldur(Dtg_Liste, 1);
                            con.Close();

                            int stok_sayisi = DB_Querys.ktpStok_Sayisi(con, txt_K_Barkod.textbox.Text);
                            DB_Querys.ktp_Stok_Sayisi_Update_Topla(con, txt_K_Barkod.textbox.Text, stok_sayisi + 1);
                            Temizlik();
                        }
                        else
                        {
                            MessageBox.Show("Hata! Aradığınız " + txt_TcNo.textbox.Text + " TC No'lu Öğrenci " + txt_K_Barkod.textbox.Text + " Barkod No'lu Kitapı Kiralamamıştır!", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
            else
            {
                MessageBox.Show("Hata! Lütfen Gerekli Alanları Doldulurunuz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_ID.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_AdSoyad.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_Yas.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_TcNo.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_Adres.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_Eposta.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_TelefonNo.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_ID.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Barkod.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Ad.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_Yazar.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_YayinEvi.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Sayfa.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Turu.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Raf.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_K_Aciklama.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_VerilisTarihi.BorderBrush = new SolidColorBrush(Colors.Red);
                txt_TeslimTarihi.BorderBrush = new SolidColorBrush(Colors.Red);
                cmb_Kitap_Durum.textblock.Foreground = new SolidColorBrush(Colors.Red);
                cmb_Teslim_Durum.textblock.Foreground = new SolidColorBrush(Colors.Red);
                txt_TeslimAlimTarihi.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataGridDoldur.EmanetListesi_GridDoldur(Dtg_Liste, 1);
        }

        private void Dtg_Liste_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string ogrTC = ((TextBlock)Dtg_Liste.Columns[4].GetCellContent(Dtg_Liste.SelectedItem)).Text;
                string Barkod = ((TextBlock)Dtg_Liste.Columns[9].GetCellContent(Dtg_Liste.SelectedItem)).Text;

                Veriler_TextBox_Gonder(Barkod, ogrTC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Veriler_TextBox_Gonder(string barkod, string tc)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    con.Open();

                    MySqlCommand select = new MySqlCommand("select*from kiralanan_kitaplar where ktpBarkod='" + barkod + "' AND ogrTc='" + tc + "'", con);
                    MySqlDataReader rdr = select.ExecuteReader();
                    while (rdr.Read())
                    {
                        txt_ID.textbox.Text = rdr["ogrID"].ToString();
                        txt_AdSoyad.textbox.Text = rdr["ogrIsimSoyisim"].ToString();
                        txt_Yas.textbox.Text = rdr["ogrYas"].ToString();
                        txt_TcNo.textbox.Text = rdr["ogrTc"].ToString();
                        txt_Adres.textbox.Text = rdr["ogrAdres"].ToString();
                        txt_Eposta.textbox.Text = rdr["ogrEposta"].ToString();
                        txt_TelefonNo.textbox.Text = rdr["ogrTelefon"].ToString();
                        txt_K_ID.textbox.Text = rdr["ktpID"].ToString();
                        txt_K_Barkod.textbox.Text = rdr["ktpBarkod"].ToString();
                        txt_K_Ad.textbox.Text = rdr["ktpKitapAdi"].ToString();
                        txt_Yazar.textbox.Text = rdr["ktpYazar"].ToString();
                        txt_K_YayinEvi.textbox.Text = rdr["ktpYayinEvi"].ToString();
                        txt_K_Sayfa.textbox.Text = rdr["ktpSayfa"].ToString();
                        txt_K_Turu.textbox.Text = rdr["ktpTuru"].ToString();
                        txt_K_Raf.textbox.Text = rdr["RafNo"].ToString();
                        txt_K_Aciklama.textbox.Text = rdr["Aciklama"].ToString();
                        txt_VerilisTarihi.Text = rdr["VerilisZamani"].ToString();
                        txt_TeslimTarihi.Text = rdr["TeslimZamani"].ToString();
                        cmb_Kitap_Durum.combobox.Text = rdr["KitapDurumu"].ToString();
                        cmb_Teslim_Durum.combobox.Text = rdr["TeslimDurumu"].ToString();
                        txt_TeslimAlimTarihi.Text = rdr["TeslimAlimTarihi"].ToString();
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Temizlik();
        }

        public void Temizlik()
        {
            txt_TcNo.textbox.Text = "";
            txt_K_Barkod.textbox.Text = "";
            txt_ID.textbox.Text = "";
            txt_AdSoyad.textbox.Text = "";
            txt_Yas.textbox.Text = "";
            txt_Adres.textbox.Text = "";
            txt_Eposta.textbox.Text = "";
            txt_TelefonNo.textbox.Text = "";
            txt_K_ID.textbox.Text = "";
            txt_K_Ad.textbox.Text = "";
            txt_Yazar.textbox.Text = "";
            txt_K_YayinEvi.textbox.Text = "";
            txt_K_Sayfa.textbox.Text = "";
            txt_K_Turu.textbox.Text = "";
            txt_K_Raf.textbox.Text = "";
            txt_K_Aciklama.textbox.Text = "";
            txt_VerilisTarihi.Text = "";
            txt_TeslimTarihi.Text = "";
            cmb_Kitap_Durum.combobox.Text = "";
            cmb_Teslim_Durum.combobox.Text = "";
            txt_TeslimAlimTarihi.Text = "";
        }
    }
}
