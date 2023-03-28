CREATE DATABASE MyShop
go

USE MyShop
go

CREATE TABLE NhaCungCap(
	IDNCC varchar(20) not null primary key,
	TenNCC nvarchar(50),
	DiaChi nvarchar(50),
	SDT int,
)
go

CREATE TABLE Account(
	IDAcc varchar(20) not null primary key,
	TenTK nvarchar(50),
	PassTK int
	
)
go

CREATE TABLE NhanVien(
	IDNV varchar(20) not null primary key, 
	TenNV nvarchar(50),
	SDT int,
	Luong float,
	IDAcc varchar(20)
	FOREIGN KEY (IDAcc) REFERENCES dbo.NhanVien(IDAcc)
)
go

CREATE TABLE PhieuNhap(
	IDPN varchar(20) not null primary key ,
	TenPN nvarchar(50),
	NgayNhap date,
	TongTien float,
	IDNCC varchar(20),
	IDNV varchar(20),
	FOREIGN KEY (IDNCC) REFERENCES dbo.NhaCungCap(IDNCC),
	FOREIGN KEY (IDNV) REFERENCES dbo.NhanVien(IDNV)
)
GO



CREATE TABLE SanPham(
	IDSP nvarchar(20) not null primary key,
	TenSP nvarchar(50),
	MauSac nvarchar(20),
	SLKho int,
	XuatXu nvarchar(20),
	GiaBan float,
	DonViTinh nvarchar(20) ,
)
go

CREATE TABLE KhachHang(
	IDKH varchar(20) primary key NOT NULL,
	TenKH nvarchar(20),
	SDT int,
)
go

CREATE TABLE HoaDon(
	IDHD varchar(20) not null primary key,
	NgayLap date,
	TongTien float,
	IDKH varchar(20),
	FOREIGN KEY (IDKH) REFERENCES dbo.KhachHang(IDKH)
)
go

CREATE TABLE ChiTietPN(
	IDCTPN INT IDENTITY(1,1) Primary key
	SoLuong int,
	DonGia float,
	IDSP nvarchar(20) NOT NULL,
	IDPN varchar(20) NOT NULL ,
	FOREIGN KEY (IDPN) REFERENCES dbo.PhieuNhap(IDPN),
	FOREIGN KEY (IDSP) REFERENCES dbo.SanPham(IDSP)
)
go


CREATE TABLE ChiTietHoaDon (
	IDCTHD INT IDENTITY(1,1) Primary key
	SoLuong int,
	DonGia float,
	IDSP nvarchar(20) not null,
	IDHD varchar(20) not null,
	FOREIGN KEY (IDSP) REFERENCES dbo.SanPham(IDSP),
	FOREIGN KEY (IDHD) REFERENCES dbo.HoaDon(IDHD),
)
GO
-- Stored Procedure
CREATE PROC SP_GetAccountByUsername
@userName nvarchar(100),
@password nvarchar(100)
AS
BEGIN
	declare @kq int	
	SELECT @kq = count(*) FROM dbo.Account
	WHERE TenTK = @userName and PassTK = @password
	Select @kq as KQ
END
GO

/*----------*/
set dateformat dmy

--Nha Cung Cap
insert into NhaCungCap values('NCC01', N'Công ty may mặc A', 'Quan 1' ,0912121212)
insert into NhaCungCap values('NCC02', N'Công ty may mặc B', 'Quan 2' ,0934343434)
insert into NhaCungCap values('NCC03', N'Công ty may mặc C', 'Quan 3' ,0956565656)
insert into NhaCungCap values('NCC04', N'Công ty may mặc d','Quan 4' , 0978787878)
--Account
insert into Account values('Acc01','vi', '1','NV01' )
insert into Account values('Acc02','phat', '2' ,'NV02')
insert into Account values('Acc03','yen', '3' ,'NV03')
insert into Account values('Acc04','lam', '4' , 'NV04')

--Nhan vien
insert into NhanVien values('NV01', N'Phan Thị Yến Vi', 0977777777, 3000000, 'Acc01')
insert into NhanVien values('NV02', N'Thái Tán Phát', 0988888888, 3000000, 'Acc02')
insert into NhanVien values('NV03', N'Nguyễn Thị Ngọc Yến', 0966666666, 3000000, 'Acc03')
insert into NhanVien values('NV04', N'Lê Văn Lâm', 0922222222, 3000000, 'Acc04')

--San Pham
insert into SanPham values('A01', N'Áo thun trơn', N'Trắng',100,'VietNam', 200000 ,'VND')
insert into SanPham values('A02', N'Áo thun con mèo', N'Đen',100,'VietNam', 250000 ,'VND')
insert into SanPham values('A03', N'Áo polo đơn sắc', N'Xám',100,'VietNam', 300000 ,'VND')
insert into SanPham values('A04', N'Áo polo họa tiết', N'Trắng',100,'VietNam', 350000 ,'VND')
insert into SanPham values('Q01', N'Quân Jean', N'Xanh dương',100,'VietNam', 400000 ,'VND')
insert into SanPham values('Q02', N'Quần Jean rách', N'Xanh đen',100,'VietNam', 450000 ,'VND')

--Phieu Nhap
insert into PhieuNhap values('PN01', N'Phiếu nhập áo thun trơn', '10-01-2023', 8000000, 'NCC01', 'NV01')
insert into PhieuNhap values('PN02', N'Phiếu nhập áo thun con mèo', '10-01-2023', 12000000, 'NCC02', 'NV01')
insert into PhieuNhap values('PN03', N'Phiếu nhập quần jean', '18-02-2023', 19000000, 'NCC04', 'NV01')
insert into PhieuNhap values('PN04', N'Phiếu nhập quần jean rách', '19-02-2023', 21000000, 'NCC04', 'NV02')
insert into PhieuNhap values('PN05', N'Phiếu nhập polo đơn sắc', '23-02-2023', 280000000, 'NCC01', 'NV02')
insert into PhieuNhap values('PN06', N'Phiếu nhập polo họa tiết ', '25-02-2023', 30000000, 'NCC03', 'NV03')

--Chi tiet phieu nhap
insert into ChiTietPN values('100', 80000, 'A01', 'PN01')
insert into ChiTietPN values('100', 120000, 'A02', 'PN02')
insert into ChiTietPN values('100', 190000, 'A03', 'PN03')
insert into ChiTietPN values('100', 210000, 'A04', 'PN04')
insert into ChiTietPN values('100', 280000, 'Q01', 'PN05')
insert into ChiTietPN values('100', 300000, 'Q02', 'PN06')
--Khach hàng
insert into KhachHang values ('KH01', 'Huynh Minh Hoang', 0343250236)
insert into KhachHang values ('KH02', 'Nguyen Thanh Thuyen', 0343250236)
insert into KhachHang values ('KH03', 'Cao Tien Hieu', 0343250236)
insert into KhachHang values ('KH04', 'Phan Minh Quan' ,0343250236)
insert into KhachHang values ('KH05', 'Nguyen Hong An', 0343250236)
insert into KhachHang values ('KH06', 'Vo Bui Minh Hoang', 0343250236)
insert into KhachHang values ('KH07', 'Tran Tien Dat', 0343250236)
insert into KhachHang values ('KH08', 'Tran Thanh', 0343250236)
insert into KhachHang values ('KH09', 'Harri Won', 0343250236)
insert into KhachHang values ('KH10', 'Son Tung', 0343250236)

--Hoa don
insert into HoaDon values ('HD01', '15-03-2023', 400000,'KH01')
insert into HoaDon values ('HD02', '15-03-2023', 400000, 'KH02')
insert into HoaDon values ('HD03', '15-03-2023', 900000, 'KH03')
insert into HoaDon values ('HD04', '16-03-2023', 300000, 'KH04')
insert into HoaDon values ('HD05', '16-03-2023', 700000, 'KH05')
insert into HoaDon values ('HD06', '17-03-2023', 400000, 'KH06')
insert into HoaDon values ('HD07', '18-03-2023', 450000, 'KH07')
insert into HoaDon values ('HD08', '18-03-2023', 300000, 'KH08')
insert into HoaDon values ('HD09', '18-03-2023', 500000, 'KH09')
insert into HoaDon values ('HD10', '19-03-2023', 1000000, 'KH10')

--CHi tiets hao don
insert into ChiTietHoaDon values('2', 200000, 'A01', 'HD01')
insert into ChiTietHoaDon values('1', 400000, 'A02', 'HD02')
insert into ChiTietHoaDon values('3', 300000, 'Q01', 'HD03')
insert into ChiTietHoaDon values('1', 300000, 'A01', 'HD04')
insert into ChiTietHoaDon values('2', 350000, 'A03', 'HD05')
insert into ChiTietHoaDon values('1', 400000, 'A01', 'HD06')
insert into ChiTietHoaDon values('1', 450000, 'Q02', 'HD07')
insert into ChiTietHoaDon values('1', 300000, 'A03', 'HD08')
insert into ChiTietHoaDon values('2', 250000, 'A02', 'HD09')
insert into ChiTietHoaDon values('4', 250000, 'A02', 'HD10')




















