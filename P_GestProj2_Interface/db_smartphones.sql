-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Ven 08 Décembre 2017 à 08:36
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.5.8



SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

DROP DATABASE IF EXISTS db_smartphones ;
CREATE DATABASE db_smartphones CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE db_smartphones ;


--
-- Base de données :  `db_smartphones`
--

-- --------------------------------------------------------

--
-- Structure de la table `t_processeur`
--

CREATE TABLE IF NOT EXISTS `t_processeur` (
  `idProcesseur` int(11) NOT NULL AUTO_INCREMENT,
  `proNom` varchar(255) NOT NULL,
  `proPerformances` float NOT NULL,
  PRIMARY KEY (`idProcesseur`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=31 ;

--
-- Contenu de la table `t_processeur`
--

INSERT INTO `t_processeur` (`idProcesseur`, `proNom`, `proPerformances`) VALUES
(1, 'A9 - Dual-core 1.84 GHz Twister', 3.68),
(2, 'A9 - Dual-core 1.84 GHz Twister', 3.68),
(3, 'A9 - Dual-core 1.84 GHz Twister', 3.68),
(4, 'A10 Fusion Quad-core 2.34 GHz (2x Hurricane + 2x Zephyr)', 9.36),
(5, 'A10 Fusion Quad-core 2.34 GHz (2x Hurricane + 2x Zephyr)', 9.36),
(6, 'Exynos 8895 Octa-core (4x2.3 GHz & 4x1.7 GHz) - EMEA', 16),
(7, 'Exynos 8895 Octa-core (4x2.3 GHz & 4x1.7 GHz) - EMEA', 16),
(8, 'Quad-core (2x2.15 GHz Kryo & 2x1.6 GHz Kryo)', 7.5),
(9, 'Quad-core (2x2.15 GHz Kryo & 2x1.6 GHz Kryo)', 7.5),
(10, 'Octa-core (4x2.3 GHz Cortex-A53 & 4x1.6 GHz Cortex-A53)', 15.6),
(11, 'Octa-core (4x2.3 GHz Cortex-A53 & 4x1.6 GHz Cortex-A53)', 15.6),
(12, 'Octa-core (4x2.4 GHz Cortex-A73 & 4x1.8 GHz Cortex-A53)', 16.8),
(13, 'Octa-core (4x2.4 GHz Cortex-A73 & 4x1.8 GHz Cortex-A53)', 16.8),
(14, 'Quad-core (2x2.35 GHz Kryo & 2x1.6 GHz Kryo)', 7.9),
(15, 'Quad-core (2x2.15 GHz Kryo & 2x1.6 GHz Kryo)', 7.5),
(16, 'Quad-core 1.3 GHz Cortex-A53', 5.2),
(17, 'Quad-core 1.2 GHz Cortex-A53', 4.8),
(18, 'Quad-core 1.2 GHz Cortex-A7', 4.8),
(19, 'Octa-core (4x1.5 GHz Cortex-A53 & 4x2.0 GHz Cortex-A57)', 14),
(20, 'Octa-core (4x2.1 GHz Cortex-A57 & 4x1.5 GHz Cortex-A53)', 14.4),
(21, 'Octa-core 2.0 GHz Cortex-A53', 16),
(22, 'Hexa-core (4x1.4 GHz Cortex-A53 & 2x1.8 GHz Cortex-A72)', 9.2),
(23, 'Octa-core 1.9 GHz Cortex-A53', 15.2),
(24, 'Quad-core (2x2.15 GHz Kryo & 2x1.6 GHz Kryo)', 7.5),
(25, 'Octa-core (4x2.4 GHz Cortex-A73 & 4x1.8 GHz Cortex-A53)', 16.8),
(26, 'Octa-core (4x2.3 GHz Cortex-A72 & 4x1.8 GHz Cortex A53)', 16.4),
(27, 'Octa-core (4x2.3 GHz Mongoose & 4x1.6 GHz Cortex-A53)', 15.6),
(28, 'Quad-core (2x2.15 GHz Kryo & 2x1.6 GHz Kryo)', 7.5),
(29, 'Octa-core 1.6 GHz Cortex-A53', 12.8),
(30, 'Quad-core 1.5 GHz Cortex-A53', 6);

-- --------------------------------------------------------

--
-- Structure de la table `t_smartphone`
--

CREATE TABLE IF NOT EXISTS `t_smartphone` (
  `idSmartphone` int(11) NOT NULL AUTO_INCREMENT,
  `smaDate` varchar(14) NOT NULL,
  `smaMarque` varchar(255) NOT NULL,
  `smaModele` varchar(255) NOT NULL,
  `smaOS` varchar(255) NOT NULL,
  `smaConstructeurs` varchar(255) NOT NULL,
  `smaTailleEcran` float NOT NULL,
  `smaAutonomie` int(11) NOT NULL,
  `smaRAM` int(11) NOT NULL,
  `Idproc` int(11) NOT NULL,
  PRIMARY KEY (`idSmartphone`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=31 ;

--
-- Contenu de la table `t_smartphone`
--

INSERT INTO `t_smartphone` (`idSmartphone`, `smaDate`, `smaMarque`, `smaModele`, `smaOS`, `smaConstructeurs`, `smaTailleEcran`, `smaAutonomie`, `smaRAM`, `Idproc`) VALUES
(1, '2015-09-25', 'Apple', 'iPhone 6s', 'iOS 9 (iOS 10.3.3)', 'Apple', 4.7, 11, 2, 1),
(2, '2015-09-25', 'Apple', 'iPhone 6s Plus', 'iOS 9 (iOS 10.3.3)', 'Apple', 5.5, 14, 2, 2),
(3, '2016-03-31', 'Apple', 'iPhone SE', 'iOS 9.3.2 (iOS 10.3.3)', 'Apple', 4, 14, 2, 3),
(4, '2016-09-16', 'Apple', 'iPhone 7', 'iOS 10.0.1 (iOS 10.3.3)', 'Apple', 4.7, 9, 2, 4),
(5, '2016-09-16', 'Apple', 'iPhone 7 Plus', 'iOS 10.0.1 (iOS 10.3.3)', 'Apple', 5.5, 8, 3, 5),
(6, '2017-04-21', 'Samsung', 'Galaxy S8', 'Android 7.0', 'Samsung', 5.8, 14, 4, 6),
(7, '2017-04-21', 'Samsung', 'Galaxy S8+', 'Android 7.0', 'Samsung', 6.2, 16, 6, 7),
(8, '2017-06-09', 'Sony', 'Xperia XZ Premium', 'Android 6.0.1, 7.1.1, planned upgrade to 8.0', 'Sony', 5.2, 8, 3, 8),
(9, '2017-06-09', 'Sony', 'Xperia XZs', 'Android 7.1, planned upgrade to 8.0', 'Sony', 5.2, 9, 4, 9),
(10, '2017-04-10', 'Sony', 'Xperia XA1', 'Android 7.0, planned upgrade to 8.0', 'Sony', 5, 9, 3, 10),
(11, '2017-05-01', 'Sony', 'Xperia XA1 Ultra', 'Android 7.0, planned upgrade to 8.0', 'Sony', 6, 10, 4, 11),
(12, '2017-03-24', 'Huawei', 'Huawei P10', 'Android 7.0', 'Huawei', 5.1, 12, 4, 12),
(13, '2017-03-24', 'Huawei', 'Huawei P10 Plus', 'Android 7.0', 'Huawei', 5.5, 12, 6, 13),
(14, '2017-04-24', 'LG', 'LG G6', 'Android 7.0', 'LG', 5.7, 10, 4, 14),
(15, '2017-08-01', 'Asus', 'ZenFone 3 Deluxe (ZS570KL)', 'Android 6.0.1', 'Asus', 5.7, 9, 6, 15),
(16, '2015-03-02', 'Motorola', 'Moto E 4G', 'Android', 'Motorola', 4.5, 13, 1, 16),
(17, '2015-02-01', 'HTC', 'Desire 620', 'Android', 'HTC', 5, 12, 1, 17),
(18, '2015-04-16', 'Microsoft', 'Lumia 640', 'Windows Phone', 'Microsoft Mobile', 5, 10, 1, 18),
(19, '2015-09-25', 'Sony', 'Xperia Z5 Compact', 'Android', 'Sony', 4.6, 13, 2, 19),
(20, '2015-04-10', 'Samsung', 'Galaxy S6', 'Android', 'Samsung Electronics', 5.1, 12, 3, 20),
(21, '2016-09-05', 'Lenovo', 'Moto Z Play', 'Android', 'Lenovo', 5.5, 18, 3, 21),
(22, '2016-01-27', 'Xiaomi', 'Redmi Note 3 Pro', 'MIUI', 'Xiaomi', 5.5, 13, 3, 22),
(23, '2017-02-03', 'Samsung', 'Galaxy A5', 'Android', 'Samsung Electronics', 5, 16, 2, 23),
(24, '2016-09-29', 'Xiaomi', 'Mi 5s', 'MIUI', 'Xiaomi', 5.1, 13, 3, 24),
(25, '2016-11-15', 'Huawei', 'Mate 9', 'Android', 'Huawei', 5.9, 11, 4, 25),
(26, '2017-04-20', 'Huawei', 'Honor 8', 'Android', 'Huawei', 5.2, 9, 4, 26),
(27, '2016-03-11', 'Samsung', 'Galaxy S7 Edge', 'Android', 'Samsung Electronics', 5.5, 15, 4, 27),
(28, '2016-06-14', 'OnePlus', 'OnePlus3', 'Oxygen=S', 'OPPO', 5.5, 13, 6, 28),
(29, '2016-06-01', 'Samsung', 'Galaxy J5', 'Android', 'Samsung Electronics', 5.2, 5, 2, 29),
(30, '2017-06-01', 'Archos', '50 Saphir', 'Android', 'Archos', 5, 11, 2, 30);

-- --------------------------------------------------------

--
-- Structure de la table `t_valeur`
--

CREATE TABLE IF NOT EXISTS `t_valeur` (
  `IDValeur` int(11) NOT NULL AUTO_INCREMENT,
  `valPrix` int(11) NOT NULL,
  `valDate` date NOT NULL,
  `idSmartphone` int(11) NOT NULL,
  PRIMARY KEY (`IDValeur`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=61 ;

--
-- Contenu de la table `t_valeur`
--

INSERT INTO `t_valeur` (`IDValeur`, `valPrix`, `valDate`, `idSmartphone`) VALUES
(1, 529, '2015-09-25', 1),
(2, 639, '2015-09-25', 2),
(3, 419, '2016-03-31', 3),
(4, 639, '2016-09-16', 4),
(5, 779, '2016-09-16', 5),
(6, 799, '2017-04-21', 6),
(7, 899, '2017-04-21', 7),
(8, 776, '2017-06-09', 8),
(9, 599, '2017-06-09', 9),
(10, 289, '2017-04-10', 10),
(11, 405, '2017-05-01', 11),
(12, 548, '2017-03-24', 12),
(13, 733, '2017-03-24', 13),
(14, 513, '2017-04-24', 14),
(15, 699, '2017-08-01', 15),
(16, 139, '2015-03-02', 16),
(17, 249, '2015-02-01', 17),
(18, 139, '2015-04-16', 18),
(19, 599, '2015-09-25', 19),
(20, 699, '2015-04-10', 20),
(21, 499, '2016-09-05', 21),
(22, 182, '2016-01-27', 22),
(23, 429, '2017-02-03', 23),
(24, 267, '2016-09-29', 24),
(25, 699, '2016-11-15', 25),
(26, 269, '2017-04-20', 26),
(27, 799, '2016-03-11', 27),
(28, 399, '2016-06-14', 28),
(29, 279, '2016-06-01', 29),
(30, 199, '2017-06-01', 30),
(31, 556, '2017-09-15', 1),
(32, 660, '2017-09-15', 2),
(33, 417, '2017-09-15', 3),
(34, 660, '2017-09-15', 4),
(35, 782, '2017-09-15', 5),
(36, 582, '2017-09-15', 6),
(37, 695, '2017-09-15', 7),
(38, 719, '2017-09-15', 8),
(39, 521, '2017-09-15', 9),
(40, 260, '2017-09-15', 10),
(41, 321, '2017-09-15', 11),
(42, 478, '2017-09-15', 12),
(43, 599, '2017-09-15', 13),
(44, 417, '2017-09-15', 14),
(45, 559, '2017-09-15', 15),
(46, 155, '2017-09-15', 16),
(47, 133, '2017-09-15', 17),
(48, 109, '2017-09-15', 18),
(49, 400, '2017-09-15', 19),
(50, 389, '2017-09-15', 20),
(51, 328, '2017-09-15', 21),
(52, 163, '2017-09-15', 22),
(53, 400, '2017-09-15', 23),
(54, 215, '2017-09-15', 24),
(55, 636, '2017-09-15', 25),
(56, 276, '2017-09-15', 26),
(57, 369, '2017-09-15', 27),
(58, 359, '2017-09-15', 28),
(59, 205, '2017-09-15', 29),
(60, 200, '2017-09-15', 30);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
