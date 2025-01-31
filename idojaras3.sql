-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Jan 31. 09:03
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `idojaras3`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `idojaras`
--

CREATE TABLE `idojaras` (
  `id` int(11) DEFAULT NULL,
  `datum` varchar(255) DEFAULT NULL,
  `homerseklet` int(11) DEFAULT NULL,
  `csapadek` int(11) DEFAULT NULL,
  `paratartalom` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `idojaras`
--

INSERT INTO `idojaras` (`id`, `datum`, `homerseklet`, `csapadek`, `paratartalom`) VALUES
(1, '1', 10, 49, 11),
(2, '2', 26, 58, 53),
(3, '3', 16, 100, 93),
(4, '4', 25, 85, 38),
(5, '5', 5, 50, 24),
(6, '6', 28, 35, 42),
(7, '7', 10, 32, 1),
(8, '8', 14, 82, 82),
(9, '9', 17, 19, 84),
(10, '10', 12, 87, 84),
(11, '11', 20, 54, 95),
(12, '12', 11, 76, 31),
(13, '13', 21, 71, 44),
(14, '14', 12, 58, 68),
(15, '15', 5, 100, 3),
(16, '16', 15, 40, 48),
(17, '17', 1, 4, 58),
(18, '18', 2, 32, 82),
(19, '19', 27, 24, 65),
(20, '20', 23, 75, 91),
(21, '21', 20, 54, 95),
(22, '22', 11, 76, 31),
(23, '23', 21, 71, 44),
(24, '24', 12, 58, 68),
(25, '25', 5, 100, 3),
(26, '26', 15, 40, 48),
(27, '27', 1, 4, 58),
(28, '28', 2, 32, 82),
(29, '29', 27, 24, 65),
(30, '30', 23, 75, 91),
(31, '31', 23, 75, 91),
(32, '32', 20, 30, 40),
(32, '32', 20, 30, 40),
(35, '35', 10, 20, 30),
(36, '36', 32, 20, 30),
(36, '36', 32, 20, 30),
(36, '36', 32, 20, 30),
(36, '36', 32, 20, 30),
(36, '36', 32, 20, 30),
(37, '37', 32, 20, 99),
(37, '37', 32, 20, 99),
(37, '37', 32, 20, 55),
(37, '37', 32, 20, 55),
(37, '37', 32, 20, 55),
(37, '37', 32, 20, 55),
(37, '37', 32, 20, 55),
(37, '37', 32, 20, 55),
(37, '37', 32, 20, 55),
(37, '37', 32, 20, 55),
(37, '37', 32, 20, 55);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `meteorologusok`
--

CREATE TABLE `meteorologusok` (
  `id` mediumint(8) UNSIGNED NOT NULL,
  `Nev` varchar(255) DEFAULT NULL,
  `SzulEv` mediumint(9) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `meteorologusok`
--

INSERT INTO `meteorologusok` (`id`, `Nev`, `SzulEv`) VALUES
(1, 'Czelnai Rudolf', 1946),
(2, 'László Ferenc', 1913),
(3, 'Véber István', 1936),
(4, 'László Ferenc', 1912),
(5, 'Orbán László', 1940),
(6, 'Hegyfoky Kabos', 1922),
(7, 'Aigner Szilárd', 1965),
(8, 'Berde Áron', 1934),
(9, 'Czelnai Rudolf', 1935),
(10, 'Maár-Laza Bori', 1965),
(11, 'Orbán László', 1983),
(12, 'Aigner Szilárd', 1915),
(13, 'Aigner Szilárd', 1922),
(14, 'Greguss Gyula', 1941),
(15, 'Orbán László', 1957);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `meteorologusok`
--
ALTER TABLE `meteorologusok`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `meteorologusok`
--
ALTER TABLE `meteorologusok`
  MODIFY `id` mediumint(8) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
