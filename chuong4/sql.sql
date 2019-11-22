create database QLBH
go
Use QLBH
go
Create table KHACHHANG(
 IDKhach char(20) primary key,
 HoTen Nvarchar(100),
 DiaChi Nvarchar(100),
 SoDT char(20),
 MatKhauK char(40)
)
Create table NHANVIEN(
 IDNVien char(20) primary key,
 HoTenNV Nvarchar(100),
 SoDTNVien char(20),
 MatKhauNV char(40)
)
Create table LOAIHANG(
 MaLoai char(20) primary key,
 TenLoai Nvarchar(60)
)
Create table HANGHOA(
 MaHang char(20) primary key,
 TenHang Nvarchar(50),
 DVTinh Nvarchar(50),
 DonGia int,
 MaLoai char(20),
 SoLuongMua int,
 Constraint FK_MLoai foreign key (MaLoai) references LOAIHANG (MaLoai)
)
Create table MUAHANG(
 IDKhach char(20),
 MaHang char(20),
 NgayMua date,
 SoLuong int,
 IDNVien char(20),
 Constraint SK_Mua primary key(IDKhach,MaHang,NgayMua),
 Constraint FK_Mua foreign key (IDNVien) references NHANVIEN (IDNVien),
 Constraint FK_HH foreign key (MaHang) references HANGHOA (MaHang),
 Constraint FK_Khach foreign key (IDKhach) references KHACHHANG (IDKhach)
)
--KHACHHANG
insert into KHACHHANG values
	('KH01', N'Nguyễn Hoàng Kha', N'Đồng Tháp', '0926291278','ngusaonoi'),
	('KH02', N'Nguyễn Thị Tiểu Lan', N'Vĩnh Long', '0923443099','dau_co_ngu'),
	('KH03',N'Vũ Viết Hưng',N'Vĩnh Long','0354694120','nsbsmkabs'),
	('KH04',N'Trần Thị Diễm Ngân',N'TP HCM','0963214521','sa1233451'),
	('KH05',N'Hồng Khắc Huy',N'Hậu Giang','0512402301','Huy4sa5s1'),
	('KH06',N'Nguyễn Thành Thanh Trung',N'Vĩnh Long','0236541365','chumchum99'),
	('KH07',N'Phạm Bảo Minh',N'Tiền Giang','0699901410','habbhs54422')

--NHANVIEN
insert into NHANVIEN values
	('NV01',N'Trần Thị Ô sin','091866663','Osin1'),
	('NV02',N'Hồ Thị In Sô','0918125496','inso123'),
	('NV03',N'Thái Thanh Quèn','0789992541','NhanVienQuen'),
	('NV04',N'Tạ Văn Nặng','0789111111','Nangvlaimaganh'),
	('NV05',N'Mạc Kiếp Nghèo','0837901201','NgheoLauVai')

--LOAIHANG
insert into LOAIHANG values ('LH01',N'Lương thực')
insert into LOAIHANG values ('LH02',N'Trái cây')
insert into LOAIHANG values ('LH03',N'Rau củ')
insert into LOAIHANG values ('LH04',N'Thịt Cá')
insert into LOAIHANG values ('LH05',N'Đồ đóng hộp')

--HANGHOA
insert into HANGHOA values
	('HH01',N'Khai mì',N'Kilogram',7000,'LH01',50),
	('HH02',N'Khoai lang',N'Kilogram',8000,'LH01',53),
	('HH03',N'Chuối',N'Nải',5000,'LH02',220),
	('HH04',N'Cá mồi',N'Hộp',13000,'LH05',120),
	('HH05',N'Bắp cải',N'Kilogram',9000,'LH03',45),
	('HH06',N'Cà chua',N'Kilogram',16000,'LH03',20),
	('HH07',N'Nho Đà Lạt',N'Kilogram',135000,'LH02',100),
	('HH08',N'Heo siêu nạc',N'Kilogram',200000,'LH04',50),
	('HH09',N'Cá basa',N'Kilogram',80000,'LH04',10),
	('HH10',N'Mì 3 miền',N'Gói',22000,'LH05',500)

--MUAHANG
insert into MUAHANG values
	('KH01','HH05','08/23/2019',1,'NV01'),
	('KH02','HH03','07/12/2017',2,'NV01'),
	('KH03','HH01','10/07/2019',2,'NV02'),
	('KH04','HH02','12/11/2018',3,'NV01'),
	('KH05','HH01','10/07/2019',2,'NV02'),
	('KH06','HH02','11/07/2018',3,'NV04'),
	('KH07','HH04','03/01/2017',3,'NV05')

Select* from KHACHHANG
Select* from NHANVIEN
Select* from LOAIHANG
Select* from HANGHOA
Select* from MUAHANG


select MatKhauNV from NHANVIEN where IDNVien='NV01'

select MaHang, TenHang, DVTinh, DonGia, MaLoai, SoLuongMua from HANGHOA order by MaHang

