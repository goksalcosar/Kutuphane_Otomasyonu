using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows;

namespace KutuphaneOtomasyonu.DB_Islem
{
    public class LoginIslem
    {
        //Login Arama Sorgusu

        static string path = DB_Baglanti.Path1;           

        public string Select(Parametreler prm)
        {
            using (MySqlConnection con = new MySqlConnection(path))
            {
                bool sonuc = false;
                try
                {
                    con.Open();

                    MySqlCommand select = new MySqlCommand("select*from loginpage",con);
                    MySqlDataReader read = select.ExecuteReader();
                    while (read.Read())
                    {
                        if (read["KullaniciAdi"].ToString() == prm.KullaniciAdi1 && read["Sifre"].ToString() == prm.Sifre1)
                            sonuc = true;
                        else
                            sonuc = false;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                if (sonuc == true)
                    return "Başarılı";
                else
                    return "Başarısız";
            }
               
        }
    }
}
