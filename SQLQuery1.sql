create database QL_APPFOODtest46
USE QL_APPFOODtest46

CREATE TABLE tbl_khach
(
	KhachID INT IDENTITY (1,1) primary key,
	TenKhach nvarchar(50) ,
	DiaChi nvarchar(50),
	Email nvarchar(50),
	taikhoan nvarchar(50) ,
	MATKHAU nvarchar(50) 
)

create table tbl_CuaHang
(
	taikhoan nvarchar(50) ,
	MATKHAU nvarchar(50) 
)

CREATE TABLE tbl_DonHang
(	
	
	DonHangID INT IDENTITY (1000,1)primary key,
	NgayBan datetime,
	KhachID INT,
	
	
	
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
)
ALTER TABLE   tbl_DonHang
add constraint fk_k_dh foreign key (KhachID) references tbl_khach  (KhachID)


alter table  tbl_Hang
add constraint fk_dh_h foreign key (DonHangID) references tbl_DonHang   (DonHangID)
alter table tbl_Hang
add constraint fk_h_hb foreign key (HangID) references tbl_HangBan (HangID)

create view view_Bill1 as
select TenHang,SoLuong,dh.DonHangID,DonGia,hb.HangID,Anh
from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid
inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID

group by TenHang,SoLuong,dh.DonHangID,DonGia,hb.HangID,Anh

create view view_Hoadon2 as
select TenHang,SoLuong,dh.DonHangID,DonGia,hb.HangID,Anh
from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid
inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID

group by TenHang,SoLuong,dh.DonHangID,DonGia,hb.HangID,Anh



select dh.DonHangID,sum(DonGia*SoLuong) as 'tongbill',dh.NgayBan 
from tbl_hang h inner join tbl_hangban hb on hb.hangid = h.hangid 
inner join tbl_DonHang dh on dh.DonHangID = h.DonHangID 
group by dh.DonHangID,dh.NgayBan 