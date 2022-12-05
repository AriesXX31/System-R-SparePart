-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2022 at 03:45 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rsparepart`
--

-- --------------------------------------------------------

--
-- Table structure for table `rsp_admin`
--

CREATE TABLE `rsp_admin` (
  `id_pengguna` int(11) NOT NULL,
  `level_pengguna` varchar(20) NOT NULL,
  `username_pengguna` varchar(20) NOT NULL,
  `password_pengguna` varchar(20) NOT NULL,
  `email_pengguna` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rsp_admin`
--

INSERT INTO `rsp_admin` (`id_pengguna`, `level_pengguna`, `username_pengguna`, `password_pengguna`, `email_pengguna`) VALUES
(1, 'admin', 'Ethan', 'admin01', 'Ethansc31@gmail.com'),
(2, 'admin', 'Nayla', 'admin02', 'Nayla21@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `rsp_customer`
--

CREATE TABLE `rsp_customer` (
  `id_pelanggan` int(11) NOT NULL,
  `username_pelanggan` varchar(20) NOT NULL,
  `password_pelanggan` varchar(20) NOT NULL,
  `nama_lengkap` varchar(50) NOT NULL,
  `nomor_telepon` varchar(12) NOT NULL,
  `alamat_pelanggan` varchar(50) NOT NULL,
  `nomor_ktp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rsp_customer`
--

INSERT INTO `rsp_customer` (`id_pelanggan`, `username_pelanggan`, `password_pelanggan`, `nama_lengkap`, `nomor_telepon`, `alamat_pelanggan`, `nomor_ktp`) VALUES
(1, 'Renaldy', 'richard3103', 'Renaldy Richard Lawongan', '082187910534', 'Btn. Walenusantara Blok A No. 80', '71710831030002'),
(3, 'Mogandi ', 'mogans9090', 'Mogandi Timotius Abram', '082913412314', 'Airmadidi Atas', '717108231347422'),
(5, 'Claudia', 'claudiaong30', 'AnggreinyClaudia', '089823272056', 'Tobelo, City Mall, Blok C. No 4', '71710831993700');

-- --------------------------------------------------------

--
-- Table structure for table `rsp_data_transaksi`
--

CREATE TABLE `rsp_data_transaksi` (
  `id_transaksi` int(11) NOT NULL,
  `id_pengguna` int(3) NOT NULL,
  `id_pelanggan` int(6) NOT NULL,
  `alamat_pelanggan` varchar(50) NOT NULL,
  `id_produk` int(11) NOT NULL,
  `kode_barang` varchar(30) NOT NULL,
  `nama_barang` varchar(30) NOT NULL,
  `jumlah_barang` int(3) NOT NULL,
  `total_harga` int(30) NOT NULL,
  `id_jasa_ekspedisi` int(11) NOT NULL,
  `jenis_pengiriman` varchar(10) NOT NULL,
  `kode_pengiriman` varchar(30) NOT NULL,
  `tgl_pemesanan` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rsp_data_transaksi`
--

INSERT INTO `rsp_data_transaksi` (`id_transaksi`, `id_pengguna`, `id_pelanggan`, `alamat_pelanggan`, `id_produk`, `kode_barang`, `nama_barang`, `jumlah_barang`, `total_harga`, `id_jasa_ekspedisi`, `jenis_pengiriman`, `kode_pengiriman`, `tgl_pemesanan`) VALUES
(1, 1, 1, 'Btn. Walenusantara Blok A No. 80', 1, '5521-ZOI-PA10', 'Brake Disc', 1, 170000, 1, 'Regular', '1130', '0000-00-00 00:00:00'),
(5, 1, 1, 'Btn. Walenusantara Blok A No. 80', 1, '5521-ZOI-PA10', 'Air Filter', 1, 339000, 1, 'Regular', '1129', '0000-00-00 00:00:00'),
(7, 1, 1, 'Btn. Walenusantara Blok A No. 80', 2, 'S120-AA1-200', 'Break Disc', 4, 719000, 1, 'Regular', '1129', '0000-00-00 00:00:00'),
(8, 2, 3, 'Airmadidi Atas', 2, 'S120-AA1-200', 'Break Disc', 2, 396000, 3, 'Regular', '1133', '0000-00-00 00:00:00'),
(9, 2, 1, 'Btn. Walenusantara Blok A No. 80', 4, 'ZZE-335-441', 'Bumper Custom EDM', 4, 96039000, 1, 'Regular', '1129', '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `rsp_jasa_ekspedisi`
--

CREATE TABLE `rsp_jasa_ekspedisi` (
  `id_jasa_ekspedisi` int(11) NOT NULL,
  `nama_ekspedisi` varchar(10) NOT NULL,
  `jenis_pengiriman` varchar(10) NOT NULL,
  `harga_per_kilogram` int(30) NOT NULL,
  `rute` varchar(50) NOT NULL,
  `harga_per_rute` int(30) NOT NULL,
  `waktu_pengiriman` varchar(7) NOT NULL,
  `kode_pengiriman` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rsp_jasa_ekspedisi`
--

INSERT INTO `rsp_jasa_ekspedisi` (`id_jasa_ekspedisi`, `nama_ekspedisi`, `jenis_pengiriman`, `harga_per_kilogram`, `rute`, `harga_per_rute`, `waktu_pengiriman`, `kode_pengiriman`) VALUES
(1, 'JNE', 'Regular', 24000, 'Manado-Makassar', 15000, '3 Hari', '1129'),
(3, 'JNT', 'Regular', 35000, 'Manado-Jakarta', 21000, '3 Hari', '1133');

-- --------------------------------------------------------

--
-- Table structure for table `rsp_produk_onderdil`
--

CREATE TABLE `rsp_produk_onderdil` (
  `id_produk` int(11) NOT NULL,
  `kode_barang` varchar(30) NOT NULL,
  `nomor_seri` int(2) NOT NULL,
  `nama_barang` varchar(30) NOT NULL,
  `merek_barang` varchar(20) NOT NULL,
  `harga_barang` int(30) NOT NULL,
  `satuan` varchar(10) NOT NULL,
  `warna` varchar(20) NOT NULL,
  `tahun_pembuatan` int(4) NOT NULL,
  `rata_pemakaian` varchar(10) NOT NULL,
  `jenis_mobil` varchar(30) NOT NULL,
  `deskripsi_barang` varchar(255) NOT NULL,
  `garansi` varchar(10) NOT NULL,
  `stok_barang` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rsp_produk_onderdil`
--

INSERT INTO `rsp_produk_onderdil` (`id_produk`, `kode_barang`, `nomor_seri`, `nama_barang`, `merek_barang`, `harga_barang`, `satuan`, `warna`, `tahun_pembuatan`, `rata_pemakaian`, `jenis_mobil`, `deskripsi_barang`, `garansi`, `stok_barang`) VALUES
(1, '5521-ZOI-PA10', 4, 'Air Filter', 'Honda', 300000, 'Unit', 'Hitam', 2021, '10 Tahun', 'Honda', 'Produk untuk CRV dan Civic', '1 Tahun', 56),
(2, 'S120-AA1-200', 6, 'Break Disc (ORI)', 'Honda', 170000, 'Unit', 'Silver', 2021, '10 Tahun', 'Honda', 'Produk untuk Mobilio', '5 Tahun', 80),
(3, 'EPT-300-O21', 2, 'Piston Ring', 'Honda', 210000, 'Unit', 'Silver', 2014, '10 Tahun', 'Honda', 'Catatan: Khusus mobil honda untuk model keluaran tahun 2014 ke bawah.', '3 Tahun', 25),
(4, 'ZZE-335-441', 2, 'Bumper Custom EDM', 'HSR', 24000000, 'Set', 'Putih', 2015, 'Kosong', 'Mobilio', 'Produk ini khusus mobilio tipe RS.', '1Tahun', 6);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `rsp_admin`
--
ALTER TABLE `rsp_admin`
  ADD PRIMARY KEY (`id_pengguna`),
  ADD KEY `id_pengguna` (`id_pengguna`);

--
-- Indexes for table `rsp_customer`
--
ALTER TABLE `rsp_customer`
  ADD PRIMARY KEY (`id_pelanggan`),
  ADD KEY `id_pelanggan` (`id_pelanggan`),
  ADD KEY `alamat_pelanggan` (`alamat_pelanggan`);

--
-- Indexes for table `rsp_data_transaksi`
--
ALTER TABLE `rsp_data_transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `id_produk` (`id_produk`),
  ADD KEY `id_jasa_ekspedisi` (`id_jasa_ekspedisi`),
  ADD KEY `id_pengguna` (`id_pengguna`),
  ADD KEY `id_pelanggan` (`id_pelanggan`);

--
-- Indexes for table `rsp_jasa_ekspedisi`
--
ALTER TABLE `rsp_jasa_ekspedisi`
  ADD PRIMARY KEY (`id_jasa_ekspedisi`),
  ADD KEY `id_jasa_ekspedisi` (`id_jasa_ekspedisi`),
  ADD KEY `kode_pengiriman` (`kode_pengiriman`);

--
-- Indexes for table `rsp_produk_onderdil`
--
ALTER TABLE `rsp_produk_onderdil`
  ADD PRIMARY KEY (`id_produk`),
  ADD KEY `id_produk` (`id_produk`),
  ADD KEY `kode_barang` (`kode_barang`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `rsp_admin`
--
ALTER TABLE `rsp_admin`
  MODIFY `id_pengguna` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `rsp_customer`
--
ALTER TABLE `rsp_customer`
  MODIFY `id_pelanggan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `rsp_data_transaksi`
--
ALTER TABLE `rsp_data_transaksi`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `rsp_jasa_ekspedisi`
--
ALTER TABLE `rsp_jasa_ekspedisi`
  MODIFY `id_jasa_ekspedisi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `rsp_produk_onderdil`
--
ALTER TABLE `rsp_produk_onderdil`
  MODIFY `id_produk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2558;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `rsp_data_transaksi`
--
ALTER TABLE `rsp_data_transaksi`
  ADD CONSTRAINT `rsp_data_transaksi_ibfk_1` FOREIGN KEY (`id_produk`) REFERENCES `rsp_produk_onderdil` (`id_produk`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `rsp_data_transaksi_ibfk_2` FOREIGN KEY (`id_jasa_ekspedisi`) REFERENCES `rsp_jasa_ekspedisi` (`id_jasa_ekspedisi`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `rsp_data_transaksi_ibfk_3` FOREIGN KEY (`id_pengguna`) REFERENCES `rsp_admin` (`id_pengguna`),
  ADD CONSTRAINT `rsp_data_transaksi_ibfk_4` FOREIGN KEY (`id_pelanggan`) REFERENCES `rsp_customer` (`id_pelanggan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
