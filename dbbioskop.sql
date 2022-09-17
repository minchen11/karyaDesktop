-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 17 Sep 2022 pada 14.47
-- Versi server: 10.4.22-MariaDB
-- Versi PHP: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbbioskop`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `account`
--

CREATE TABLE `account` (
  `id_karyawan` int(8) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `admin_level` enum('Administrator','Operator') NOT NULL DEFAULT 'Operator',
  `nama` varchar(25) NOT NULL,
  `No_Hp` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `account`
--

INSERT INTO `account` (`id_karyawan`, `username`, `password`, `admin_level`, `nama`, `No_Hp`) VALUES
(1, 'username', 'pass', 'Administrator', 'Dimas', '085242306142'),
(2, 'dimas', '123', 'Operator', 'dimas', '081'),
(55, 'asdasd', '123', 'Operator', 'sdas', 'asdad');

-- --------------------------------------------------------

--
-- Struktur dari tabel `film`
--

CREATE TABLE `film` (
  `id_film` int(8) NOT NULL,
  `nama_film` varchar(25) NOT NULL,
  `jadwal_tayang` date NOT NULL,
  `jam_tayang` time NOT NULL DEFAULT current_timestamp(),
  `poster` varchar(100) NOT NULL,
  `id_studio` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `film`
--

INSERT INTO `film` (`id_film`, `nama_film`, `jadwal_tayang`, `jam_tayang`, `poster`, `id_studio`) VALUES
(1, 'Lara Ati', '2022-09-15', '12:00:00', 'H:\\LaraAti.jpg', 1),
(2, 'Lara Ati', '2022-09-15', '14:00:00', 'H:\\LaraAti.jpg', 1),
(3, 'Lara Ati', '2022-09-15', '16:00:00', 'H:\\LaraAti.jpg', 1),
(4, 'Miracle In Cell No 7', '2022-09-15', '12:30:00', 'H:\\MiracleInCellNo7.jpg', 2),
(5, 'Miracle In Cell No 7', '2022-09-15', '13:30:00', 'H:\\MiracleInCellNo7.jpg', 2),
(6, 'Miracle In Cell No 7', '2022-09-15', '14:30:00', 'H:\\MiracleInCellNo7.jpg', 2),
(7, 'Mencuri Raden Saleh', '2022-09-15', '12:45:00', 'H:\\MencuriRadenSaleh.jpg', 3),
(8, 'Mencuri Raden Saleh', '2022-09-15', '14:45:00', 'H:\\MencuriRadenSaleh.jpg', 3),
(9, 'Mencuri Raden Saleh', '2022-09-15', '15:45:00', 'H:\\MencuriRadenSaleh.jpg', 3);

-- --------------------------------------------------------

--
-- Struktur dari tabel `kursi`
--

CREATE TABLE `kursi` (
  `id_kursi` int(2) NOT NULL,
  `no_kursi` varchar(2) NOT NULL,
  `id_studio` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `kursi`
--

INSERT INTO `kursi` (`id_kursi`, `no_kursi`, `id_studio`) VALUES
(1, 'A1', 1),
(2, 'A2', 1),
(3, 'A3', 1),
(4, 'A4', 1),
(5, 'A5', 1),
(6, 'A6', 1),
(7, 'A7', 1),
(8, 'A8', 1),
(9, 'B1', 1),
(10, 'B2', 1),
(11, 'B3', 1),
(12, 'B4', 1),
(13, 'B5', 1),
(14, 'B6', 1),
(15, 'B7', 1),
(16, 'B8', 1),
(17, 'A1', 1),
(18, 'A2', 1),
(19, 'A3', 1),
(20, 'A4', 1),
(21, 'A5', 1),
(22, 'A6', 1),
(23, 'A7', 1),
(24, 'A8', 1),
(25, 'B1', 1),
(26, 'B2', 1),
(27, 'B3', 1),
(28, 'B4', 1),
(29, 'B5', 1),
(30, 'B6', 1),
(31, 'B7', 1),
(32, 'B8', 1),
(33, 'C1', 1),
(34, 'C2', 1),
(35, 'C3', 1),
(36, 'C4', 1),
(37, 'C5', 1),
(38, 'C6', 1),
(39, 'C7', 1),
(40, 'C8', 1),
(41, 'D1', 1),
(42, 'D2', 1),
(43, 'D3', 1),
(44, 'D4', 1),
(45, 'D5', 1),
(46, 'D6', 1),
(47, 'D7', 1),
(48, 'D8', 1),
(49, 'C1', 1),
(50, 'C2', 1),
(51, 'C3', 1),
(52, 'C4', 1),
(53, 'C5', 1),
(54, 'C6', 1),
(55, 'C7', 1),
(56, 'C8', 1),
(57, 'D1', 1),
(58, 'D2', 1),
(59, 'D3', 1),
(60, 'D4', 1),
(61, 'D5', 1),
(62, 'D6', 1),
(63, 'D7', 1),
(64, 'D8', 1),
(65, 'A1', 2),
(66, 'A2', 2),
(67, 'A3', 2),
(68, 'A4', 2),
(69, 'A5', 2),
(70, 'A6', 2),
(71, 'A7', 2),
(72, 'A8', 2),
(73, 'B1', 2),
(74, 'B2', 2),
(75, 'B3', 2),
(76, 'B4', 2),
(77, 'B5', 2),
(78, 'B6', 2),
(79, 'B7', 2),
(80, 'B8', 2),
(81, 'C1', 2),
(82, 'C2', 2),
(83, 'C3', 2),
(84, 'C4', 2),
(85, 'C5', 2),
(86, 'C6', 2),
(87, 'C7', 2),
(88, 'C8', 2),
(89, 'D1', 2),
(90, 'D2', 2),
(91, 'D3', 2),
(92, 'D4', 2),
(93, 'D5', 2),
(94, 'D6', 2),
(95, 'D7', 2),
(96, 'D8', 2),
(97, 'A1', 3),
(98, 'A2', 3),
(99, 'A3', 3),
(100, 'A4', 3),
(101, 'A5', 3),
(102, 'A6', 3),
(103, 'A7', 3),
(104, 'A8', 3),
(105, 'B1', 3),
(106, 'B2', 3),
(107, 'B3', 3),
(108, 'B4', 3),
(109, 'B5', 3),
(110, 'B6', 3),
(111, 'B7', 3),
(112, 'B8', 3),
(113, 'C1', 3),
(114, 'C2', 3),
(115, 'C3', 3),
(116, 'C4', 3),
(117, 'C5', 3),
(118, 'C6', 3),
(119, 'C7', 3),
(120, 'C8', 3),
(121, 'D1', 3),
(122, 'D2', 3),
(123, 'D3', 3),
(124, 'D4', 3),
(125, 'D5', 3),
(126, 'D6', 3),
(127, 'D7', 3),
(128, 'D8', 3);

-- --------------------------------------------------------

--
-- Struktur dari tabel `studio`
--

CREATE TABLE `studio` (
  `id_studio` int(8) NOT NULL,
  `nama_studio` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `studio`
--

INSERT INTO `studio` (`id_studio`, `nama_studio`) VALUES
(1, 'Studio 1'),
(2, 'Studio 2'),
(3, 'Studio 3');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tiket`
--

CREATE TABLE `tiket` (
  `id_tiket` int(8) NOT NULL,
  `kursi_terjual` varchar(8) DEFAULT NULL,
  `Nama_film` varchar(32) NOT NULL,
  `tanggal` date NOT NULL,
  `Studio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tiket`
--

INSERT INTO `tiket` (`id_tiket`, `kursi_terjual`, `Nama_film`, `tanggal`, `Studio`) VALUES
(1, 'B2', '', '2022-09-16', 0),
(2, 'B3', '', '2022-09-16', 0),
(3, 'B2', '', '2022-09-16', 0),
(4, 'B2', '', '2022-09-16', 0),
(5, 'D4', '', '2022-09-16', 0),
(6, 'D5', '', '2022-09-16', 0),
(7, 'D6', '', '2022-09-16', 0),
(8, 'B1', '', '2022-09-16', 0),
(9, 'B2', '', '2022-09-16', 0),
(10, 'B3', '', '2022-09-16', 0),
(11, 'D4', '', '2022-09-16', 0),
(12, 'D5', '', '2022-09-16', 0),
(13, 'D6', '', '2022-09-16', 0),
(14, 'C4', '', '2022-09-16', 0),
(15, 'D4', '', '2022-09-16', 0),
(16, 'D5', '', '2022-09-16', 0),
(62, 'D7', '', '2022-09-17', 0),
(63, 'D8', '', '2022-09-17', 0),
(65, 'A3', '', '2022-09-17', 0),
(66, 'A4', '', '2022-09-17', 0),
(67, 'B4', '', '2022-09-17', 0),
(68, 'A2', '', '2022-09-17', 0),
(69, 'B2', '', '2022-09-17', 0),
(70, 'A1', '', '2022-09-17', 0),
(71, 'B3', '', '2022-09-17', 0),
(72, 'C4', '', '2022-09-17', 0),
(73, 'D1', '', '2022-09-17', 0),
(74, 'D2', '', '2022-09-17', 0),
(75, 'B1', '', '2022-09-17', 0),
(76, 'C3', '', '2022-09-17', 0),
(77, 'B5', '', '2022-09-17', 0),
(78, 'C5', '', '2022-09-17', 0),
(79, 'D4', '', '2022-09-17', 0),
(80, 'D5', '', '2022-09-17', 0),
(81, 'D6', '', '2022-09-17', 0),
(82, 'B6', '', '2022-09-17', 0),
(83, 'B8', '', '2022-09-17', 0),
(84, 'C6', '', '2022-09-17', 0),
(85, 'C7', '', '2022-09-17', 0),
(86, 'C8', '', '2022-09-17', 0),
(87, 'D3', '', '2022-09-17', 0),
(88, 'B7', '', '2022-09-17', 0),
(89, 'A5', '', '2022-09-17', 3),
(90, 'B3', '', '2022-09-17', 3);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`id_karyawan`);

--
-- Indeks untuk tabel `film`
--
ALTER TABLE `film`
  ADD PRIMARY KEY (`id_film`) USING BTREE,
  ADD KEY `id_studio` (`id_studio`);

--
-- Indeks untuk tabel `kursi`
--
ALTER TABLE `kursi`
  ADD PRIMARY KEY (`id_kursi`),
  ADD KEY `id_studio` (`id_studio`);

--
-- Indeks untuk tabel `studio`
--
ALTER TABLE `studio`
  ADD PRIMARY KEY (`id_studio`) USING BTREE;

--
-- Indeks untuk tabel `tiket`
--
ALTER TABLE `tiket`
  ADD PRIMARY KEY (`id_tiket`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `account`
--
ALTER TABLE `account`
  MODIFY `id_karyawan` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;

--
-- AUTO_INCREMENT untuk tabel `film`
--
ALTER TABLE `film`
  MODIFY `id_film` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT untuk tabel `kursi`
--
ALTER TABLE `kursi`
  MODIFY `id_kursi` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=129;

--
-- AUTO_INCREMENT untuk tabel `studio`
--
ALTER TABLE `studio`
  MODIFY `id_studio` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `tiket`
--
ALTER TABLE `tiket`
  MODIFY `id_tiket` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=91;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
