create database QL_APPFOODtest55
USE QL_APPFOODtest55


CREATE TABLE tbl_NhanVien
(
	NhanVienID INT IDENTITY (1,1) primary key,
	TenNV nvarchar(50) ,
	DiaChi nvarchar(50),
	Email nvarchar(50),
	taikhoan nvarchar(50) ,
	MATKHAU nvarchar(50) ,
	SDT nvarchar(50),
)


CREATE TABLE tbl_DonHang
(	
	
	DonHangID INT IDENTITY (1000,1)primary key,
	nhanvienID INT,
	NgayBan datetime,
	KhachID INT,
	trangthai nvarchar(50),
	
	
)
create table tbl_hang
(	
	DonHangID INT ,
	HangID INT ,
	SoLuong nvarchar(50)
)
create table tbl_hangban
(	
	
	HangID INT IDENTITY (1,1) primary key,
	TenHang nvarchar(50),
	DonVi nvarchar(50),
	DonGia float,
	loai nvarchar(50),
	Anh varbinary(max),
	trangthai nvarchar(50),
)



alter table  tbl_Hang
add constraint fk_dh_h foreign key (DonHangID) references tbl_DonHang   (DonHangID)
alter table tbl_Hang
add constraint fk_h_hb foreign key (HangID) references tbl_HangBan (HangID)
ALTER TABLE   tbl_DonHang
add constraint fk_dh_nv foreign key (nhanvienid) references tbl_nhanvien  (nhanvienid)


delete tbl_hang where HangID != 01e
delete tbl_DonHang where DonHangID != 2
delete tbl_NhanVien where NhanVienID !=2 