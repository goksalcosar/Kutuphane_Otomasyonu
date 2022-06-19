-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: kutuhane_database
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `kiralanan_kitaplar`
--

DROP TABLE IF EXISTS `kiralanan_kitaplar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kiralanan_kitaplar` (
  `ID` int NOT NULL AUTO_INCREMENT,
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
  `TeslimAlimTarihi` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT 'Teslim Alınmadı',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kiralanan_kitaplar`
--

LOCK TABLES `kiralanan_kitaplar` WRITE;
/*!40000 ALTER TABLE `kiralanan_kitaplar` DISABLE KEYS */;
INSERT INTO `kiralanan_kitaplar` VALUES (27,19,'Göksal Çoşar','17','11111111111','İstanbul','goksal@gmail.com','0541 587 47 87',8,'415','Ateşten Gömlek','Halide Edib Adıvar','Can Miras',207,'Roman',1,'Kurtuluş Savaşı\'nı doğrudan işleyen ilk romandır.','19.06.2022','26.06.2022','Hasarlı','Teslim Alındı','19.06.2022');
/*!40000 ALTER TABLE `kiralanan_kitaplar` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-06-19 18:23:11
