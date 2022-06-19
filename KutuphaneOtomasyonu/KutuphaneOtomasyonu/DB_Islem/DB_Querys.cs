using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KutuphaneOtomasyonu.DB_Islem
{
    static class DB_Querys
    {
        static public MySqlCommand ogrLike(string tablo_adi, string sutun_adi, string kosul, MySqlConnection con)
        {
            try
            {
                con.Open();

                MySqlCommand select = new MySqlCommand("select*from " + tablo_adi + " where " + sutun_adi + " like '" + kosul + "%'", con);

                con.Close();
                return select;

            }
            catch (Exception)
            {
                return null;
            }
        }

        static public int ktpStok_Sayisi(MySqlConnection con, string barkod)
        {
            con.Open();

            int deger = 0;

            MySqlCommand select = new MySqlCommand("select StokSayisi from kitaplar where BarkodNo='" + barkod + "'", con);
            MySqlDataReader rdr = select.ExecuteReader();
            while (rdr.Read())
            {
                deger = int.Parse(rdr["StokSayisi"].ToString());
            }

            con.Close();

            if (deger == 0)
                return 0;
            else
                return deger;
        }

        static public void ktp_Stok_Sayisi_Update(MySqlConnection con, string barkod_no, int stok_sayisi)
        {
            con.Open();

            MySqlCommand update = new MySqlCommand("update kitaplar set StokSayisi='" + (stok_sayisi - 1) + "' where BarkodNo='" + barkod_no + "'", con);
            update.ExecuteNonQuery();

            con.Close();
        }

        static public void ktp_Stok_Sayisi_Update_Topla(MySqlConnection con, string barkod_no, int stok_sayisi)
        {
            con.Open();

            MySqlCommand update = new MySqlCommand("update kitaplar set StokSayisi='" + stok_sayisi + "' where BarkodNo='" + barkod_no + "'", con);
            update.ExecuteNonQuery();

            con.Close();
        }

        static public bool Kiralanan_Kitap_Sorgusu(MySqlConnection con, string barkod, string ogrTC)
        {
            bool varMi = false;
            try
            {
                con.Open();

                MySqlCommand select = new MySqlCommand("select*from kiralanan_kitaplar where ktpBarkod='" + barkod + "' AND ogrTc='" + ogrTC + "'", con);
                MySqlDataReader rdr = select.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["ogrTC"].ToString() == ogrTC && rdr["ktpBarkod"].ToString() == barkod)
                        varMi = true;
                }

                con.Close();

                if (varMi == true)
                    return varMi;
                else
                    return varMi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                con.Close();
                return false;
            }
        }

        static public bool Kiralanan_Kitap_Sorgusu(MySqlConnection con, string barkod, string ogrTC, string sutun, string kosul)
        {
            bool varMi = false;
            try
            {
                con.Open();

                MySqlCommand select = new MySqlCommand("select*from kiralanan_kitaplar where ktpBarkod='" + barkod + "' AND ogrTc='" + ogrTC + "' AND " + sutun + "='" + kosul + "'", con);
                MySqlDataReader rdr = select.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["ogrTC"].ToString() == ogrTC && rdr["ktpBarkod"].ToString() == barkod)
                        varMi = true;
                }

                con.Close();

                if (varMi == true)
                    return varMi;
                else
                    return varMi;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                con.Close();
                return false;
            }
        }

    }
}
