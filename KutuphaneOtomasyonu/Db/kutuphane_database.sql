-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost:3306
-- Üretim Zamanı: 19 Haz 2022, 15:28:02
-- Sunucu sürümü: 8.0.28
-- PHP Sürümü: 7.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `kutuphane_database`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kiralanan_kitaplar`
--

CREATE TABLE `kiralanan_kitaplar` (
  `ID` int NOT NULL,
  `ogrID` int NOT NULL,
  `ogrIsimSoyisim` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `ogrYas` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `ogrTc` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `ogrAdres` varchar(80) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `ogrEposta` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `ogrTelefon` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `ktpID` int NOT NULL,
  `ktpBarkod` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `ktpKitapAdi` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `ktpYazar` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `ktpYayinEvi` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `ktpSayfa` int NOT NULL,
  `ktpTuru` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `RafNo` int NOT NULL,
  `Aciklama` varchar(150) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `VerilisZamani` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `TeslimZamani` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `KitapDurumu` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT 'Hasarsız',
  `TeslimDurumu` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT 'Teslim Alınmadı',
  `TeslimAlimTarihi` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT 'Teslim Alınmadı'
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kitaplar`
--

CREATE TABLE `kitaplar` (
  `ID` int NOT NULL,
  `BarkodNo` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `KitapAdi` varchar(45) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `Yazar` varchar(45) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `YayinEvi` varchar(45) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `SayfaSayisi` varchar(45) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `Turu` varchar(45) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `StokSayisi` int DEFAULT NULL,
  `RafNo` int DEFAULT NULL,
  `Aciklama` varchar(250) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `loginpage`
--

CREATE TABLE `loginpage` (
  `ID` int NOT NULL,
  `KullaniciAdi` varchar(45) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `Sifre` varchar(45) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ogrenci`
--

CREATE TABLE `ogrenci` (
  `ID` int NOT NULL,
  `IsimSoyisim` varchar(45) DEFAULT NULL,
  `Yas` int DEFAULT NULL,
  `TcNo` varchar(45) DEFAULT NULL,
  `TelefonNo` varchar(45) DEFAULT NULL,
  `Adres` varchar(150) DEFAULT NULL,
  `Eposta` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kiralanan_kitaplar`
--
ALTER TABLE `kiralanan_kitaplar`
  ADD PRIMARY KEY (`ID`);

--
-- Tablo için indeksler `kitaplar`
--
ALTER TABLE `kitaplar`
  ADD PRIMARY KEY (`ID`);

--
-- Tablo için indeksler `loginpage`
--
ALTER TABLE `loginpage`
  ADD PRIMARY KEY (`ID`);

--
-- Tablo için indeksler `ogrenci`
--
ALTER TABLE `ogrenci`
  ADD PRIMARY KEY (`ID`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kiralanan_kitaplar`
--
ALTER TABLE `kiralanan_kitaplar`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `kitaplar`
--
ALTER TABLE `kitaplar`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `loginpage`
--
ALTER TABLE `loginpage`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `ogrenci`
--
ALTER TABLE `ogrenci`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
