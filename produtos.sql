-- MySQL dump 10.13  Distrib 8.0.44, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: produtos
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

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
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produtos` (
  `idProduto` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `CustoUnitario` decimal(10,2) NOT NULL,
  `DataCompra` date NOT NULL,
  `Imagem` varchar(500) DEFAULT NULL,
  `Quantidade` int(11) NOT NULL,
  PRIMARY KEY (`idProduto`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtos`
--

LOCK TABLES `produtos` WRITE;
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` VALUES (1,'Notebook Dell Inspiron',3500.00,'2024-01-15','C:\\Users\\Yasmin\\Desktop\\Imagens\\img1.jpg',10),(2,'Mouse Logitech MX',250.00,'2024-02-20','C:\\Users\\Yasmin\\Desktop\\Imagens\\img2.jpg',5),(3,'Teclado Mecanico Redragon',350.00,'2024-03-10','C:\\Users\\Yasmin\\Desktop\\Imagens\\img3.jpg',8),(4,'Monitor LG 24 polegadas',1200.00,'2024-04-05','C:\\Users\\Yasmin\\Desktop\\Imagens\\img4.jpg',3),(5,'Headset HyperX Cloud',450.00,'2024-05-18','C:\\Users\\Yasmin\\Desktop\\Imagens\\img5.jpg',7),(6,'SSD Kingston 480GB',280.00,'2024-07-30','C:\\Users\\Yasmin\\Desktop\\Imagens\\img6.jpg',15),(7,'iPhone 17 Pro Max (256 GB) - Laranja cósmico',11580.00,'2026-04-19','C:\\Users\\Yasmin\\Desktop\\Imagens\\img7.jpg',1),(11,'Echo Dot (Geração mais recente) | Smart speaker com Alexa, som vibrante e potente, Wi-Fi e Bluetooth',459.00,'2026-04-20','C:\\Users\\Yasmin\\Desktop\\Imagens\\img8.jpg',2);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-04-20 20:03:33
