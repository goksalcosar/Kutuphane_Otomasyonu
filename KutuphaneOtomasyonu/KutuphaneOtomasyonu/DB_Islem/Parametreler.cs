using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.DB_Islem
{
    public class Parametreler
    {
        private int TC = 0;
        private string AdSoyad = "";
        private int Yas = 0;
        private string Cinsiyet = "";
        private string Telefon = "";
        private string Adres = "";
        private string Email = "";
        private int OkuduguKitapSayisi = 0;
        private string KullaniciAdi = "";
        private string Sifre = "";
        private string Yetki = "";

        public int TC1 { get => TC; set => TC = value; }
        public string AdSoyad1 { get => AdSoyad; set => AdSoyad = value; }
        public int Yas1 { get => Yas; set => Yas = value; }
        public string Cinsiyet1 { get => Cinsiyet; set => Cinsiyet = value; }
        public string Telefon1 { get => Telefon; set => Telefon = value; }
        public string Adres1 { get => Adres; set => Adres = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int OkuduguKitapSayisi1 { get => OkuduguKitapSayisi; set => OkuduguKitapSayisi = value; }
        public string KullaniciAdi1 { get => KullaniciAdi; set => KullaniciAdi = value; }
        public string Sifre1 { get => Sifre; set => Sifre = value; }
        public string Yetki1 { get => Yetki; set => Yetki = value; }
    }
}
