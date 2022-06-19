using LiveCharts;
using LiveCharts.Wpf;
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
using System.Threading;

namespace KutuphaneOtomasyonu.UserControls
{
    public partial class İstatisliker_UserControl : UserControl
    {
        MySqlConnection con = new MySqlConnection(DB_Baglanti.Path1);
        double ogrenci, kiralanan_kitaplar, iade_edilen_kitaplar;
        int toplam_kitaplar;
        public İstatisliker_UserControl()
        {            
            ogrenci = DB_Count("ogrenci", con,"Gereksiz Bilgi","TcNo","<>");
            kiralanan_kitaplar =  DB_Count("kiralanan_kitaplar", con, "Teslim Alındı", "TeslimDurumu","<>");
            iade_edilen_kitaplar = DB_Count("kiralanan_kitaplar", con,"Teslim Alındı","TeslimDurumu","=");
            toplam_kitaplar = Toplam_Kitap();          

            InitializeComponent();
            SeriesCollection = new SeriesCollection
           {
               new ColumnSeries
               {
                   Title="Toplam Kitap Sayısı",                   
                   Values=new ChartValues<double>{ toplam_kitaplar }
               }
           };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Toplam Öğrenci Sayısı",                
                Values = new ChartValues<double> { ogrenci }
            });

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Toplam Emannet Verilen Kitap Sayısı",                
                Values = new ChartValues<double> { kiralanan_kitaplar }
            });

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Toplam Geri İade Edilen Kitap Sayısı",                
                Values = new ChartValues<double> { iade_edilen_kitaplar }
            });

            //  BarLables = new[] { "values 1", "values 2", "values 3", "values 4" };
            Formatter = value => value.ToString("N");
            DataContext = this;
        }       
        public SeriesCollection SeriesCollection { get; set; }
        public string[] BarLables { get; set; }
        public Func<double, string> Formatter { get; set; }

        public double DB_Count(string tablo_adi, MySqlConnection con,string kosul,string sutun_adi,string operatör)
        {
            double veri;
            try
            {
                con.Open();

                MySqlCommand select = new MySqlCommand("select count(*) from " + tablo_adi +" where "+ sutun_adi + " "+operatör+" '"+kosul+"'", con);
               
                veri = double.Parse(select.ExecuteScalar().ToString());
                con.Close();
                return veri;

            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Toplam_Kitap()
        {
            int toplam = 0;
            try
            {
                con.Open();

                MySqlCommand select_Kitaplar = new MySqlCommand("select StokSayisi from kitaplar", con);
                MySqlDataReader rdr = select_Kitaplar.ExecuteReader();
                while (rdr.Read())
                {
                    toplam += int.Parse(rdr["StokSayisi"].ToString());
                }
                con.Close();
                return toplam;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private void txt_Toplam_Kitap_Loaded(object sender, RoutedEventArgs e)
        {
            txt_Toplam_Kitap.textbox.IsReadOnly = true;
            txt_Toplam_Ogrenci.textbox.IsReadOnly = true;
            txt_Toplam_Emanet.textbox.IsReadOnly = true;
            txt_Toplam_Iade.textbox.IsReadOnly = true;

            txt_Toplam_Kitap.textbox.Text = toplam_kitaplar.ToString();
            txt_Toplam_Ogrenci.textbox.Text = ogrenci.ToString();
            txt_Toplam_Emanet.textbox.Text = kiralanan_kitaplar.ToString();
            txt_Toplam_Iade.textbox.Text = iade_edilen_kitaplar.ToString();
        }
    }
}
