USE [master]
GO
/****** Object:  Database [QuanLyThuVien]    Script Date: 25/06/2020 8:28:25 PM ******/
CREATE DATABASE [QuanLyThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyThuVien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyThuVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyThuVien] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyThuVien', N'ON'
GO
ALTER DATABASE [QuanLyThuVien] SET QUERY_STORE = OFF
GO
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[CTMuonSach]    Script Date: 25/06/2020 8:28:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTMuonSach](
	[MaMuon] [varchar](10) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[TrangThai] [bit] NULL,
	[GiaSach] [money] NULL,
 CONSTRAINT [pk_CTMuonSach] PRIMARY KEY CLUSTERED 
(
	[MaMuon] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTNhapSach]    Script Date: 25/06/2020 8:28:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTNhapSach](
	[MaNhap] [varchar](10) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [pk_CTNhapSach] PRIMARY KEY CLUSTERED 
(
	[MaNhap] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTTraSach]    Script Date: 25/06/2020 8:28:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTTraSach](
	[MaTra] [varchar](10) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
	[NgayTra] [date] NULL,
	[SoLuong] [int] NULL,
	[TienPhat] [money] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [pk_CTTraSach] PRIMARY KEY CLUSTERED 
(
	[MaTra] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DauSach]    Script Date: 25/06/2020 8:28:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DauSach](
	[MaDauSach] [varchar](10) NOT NULL,
	[TenDauSach] [nvarchar](100) NOT NULL,
	[MaTheLoai] [varchar](10) NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 25/06/2020 8:28:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [varchar](10) NOT NULL,
	[TenDocGia] [nvarchar](100) NULL,
	[CMND] [varchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoThe] [varchar](10) NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuonSach]    Script Date: 25/06/2020 8:28:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuonSach](
	[MaMuon] [varchar](10) NOT NULL,
	[SoThe] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
	[NgayMuon] [date] NULL,
	[NgayPhaiTra] [date] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 25/06/2020 8:28:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[HoTenNV] [nvarchar](100) NULL,
	[NgSinh] [date] NULL,
	[SDT] [varchar](10) NULL,
	[TaiKhoan] [varchar](100) NULL,
	[MatKhau] [varchar](100) NULL,
	[TrangThai] [bit] NULL,
	[Quyen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhapSach]    Script Date: 25/06/2020 8:28:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapSach](
	[MaNhap] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NULL,
	[NgayNhap] [date] NULL,
	[ThanhTien] [money] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 25/06/2020 8:28:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [varchar](10) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[MaDauSach] [varchar](10) NULL,
	[TenTacGia] [nvarchar](100) NULL,
	[TenNhaXuatBan] [nvarchar](100) NULL,
	[NamXuatBan] [int] NULL,
	[DonGia] [money] NULL,
	[TrangThai] [bit] NULL,
	[SoLuong] [int] NULL,
	[SachHiem] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 25/06/2020 8:28:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [varchar](10) NOT NULL,
	[TenTheLoai] [nvarchar](100) NOT NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheThuVien]    Script Date: 25/06/2020 8:28:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheThuVien](
	[SoThe] [varchar](10) NOT NULL,
	[NgayBatDau] [datetime] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraSach]    Script Date: 25/06/2020 8:28:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraSach](
	[MaTra] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaMuon] [varchar](10) NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000001', N'Sa00000001', 1, 1, 0.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000002', N'Sa00000001', 1, 1, 0.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000003', N'Sa00000003', 1, 1, 219000.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000004', N'Sa00000004', 1, 1, 10000.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000005', N'Sa00000005', 1, 1, 8700.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000006', N'Sa00000006', 1, 1, 45000.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000007', N'Sa00000002', 1, 1, 85000.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000008', N'Sa00000002', 2, 1, 0.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000009', N'Sa00000010', 5, 1, 0.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000010', N'Sa00000002', 1, 1, 0.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000010', N'Sa00000003', 1, 1, 0.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000012', N'Sa00000007', 1, 1, 0.0000)
INSERT [dbo].[CTMuonSach] ([MaMuon], [MaSach], [SoLuong], [TrangThai], [GiaSach]) VALUES (N'MS0000014', N'Sa00000005', 1, 1, 0.0000)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000001', N'Sa00000001', 2, 120000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000002', N'Sa00000002', 2, 85000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000003', N'Sa00000003', 2, 219000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000004', N'Sa00000004', 2, 10000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000005', N'Sa00000005', 2, 8700, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000006', N'Sa00000006', 2, 45000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000007', N'Sa00000008', 5, 40000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000008', N'Sa00000001', 5, 120000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000009', N'Sa00000008', 6, 40000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000010', N'Sa00000009', 5, 30000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000011', N'Sa00000009', 6, 30000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000012', N'Sa00000010', 5, 100000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000013', N'Sa00000010', 6, 100000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000014', N'Sa00000010', 3, 100000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000015', N'Sa00000007', 3, 60000, 1)
INSERT [dbo].[CTNhapSach] ([MaNhap], [MaSach], [SoLuong], [DonGia], [TrangThai]) VALUES (N'MN00000016', N'Sa00000011', 3, 50000, 1)
INSERT [dbo].[CTTraSach] ([MaTra], [MaSach], [NgayTra], [SoLuong], [TienPhat], [TrangThai]) VALUES (N'MT00000001', N'Sa00000001', CAST(N'2020-03-10' AS Date), 1, 0.0000, 0)
INSERT [dbo].[CTTraSach] ([MaTra], [MaSach], [NgayTra], [SoLuong], [TienPhat], [TrangThai]) VALUES (N'MT00000002', N'Sa00000002', CAST(N'2020-03-12' AS Date), 1, 0.0000, 0)
INSERT [dbo].[CTTraSach] ([MaTra], [MaSach], [NgayTra], [SoLuong], [TienPhat], [TrangThai]) VALUES (N'MT00000003', N'Sa00000003', CAST(N'2020-03-12' AS Date), 1, 0.0000, 0)
INSERT [dbo].[CTTraSach] ([MaTra], [MaSach], [NgayTra], [SoLuong], [TienPhat], [TrangThai]) VALUES (N'MT00000004', N'Sa00000004', CAST(N'2020-03-17' AS Date), 1, 0.0000, 0)
INSERT [dbo].[CTTraSach] ([MaTra], [MaSach], [NgayTra], [SoLuong], [TienPhat], [TrangThai]) VALUES (N'MT00000005', N'Sa00000005', CAST(N'2020-03-25' AS Date), 1, 8700.0000, 1)
INSERT [dbo].[DauSach] ([MaDauSach], [TenDauSach], [MaTheLoai], [TrangThai]) VALUES (N'DS00000001', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', N'TL00000001', 1)
INSERT [dbo].[DauSach] ([MaDauSach], [TenDauSach], [MaTheLoai], [TrangThai]) VALUES (N'DS00000002', N'Cho Tôi Một Vé Đi Tuổi Thơ', N'TL00000001', 1)
INSERT [dbo].[DauSach] ([MaDauSach], [TenDauSach], [MaTheLoai], [TrangThai]) VALUES (N'DS00000003', N'Thời Niên Thiếu Của Anh Và Em', N'TL00000001', 1)
INSERT [dbo].[DauSach] ([MaDauSach], [TenDauSach], [MaTheLoai], [TrangThai]) VALUES (N'DS00000004', N'Tiếng Việt Lớp 1', N'TL00000006', 1)
INSERT [dbo].[DauSach] ([MaDauSach], [TenDauSach], [MaTheLoai], [TrangThai]) VALUES (N'DS00000005', N'Hình Học 12', N'TL00000006', 1)
INSERT [dbo].[DauSach] ([MaDauSach], [TenDauSach], [MaTheLoai], [TrangThai]) VALUES (N'DS00000006', N'Công Nghệ 12', N'TL00000006', 1)
INSERT [dbo].[DauSach] ([MaDauSach], [TenDauSach], [MaTheLoai], [TrangThai]) VALUES (N'DS00000007', N'Nuôi Con Không Phải Là Cuộc Chiến 2', N'TL00000005', 1)
INSERT [dbo].[DauSach] ([MaDauSach], [TenDauSach], [MaTheLoai], [TrangThai]) VALUES (N'DS00000008', N'Học Vẽ Bằng Hình Cơ Bản - Nghệ Thuật Là Đơn Giản', N'TL00000003', 1)
INSERT [dbo].[DauSach] ([MaDauSach], [TenDauSach], [MaTheLoai], [TrangThai]) VALUES (N'DS00000009', N'Harry Potter', N'TL00000009', 1)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000001', N'Lê Văn Ấn', N'222222222', N'Quảng Ngãi', N'Th00000001', 1)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000002', N'Tăng Tử Bình', N'555555555', N'Sài Gòn', N'Th00000002', 1)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000003', N'Nguyễn Thái Bình', N'777777777', N'Đắk Nông', N'Th00000003', 1)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000004', N'Nguyễn Chí Bình', N'888888888', N'Bình Thuận', N'Th00000004', 1)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000005', N'Hồ Dũng', N'333333333', N'Thủ Dầu Một', N'Th00000005', 1)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000006', N'Huỳnh Văn Bình', N'111111111', N'Cái Bè', N'Th00000006', 1)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000007', N'Hải Định', N'0909090909', N'Đồng Nai', N'Th00000007', 1)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000008', N'Trọng Nhân', N'444444444', N'Mỹ Tho', N'Th00000008', 0)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000009', N'Công Nhịn', N'999999999', N'Sài Gòn', N'Th00000009', 0)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000010', N'Nguyen Minh Anh', N'1212121212', N'Tp HCM', N'Th00000011', 0)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000011', N'Lê Văn D', N'1029120233', N'123 Phan Văn Trị , quận Gò Vấp, tp Hà Nội', N'Th00000012', 0)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [CMND], [DiaChi], [SoThe], [TrangThai]) VALUES (N'DG00000012', N'Bùi Lê Minh', N'8282828282', N'Vũng Tàu', N'Th00000013', 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000001', N'Th00000001', N'NV00000001', CAST(N'2020-03-01' AS Date), CAST(N'2020-03-15' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000002', N'Th00000001', N'NV00000001', CAST(N'2020-03-02' AS Date), CAST(N'2020-03-16' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000003', N'Th00000003', N'NV00000003', CAST(N'2020-03-04' AS Date), CAST(N'2020-03-18' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000004', N'Th00000004', N'NV00000002', CAST(N'2020-03-05' AS Date), CAST(N'2020-03-19' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000005', N'Th00000007', N'NV00000002', CAST(N'2020-03-09' AS Date), CAST(N'2020-03-23' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000006', N'Th00000004', N'NV00000005', CAST(N'2020-03-12' AS Date), CAST(N'2020-03-26' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000007', N'Th00000006', N'NV00000002', CAST(N'2020-06-25' AS Date), NULL, 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000008', N'Th00000005', N'NV00000002', CAST(N'2020-06-25' AS Date), NULL, 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000009', N'Th00000004', N'NV00000004', CAST(N'2020-06-25' AS Date), CAST(N'2020-06-25' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000010', N'Th00000001', N'NV00000002', CAST(N'2020-06-25' AS Date), CAST(N'2020-06-25' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000011', N'Th00000003', N'NV00000003', CAST(N'2020-06-25' AS Date), CAST(N'2020-06-25' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000012', N'Th00000008', N'NV00000003', CAST(N'2020-06-25' AS Date), CAST(N'2020-06-25' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000013', N'Th00000007', N'NV00000003', CAST(N'2020-06-25' AS Date), CAST(N'2020-06-25' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000014', N'Th00000001', N'NV00000002', CAST(N'2020-06-25' AS Date), CAST(N'2020-06-25' AS Date), 1)
INSERT [dbo].[MuonSach] ([MaMuon], [SoThe], [MaNV], [NgayMuon], [NgayPhaiTra], [TrangThai]) VALUES (N'MS0000015', N'Th00000001', N'NV00000002', CAST(N'2020-06-25' AS Date), CAST(N'2020-06-25' AS Date), 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000001', N'Trần Quang Khải', CAST(N'1991-11-08' AS Date), N'3333333333', N'matttran123', N'e11170b8cbd2d74102651cb967fa28e5', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000002', N'Lê Viết Hoàng Nguyên', CAST(N'1988-08-16' AS Date), N'5555555555', N'nguyenle123', N'e11170b8cbd2d74102651cb967fa28e5', 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000003', N'Bùi Đình Đức', CAST(N'1997-02-21' AS Date), N'0377699382', N'ducdev', N'713124191539dbb39d30a8fff96ecc04', 1, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000004', N'Nguyễn Minh Anh', CAST(N'2000-10-04' AS Date), N'8888888888', N'clementinenguyen', N'e11170b8cbd2d74102651cb967fa28e5', 1, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000005', N'Phạm Nguyễn Ngọc Đạt', CAST(N'2000-12-07' AS Date), N'6666666666', N'irene123', N'e11170b8cbd2d74102651cb967fa28e5', 1, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000006', N'Nguyễn Văn D', CAST(N'2020-05-20' AS Date), N'0123456798', N'abcdef', N'202cb962ac59075b964b07152d234b70', 0, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000007', N'Nguyễn Thị B', CAST(N'2020-06-13' AS Date), N'0987654321', N'duke36a1', N'ced91c3fe6ee4afb5205724ed1ab4c8a', 0, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000008', N'Lê Văn F', CAST(N'2000-05-21' AS Date), N'1231231231', N'abc', N'202cb962ac59075b964b07152d234b70', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000009', N'', CAST(N'2020-06-13' AS Date), N'', N'', N'd41d8cd98f00b204e9800998ecf8427e', 0, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000010', N'Nguyễn Thành Trung', CAST(N'2000-09-01' AS Date), N'0909127941', N'trung123', N'1c5bfbacb1230f11c9aabdf7f3027eac', 1, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000011', N'abcdef', CAST(N'2020-06-23' AS Date), N'123', N'abc', N'202cb962ac59075b964b07152d234b70', 0, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000012', N'1', CAST(N'2020-06-23' AS Date), N'1', N'1', N'c4ca4238a0b923820dcc509a6f75849b', 0, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000013', N'123', CAST(N'2020-06-23' AS Date), N'123', N'qwe', N'c4ca4238a0b923820dcc509a6f75849b', 0, 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [SDT], [TaiKhoan], [MatKhau], [TrangThai], [Quyen]) VALUES (N'NV00000014', N'nguyen van a', CAST(N'2020-06-23' AS Date), N'123', N'duhauh', N'202cb962ac59075b964b07152d234b70', 0, 0)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000001', N'NV00000001', CAST(N'2020-01-05' AS Date), 240000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000002', N'NV00000003', CAST(N'2020-01-06' AS Date), 170000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000003', N'NV00000002', CAST(N'2020-01-06' AS Date), 438000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000004', N'NV00000003', CAST(N'2020-01-07' AS Date), 20000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000005', N'NV00000001', CAST(N'2020-01-07' AS Date), 17400.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000006', N'NV00000004', CAST(N'2020-01-09' AS Date), 90000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000007', N'NV00000002', CAST(N'2020-06-20' AS Date), 200000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000008', N'NV00000002', CAST(N'2020-06-20' AS Date), 600000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000009', N'NV00000002', CAST(N'2020-06-20' AS Date), 240000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000010', N'NV00000002', CAST(N'2020-06-22' AS Date), 150000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000011', N'NV00000002', CAST(N'2020-06-22' AS Date), 180000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000012', N'NV00000002', CAST(N'2020-06-22' AS Date), 500000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000013', N'NV00000002', CAST(N'2020-06-22' AS Date), 600000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000014', N'NV00000002', CAST(N'2020-06-22' AS Date), 300000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000015', N'NV00000002', CAST(N'2020-06-23' AS Date), 180000.0000, 1)
INSERT [dbo].[NhapSach] ([MaNhap], [MaNV], [NgayNhap], [ThanhTien], [TrangThai]) VALUES (N'MN00000016', N'NV00000002', CAST(N'2020-06-23' AS Date), 150000.0000, 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000001', N'Thời Niên Thiếu Của Anh Và Em', N'DS00000003', N'Cửu Nguyệt Hi', N'Nhà Xuất Bản Hà Nội', 2019, 120000.0000, 1, 17, 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000002', N'Học Vẽ Bằng Hình Cơ Bản - Nghệ Thuật Là Đơn Giản', N'DS00000008', N'Rosa M. Curto', N'Nhà Xuất Bản Hội Nhà Văn', 2016, 85000.0000, 1, 2, 0)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000003', N'Nuôi Con Không Phải Là Cuộc Chiến 2', N'DS00000007', N'Hachun Lyonet (Hà Chũn)', N'Nhà Xuất Bản Lao Động', 2018, 219000.0000, 1, 5, 0)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000004', N'Công Nghệ 12', N'DS00000006', N'Đào Thị Hồng', N'Nhà Xuất Bản Giáo Dục Việt Nam', 2020, 10000.0000, 1, 4, 0)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000005', N'Hình Học 12', N'DS00000005', N'Phương Hà Lan', N'Nhà Xuất Bản Giáo Dục Việt Nam', 2020, 87000.0000, 1, 4, 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000006', N'Cho Tôi Một Vé Đi Tuổi Thơ', N'DS00000002', N'Nguyễn Nhật Ánh', N'Nhà Xuất Bản Trẻ', 2010, 45000.0000, 1, 8, 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000007', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', N'DS00000001', N'Nguyễn Nhật Ánh', N'Nhà Xuất Bản Trẻ', 2012, 60000.0000, 1, 6, 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000008', N'Tiếng Việt Lớp 1', N'DS00000001', N'Bùi Xuân Huấn', N'Nhà Xuất Bản Giáo Dục', 2019, 40000.0000, 1, 11, 0)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000009', N'Tiếng Việt Lớp 2', N'DS00000004', N'Bùi Xuân Huấn', N'Nhà Xuất Bản Giáo Dục', 2019, 30000.0000, 1, 6, 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000010', N'Vẽ Đơn Giản', N'DS00000008', N'Hiếu Nhân', N'Nhà Xuất Bản Giáo Dục', 2008, 100000.0000, 1, 14, 0)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaDauSach], [TenTacGia], [TenNhaXuatBan], [NamXuatBan], [DonGia], [TrangThai], [SoLuong], [SachHiem]) VALUES (N'Sa00000011', N'Harry Potter Tập 1', N'DS00000009', N'JK.Rowling', N'Nhà Xuất Bản Kim Đồng', 2000, 50000.0000, 1, 3, 0)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [TrangThai]) VALUES (N'TL00000001', N'Văn học', 1)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [TrangThai]) VALUES (N'TL00000002', N'Kinh tế', 1)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [TrangThai]) VALUES (N'TL00000003', N'Thiếu nhi', 1)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [TrangThai]) VALUES (N'TL00000004', N'Kĩ năng sống', 1)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [TrangThai]) VALUES (N'TL00000005', N'Bà mẹ - Em bé', 1)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [TrangThai]) VALUES (N'TL00000006', N'Giáo khoa - Giáo trình', 1)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [TrangThai]) VALUES (N'TL00000007', N'Kinh dị', 1)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [TrangThai]) VALUES (N'TL00000008', N'Truyện cười', 1)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [TrangThai]) VALUES (N'TL00000009', N'Phép thuật', 1)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000001', CAST(N'2012-02-02T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000002', CAST(N'2012-02-13T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000003', CAST(N'2012-02-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000004', CAST(N'2012-02-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000005', CAST(N'2012-02-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000006', CAST(N'2012-02-21T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000007', CAST(N'2012-02-25T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000008', CAST(N'2012-02-27T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000009', CAST(N'2012-02-26T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000010', CAST(N'2020-06-15T13:50:49.060' AS DateTime), 1)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000011', CAST(N'2020-06-15T13:54:01.663' AS DateTime), 0)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000012', CAST(N'2020-06-11T20:35:03.000' AS DateTime), 0)
INSERT [dbo].[TheThuVien] ([SoThe], [NgayBatDau], [TrangThai]) VALUES (N'Th00000013', CAST(N'2020-06-22T15:04:14.237' AS DateTime), 1)
INSERT [dbo].[TraSach] ([MaTra], [NgayLap], [MaMuon], [TrangThai]) VALUES (N'MT00000001', CAST(N'2020-03-15' AS Date), N'MS0000001', 1)
INSERT [dbo].[TraSach] ([MaTra], [NgayLap], [MaMuon], [TrangThai]) VALUES (N'MT00000002', CAST(N'2020-03-16' AS Date), N'MS0000002', 1)
INSERT [dbo].[TraSach] ([MaTra], [NgayLap], [MaMuon], [TrangThai]) VALUES (N'MT00000003', CAST(N'2020-03-18' AS Date), N'MS0000003', 1)
INSERT [dbo].[TraSach] ([MaTra], [NgayLap], [MaMuon], [TrangThai]) VALUES (N'MT00000004', CAST(N'2020-03-19' AS Date), N'MS0000004', 1)
INSERT [dbo].[TraSach] ([MaTra], [NgayLap], [MaMuon], [TrangThai]) VALUES (N'MT00000005', CAST(N'2020-03-23' AS Date), N'MS0000005', 1)
INSERT [dbo].[TraSach] ([MaTra], [NgayLap], [MaMuon], [TrangThai]) VALUES (N'MT00000006', CAST(N'2020-02-20' AS Date), N'MS0000001', 1)
ALTER TABLE [dbo].[NhapSach] ADD  CONSTRAINT [DF_NhapSach_ThanhTien]  DEFAULT ((0)) FOR [ThanhTien]
GO
ALTER TABLE [dbo].[CTMuonSach]  WITH CHECK ADD  CONSTRAINT [fk_CTMuonSach_MuonSach] FOREIGN KEY([MaMuon])
REFERENCES [dbo].[MuonSach] ([MaMuon])
GO
ALTER TABLE [dbo].[CTMuonSach] CHECK CONSTRAINT [fk_CTMuonSach_MuonSach]
GO
ALTER TABLE [dbo].[CTMuonSach]  WITH CHECK ADD  CONSTRAINT [fk_CTMuonSach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[CTMuonSach] CHECK CONSTRAINT [fk_CTMuonSach_Sach]
GO
ALTER TABLE [dbo].[CTNhapSach]  WITH CHECK ADD  CONSTRAINT [fk_CTNhapSach_NhapSach] FOREIGN KEY([MaNhap])
REFERENCES [dbo].[NhapSach] ([MaNhap])
GO
ALTER TABLE [dbo].[CTNhapSach] CHECK CONSTRAINT [fk_CTNhapSach_NhapSach]
GO
ALTER TABLE [dbo].[CTNhapSach]  WITH CHECK ADD  CONSTRAINT [fk_CTNhapSach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[CTNhapSach] CHECK CONSTRAINT [fk_CTNhapSach_Sach]
GO
ALTER TABLE [dbo].[CTTraSach]  WITH CHECK ADD  CONSTRAINT [fk_CTTraSach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[CTTraSach] CHECK CONSTRAINT [fk_CTTraSach_Sach]
GO
ALTER TABLE [dbo].[CTTraSach]  WITH CHECK ADD  CONSTRAINT [fk_CTTraSach_TraSach] FOREIGN KEY([MaTra])
REFERENCES [dbo].[TraSach] ([MaTra])
GO
ALTER TABLE [dbo].[CTTraSach] CHECK CONSTRAINT [fk_CTTraSach_TraSach]
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD  CONSTRAINT [fk_DauSach_TheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[DauSach] CHECK CONSTRAINT [fk_DauSach_TheLoai]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [fk_DocGia_TheThuVien] FOREIGN KEY([SoThe])
REFERENCES [dbo].[TheThuVien] ([SoThe])
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [fk_DocGia_TheThuVien]
GO
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD  CONSTRAINT [fk_MuonSach_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[MuonSach] CHECK CONSTRAINT [fk_MuonSach_NhanVien]
GO
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD  CONSTRAINT [fk_MuonSach_TheThuVien] FOREIGN KEY([SoThe])
REFERENCES [dbo].[TheThuVien] ([SoThe])
GO
ALTER TABLE [dbo].[MuonSach] CHECK CONSTRAINT [fk_MuonSach_TheThuVien]
GO
ALTER TABLE [dbo].[NhapSach]  WITH CHECK ADD  CONSTRAINT [fk_NhapSach_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhapSach] CHECK CONSTRAINT [fk_NhapSach_NhanVien]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [fk_Sach_DauSach] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DauSach] ([MaDauSach])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [fk_Sach_DauSach]
GO
ALTER TABLE [dbo].[TraSach]  WITH CHECK ADD  CONSTRAINT [fk_TraSach_MuonSach] FOREIGN KEY([MaMuon])
REFERENCES [dbo].[MuonSach] ([MaMuon])
GO
ALTER TABLE [dbo].[TraSach] CHECK CONSTRAINT [fk_TraSach_MuonSach]
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVien] SET  READ_WRITE 
GO
