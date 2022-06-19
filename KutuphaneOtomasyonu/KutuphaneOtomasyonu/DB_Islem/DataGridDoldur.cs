using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Controls;
using System.Windows;
using System.Data;

namespace KutuphaneOtomasyonu.DB_Islem
{
    public class DataGridDoldur
    {
        Parametreler prm = new Parametreler();
        static string path = DB_Baglanti.Path1;

    
        //DataGrid Doldur Metodu
        public static bool Ogrenci_GridDoldur(DataGrid grd)
        {
            sbyte i = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(path))
                {
                    con.Open();

                    MySqlCommand com = new MySqlCommand("select*from ogrenci", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    grd.ItemsSource = null;
                    grd.ItemsSource = dt.DefaultView;
                    i++;
                    con.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                i = 0;
            }
            if (i > 0)
                return true;
            else
                return false;
        }

        public static bool Kitap_GridDoldur(DataGrid grd)
        {
            sbyte i = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(path))
                {
                    con.Open();

                    MySqlCommand com = new MySqlCommand("select*from kitaplar", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    grd.ItemsSource = null;
                    grd.ItemsSource = dt.DefaultView;
                    i++;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                i = 0;
            }
            if (i > 0)
                return true;
            else
                return false;
        }

        public static bool EmanetListesi_GridDoldur(DataGrid grd, int prms)
        {
            sbyte i = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(path))
                {
                    DataTable dt = new DataTable();
                    con.Open();

                    if(prms == 0)
                    {
                        MySqlCommand com = new MySqlCommand("select*from kiralanan_kitaplar where TeslimDurumu='Teslim Alınmadı'", con);
                        MySqlDataAdapter adp = new MySqlDataAdapter(com);                       
                        adp.Fill(dt);
                        grd.ItemsSource = null;
                        grd.ItemsSource = dt.DefaultView;
                        i++;
                    }
                    else
                    {
                        MySqlCommand com = new MySqlCommand("select*from kiralanan_kitaplar where TeslimDurumu='Teslim Alındı'", con);
                        MySqlDataAdapter adp = new MySqlDataAdapter(com);
                        adp.Fill(dt);
                        grd.ItemsSource = null;
                        grd.ItemsSource = dt.DefaultView;
                        i++;
                    }                  

                   
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                i = 0;
            }
            if (i > 0)
                return true;
            else
                return false;
        }

        public static bool Kullanici_GirdDoldur(DataGrid grd)
        {
            sbyte i = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(path))
                {
                    con.Open();

                    MySqlCommand com = new MySqlCommand("select*from loginpage", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    grd.ItemsSource = null;
                    grd.ItemsSource = dt.DefaultView;
                    i++;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                i = 0;
            }
            if (i > 0)
                return true;
            else
                return false;
        }
    }
}
