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
    /// <summary>
    /// Interaction logic for KitapK_UserControl.xaml
    /// </summary>
    public partial class KitapK_UserControl : UserControl
    {
        public KitapK_UserControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txt_Arama.textbox.MaxLength = 11;
            txt_K_Stok.textbox.IsReadOnly = true;
            txt_ID.textbox.TextChanged += Textbox_TextChanged;
            txt_AdSoyad.textbox.TextChanged += Textbox_TextChanged1;
            txt_Yas.textbox.TextChanged += Textbox_TextChanged2;
            txt_TcNo.textbox.TextChanged += Textbox_TextChanged3;
            txt_Adres.textbox.TextChanged += Textbox_TextChanged4;
            txt_Eposta.textbox.TextChanged += Textbox_TextChanged5;
            txt_TelefonNo.textbox.TextChanged += Textbox_TextChanged6;
            txt_K_ID.textbox.TextChanged += Textbox_TextChanged7;
            txt_K_Barkod.textbox.TextChanged += Textbox_TextChanged8;
            txt_K_Ad.textbox.TextChanged += Textbox_TextChanged15;
            txt_Yazar.textbox.TextChanged += Textbox_TextChanged9;
            txt_K_YayinEvi.textbox.TextChanged += Textbox_TextChanged10;
            txt_K_Sayfa.textbox.TextChanged += Textbox_TextChanged11;
            txt_K_Turu.textbox.TextChanged += Textbox_TextChanged12;
            txt_K_Raf.textbox.TextChanged += Textbox_TextChanged13;
            txt_K_Aciklama.textbox.TextChanged += Textbox_TextChanged14;
            txt_VerilisTarihi.SelectedDateChanged += Txt_VerilisTarihi_SelectedDateChanged;
            txt_TeslimTarihi.SelectedDateChanged += Txt_TeslimTarihi_SelectedDateChanged;
            txt_Guncelle_Sil.textbox.TextChanged += Textbox_TextChanged16;
            txt_Arama.textbox.TextChanged += Textbox_TextChanged17;
            txt_K_Arama.textbox.TextChanged += Textbox_TextChanged18;
        }

        #region TextBox_TextChanged

        private void Textbox_TextChanged18(object sender, TextChangedEventArgs e)
        {
            txt_K_Arama.textbox.BorderBrush = btn.Background;
        }


        private void Textbox_TextChanged17(object sender, TextChangedEventArgs e)
        {
            txt_Arama.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged16(object sender, TextChangedEventArgs e)
        {
            txt_Guncelle_Sil.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged15(object sender, TextChangedEventArgs e)
        {
            txt_K_Ad.textbox.BorderBrush = btn.Background;
        }

        private void Txt_TeslimTarihi_SelectedDateChanged(object? sender, SelectionChangedEventArgs e)
        {
            txt_TeslimTarihi.BorderBrush = btn.Background;
        }

        private void Txt_VerilisTarihi_SelectedDateChanged(object? sender, SelectionChangedEventArgs e)
        {
            txt_VerilisTarihi.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged14(object sender, TextChangedEventArgs e)
        {
            txt_K_Aciklama.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged13(object sender, TextChangedEventArgs e)
        {
            txt_K_Raf.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged12(object sender, TextChangedEventArgs e)
        {
            txt_K_Turu.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged11(object sender, TextChangedEventArgs e)
        {
            txt_K_Sayfa.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged10(object sender, TextChangedEventArgs e)
        {
            txt_K_YayinEvi.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged9(object sender, TextChangedEventArgs e)
        {
            txt_Yazar.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged8(object sender, TextChangedEventArgs e)
        {
            txt_K_Barkod.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged7(object sender, TextChangedEventArgs e)
        {
            txt_K_ID.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged6(object sender, TextChangedEventArgs e)
        {
            txt_TelefonNo.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged5(object sender, TextChangedEventArgs e)
        {
            txt_Eposta.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged4(object sender, TextChangedEventArgs e)
        {
            txt_Adres.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged3(object sender, TextChangedEventArgs e)
        {
            txt_TcNo.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            txt_Yas.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged1(object sender, TextChangedEventArgs e)
        {
            txt_AdSoyad.textbox.BorderBrush = btn.Background;
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_ID.textbox.BorderBrush = btn.Background;
        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataGridDoldur.EmanetListesi_GridDoldur(Dtg_Liste, 0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Arama.textbox.Text))
            {                
                Ogrenci_Varmi(0);

            }               
            else
            {
                MessageBox.Show("Hata! Lütfen Gerekli Alanları Doldulurunuz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_Arama.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
            }                
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_K_Arama.textbox.Text))
            {
                txt_K_Arama.textbox.BorderBrush = btn.Background;
                Kitap_Varmi(0);
            }

            else
            {
                MessageBox.Show("Hata! Lütfen Gerekli Alanları Doldulurunuz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_K_Arama.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
               
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ID.textbox.Text) && !string.IsNullOrEmpty(txt_AdSoyad.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Yas.textbox.Text) && !string.IsNullOrEmpty(txt_TcNo.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Adres.textbox.Text) && !string.IsNullOrEmpty(txt_Eposta.textbox.Text) &&
                !string.IsNullOrEmpty(txt_TelefonNo.textbox.Text) && !string.IsNullOrEmpty(txt_K_ID.textbox.Text) &&
                !string.IsNullOrEmpty(txt_K_Barkod.textbox.Text) && !string.IsNullOrEmpty(txt_K_Ad.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Yazar.textbox.Text) && !string.IsNullOrEmpty(txt_K_YayinEvi.textbox.Text) &&
                !string.IsNullOrEmpty(txt_K_Sayfa.textbox.Text) && !string.IsNullOrEmpty(txt_K_Turu.textbox.Text) &&
                !string.IsNullOrEmpty(txt_K_Raf.textbox.Text) && !string.IsNullOrEmpty(txt_K_Aciklama.textbox.Text) &&
                !string.IsNullOrEmpty(txt_VerilisTarihi.Text) && !string.IsNullOrEmpty(txt_TeslimTarihi.Text))
            {
                bool kitap = Kitap_Varmi(1);
                bool ogrenci = Ogrenci_Varmi(1);

                if (kitap == true && ogrenci == true)
                {

                    using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                    {
                        try
                        {
                            int stok_sayisi = DB_Querys.ktpStok_Sayisi(con, txt_K_Barkod.textbox.Text);

                            if (stok_sayisi == 0)
                            {
                                MessageBox.Show(txt_K_Barkod.textbox.Text + " Barkod No'lu Kitap Malesef Stoklarda Kalmamıştır.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            else
                            {
                                if (DB_Querys.Kiralanan_Kitap_Sorgusu(con,txt_K_Barkod.textbox.Text,txt_TcNo.textbox.Text,"TeslimDurumu","Teslim Alındı") == true)
                                {
                                    MessageBox.Show("Hata! Birden Fazla Aynı Kayıt Yapmaya Çalıştınız. " + txt_K_Barkod.textbox.Text + " Barkod No'lu Kitap Zaten " + txt_TcNo.textbox.Text + " No'lu Öğrencinin Üzerine Bir Kez Kiralanmıştır.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Error);
                                }
                                else
                                {
                                    con.Open();

                                    MySqlCommand insert = new MySqlCommand("insert into kiralanan_kitaplar(ogrID,ogrIsimSoyisim,ogrYas,ogrTc,ogrAdres,ogrEposta,ogrTelefon,ktpID,ktpBarkod,ktpKitapAdi,ktpYazar,ktpYayinEvi,ktpSayfa,ktpTuru,RafNo,Aciklama,VerilisZamani,TeslimZamani)" +
                                        "values(@ogrID,@ogrIsimSoyisim,@ogrYas,@ogrTc,@ogrAdres,@ogrEposta,@ogrTelefon,@ktpID,@ktpBarkod,@ktpKitapAdi,@ktpYazar,@ktpYayinEvi,@ktpSayfa,@ktpTuru,@RafNo,@Aciklama,@VerilisZamani,@TeslimZamani)", con);
                                    insert.Parameters.AddWithValue("@ogrID", txt_ID.textbox.Text);
                                    insert.Parameters.AddWithValue("@ogrIsimSoyisim", txt_AdSoyad.textbox.Text);
                                    insert.Parameters.AddWithValue("@ogrYas", txt_Yas.textbox.Text);
                                    insert.Parameters.AddWithValue("@ogrTc", txt_TcNo.textbox.Text);
                                    insert.Parameters.AddWithValue("@ogrAdres", txt_Adres.textbox.Text);
                                    insert.Parameters.AddWithValue("@ogrEposta", txt_Eposta.textbox.Text);
                                    insert.Parameters.AddWithValue("@ogrTelefon", txt_TelefonNo.textbox.Text);
                                    insert.Parameters.AddWithValue("@ktpID", txt_K_ID.textbox.Text);
                                    insert.Parameters.AddWithValue("@ktpBarkod", txt_K_Barkod.textbox.Text);
                                    insert.Parameters.AddWithValue("@ktpKitapAdi", txt_K_Ad.textbox.Text);
                                    insert.Parameters.AddWithValue("@ktpYazar", txt_Yazar.textbox.Text);
                                    insert.Parameters.AddWithValue("@ktpYayinEvi", txt_K_YayinEvi.textbox.Text);
                                    insert.Parameters.AddWithValue("@ktpSayfa", txt_K_Sayfa.textbox.Text);
                                    insert.Parameters.AddWithValue("@ktpTuru", txt_K_Turu.textbox.Text);
                                    insert.Parameters.AddWithValue("@RafNo", txt_K_Raf.textbox.Text);
                                    insert.Parameters.AddWithValue("@Aciklama", txt_K_Aciklama.textbox.Text);
                                    insert.Parameters.AddWithValue("@VerilisZamani", txt_VerilisTarihi.Text);
                                    insert.Parameters.AddWithValue("@TeslimZamani", txt_TeslimTarihi.Text);
                                    insert.ExecuteNonQuery();
                                    MessageBox.Show(txt_TcNo.textbox.Text + " TC No'lu Öğrenciye Başarılı Bir Şekilde " + txt_K_Barkod.textbox.Text + " Barkod No'lu Kitap Verilmiştir.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                                    con.Close();
                                    DataGridDoldur.EmanetListesi_GridDoldur(Dtg_Liste, 0);


                                    DB_Querys.ktp_Stok_Sayisi_Update(con, txt_K_Barkod.textbox.Text, stok_sayisi);
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                            con.Close();
                        }
                    }

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
            }
        }

        private bool Ogrenci_Varmi(int i)
        {
            bool varMi = false;
            using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
            {
                try
                {
                    con.Open();

                    MySqlCommand select = new MySqlCommand("select*from ogrenci", con);
                    MySqlDataReader rdr = select.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr["TcNo"].ToString() == txt_Arama.textbox.Text)
                        {
                            if (i == 0)
                            {
                                MessageBox.Show(txt_Arama.textbox.Text + " TC No'lu Öğrenci Sistemde Mevcuttur. Öğrenci Bölümünden Öğrencinin Bilgilerine Bakabilirsiniz.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);
                            }
                            txt_ID.textbox.Text = rdr["ID"].ToString();
                            txt_AdSoyad.textbox.Text = rdr["IsimSoyisim"].ToString();
                            txt_Yas.textbox.Text = rdr["Yas"].ToString();
                            txt_TcNo.textbox.Text = rdr["TcNo"].ToString();
                            txt_TelefonNo.textbox.Text = rdr["TelefonNo"].ToString();
                            txt_Adres.textbox.Text = rdr["Adres"].ToString();
                            txt_Eposta.textbox.Text = rdr["Eposta"].ToString();
                            varMi = true;
                            break;
                        }
                    }

                    if (varMi == false)
                    {
                        if (i == 0)
                            MessageBox.Show(txt_Arama.textbox.Text + " TC No'lu Öğrenci Sistemde Kayıtlı Değildir!", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                    con.Close();
                }
                return varMi;
            }
        }


        private bool Kitap_Varmi(int i)
        {
            bool varMi = false;
            using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
            {
                try
                {
                    con.Open();

                    MySqlCommand select = new MySqlCommand("select*from kitaplar", con);
                    MySqlDataReader rdr = select.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr["BarkodNo"].ToString() == txt_K_Arama.textbox.Text)
                        {
                            if (i == 0)
                            {
                                MessageBox.Show(txt_Arama.textbox.Text + " Barkod No'lu Kitaap Sistemde Mevcuttur. Kitap Bölümünden Kitap'ın Bilgilerine Bakabilirsiniz.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);
                            }
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
                            varMi = true;
                            break;
                        }
                    }

                    if (varMi == false)
                    {
                        if (i == 0)
                            MessageBox.Show(txt_Arama.textbox.Text + " Barkood No'lu Kitap Sistemde Kayıtlı Değildir!", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                    con.Close();
                }
                return varMi;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ID.textbox.Text) && !string.IsNullOrEmpty(txt_AdSoyad.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Yas.textbox.Text) && !string.IsNullOrEmpty(txt_TcNo.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Adres.textbox.Text) && !string.IsNullOrEmpty(txt_Eposta.textbox.Text) &&
                !string.IsNullOrEmpty(txt_TelefonNo.textbox.Text) && !string.IsNullOrEmpty(txt_K_ID.textbox.Text) &&
                !string.IsNullOrEmpty(txt_K_Barkod.textbox.Text) && !string.IsNullOrEmpty(txt_K_Ad.textbox.Text) &&
                !string.IsNullOrEmpty(txt_Yazar.textbox.Text) && !string.IsNullOrEmpty(txt_K_YayinEvi.textbox.Text) &&
                !string.IsNullOrEmpty(txt_K_Sayfa.textbox.Text) && !string.IsNullOrEmpty(txt_K_Turu.textbox.Text) &&
                !string.IsNullOrEmpty(txt_K_Raf.textbox.Text) && !string.IsNullOrEmpty(txt_K_Aciklama.textbox.Text) &&
                !string.IsNullOrEmpty(txt_VerilisTarihi.Text) && !string.IsNullOrEmpty(txt_TeslimTarihi.Text) && !string.IsNullOrEmpty(txt_Guncelle_Sil.textbox.Text))
            {
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    try
                    {
                        con.Open();

                        MySqlCommand update = new MySqlCommand("update kiralanan_kitaplar set ogrID='" + int.Parse(txt_ID.textbox.Text) + "',ogrIsimSoyisim='" + txt_AdSoyad.textbox.Text + "',ogrYas='" + txt_Yas.textbox.Text + "',ogrTc='" + txt_TcNo.textbox.Text + "',ogrAdres='" + txt_Adres.textbox.Text + "',ogrEposta='" + txt_Eposta.textbox.Text + "',ogrTelefon='" + txt_TelefonNo.textbox.Text + "',ktpID='" + txt_K_ID.textbox.Text + "',ktpBarkod='" + txt_K_Barkod.textbox.Text + "',ktpKitapAdi='" + txt_K_Ad + "',ktpYazar='" + txt_Yazar.textbox.Text + "',ktpYayinEvi='" + txt_K_YayinEvi.textbox.Text + "',ktpSayfa='" + txt_K_Sayfa.textbox.Text + "',ktpTuru='" + txt_K_Turu.textbox.Text + "',RafNo='" + txt_K_Raf.textbox.Text + "',Aciklama='" + txt_K_Aciklama.textbox.Text + "',VerilisZamani='" + txt_VerilisTarihi.Text + "',TeslimZamani='" + txt_TeslimTarihi.Text + "' where ID='" + txt_Guncelle_Sil.textbox.Text + "'", con);
                        update.ExecuteNonQuery();

                        MessageBox.Show("Kiralana Kitap Başarılı Bir Şekilde Güncellenmiştir.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                        con.Close();

                        DataGridDoldur.EmanetListesi_GridDoldur(Dtg_Liste, 0);
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
                txt_Guncelle_Sil.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Guncelle_Sil.textbox.Text))
            {
                using (MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1))
                {
                    try
                    {
                        con.Open();

                        MySqlCommand delete = new MySqlCommand("delete from kiralanan_kitaplar where ID='" + txt_Guncelle_Sil.textbox.Text + "'", con);
                        delete.ExecuteNonQuery();

                        MessageBox.Show("Kiralana Kitap Kaydı Veri Tabanından Silinmiştir.", "BİLGİLENDİRME", MessageBoxButton.OK, MessageBoxImage.Question);

                        con.Close();

                        DataGridDoldur.EmanetListesi_GridDoldur(Dtg_Liste, 0);
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
                txt_Guncelle_Sil.textbox.BorderBrush = new SolidColorBrush(Colors.Red);
            }

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Temilze();
        }

        public void Temilze()
        {
            txt_Arama.textbox.Text = "";
            txt_ID.textbox.Text = "";
            txt_AdSoyad.textbox.Text = "";
            txt_Yas.textbox.Text = "";
            txt_TcNo.textbox.Text = "";
            txt_Adres.textbox.Text = "";
            txt_Eposta.textbox.Text = "";
            txt_TelefonNo.textbox.Text = "";
            txt_VerilisTarihi.Text = "";
            txt_TeslimTarihi.Text = "";
            txt_K_Arama.textbox.Text = "";
            txt_Guncelle_Sil.textbox.Text = "";
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
