using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu.DB_Islem
{
    public static class DB_Baglanti
    {      
        static private string Path { get; } = "SERVER=localhost;DATABASE=kutuhane_database;UID=root;PWD=root";

        static public string Path1
        {
            get => Path;            
        }
    }
}
