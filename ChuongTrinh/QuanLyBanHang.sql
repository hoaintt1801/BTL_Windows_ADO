CREATE DATABASE QuanLyBanHang
GO

USE QuanLyBanHang
GO

CREATE TABLE LoaiSP(
	MaLSP varchar(10)  not null primary key,
	TenLSP nvarchar(100) not null,
	GhiChu nvarchar(255)
)
 
CREATE TABLE NhaCungCap(
	MaNCC varchar(10) not null primary key,
	TenNCC nvarchar(100) not null,
	DiaChi nvarchar(100),
	Sdt nchar(11),
	Email varchar(30)
)

CREATE TABLE ChucVu(
	MaCV varchar(10) not null primary key,
	TenCV nvarchar(100) not null
)

CREATE TABLE NhanHieu(
	MaNH varchar(10)  not null primary key,
	TenNH nvarchar(100) not null,
	GhiChu nvarchar(255)
)

CREATE TABLE SanPham(
	MaSP varchar(10) not null primary key,
	TenSP nvarchar(255) not null,
	Giaban money not null,
	SoLuong int not null,
	MaNH varchar(10) not null,
	MaLSP varchar(10) not null,
	MaNCC varchar(10) not null,
	MaVach nvarchar(20), 
	MoTa nvarchar(300)

	foreign key (MaLSP) references LoaiSP(MaLSP),
	foreign key (MaNCC) references NhaCungCap(MaNCC),
	foreign key (MaNH) references NhanHieu(MaNH)
)

CREATE TABLE NhomKH
(
	MaNKH varchar(10) not null primary key ,
	TenNKH nvarchar(30)
)

CREATE TABLE KhachHang(
	MaKH varchar(10) not null primary key,
	HoTen nvarchar(100) not null,
	DiaChi nvarchar(100) ,
	Sdt nchar(11),
	MaNKH varchar(10) not null,
	constraint fk_nhomkh foreign key (MaNKH) references NhomKH(MaNKH)
)

CREATE TABLE NhanVien(
	MaNV varchar(10) primary key,
	HoTen nvarchar(100) not null,
	DiaChi nvarchar(100) ,
	Sdt nchar(11),
	MaCV varchar(10) not null

	foreign key (MaCV) references ChucVu(MaCV)
)

CREATE TABLE HTTT
(
	MaHTTT varchar(10) not null primary key,
	TenHTTT nvarchar(20)
)

CREATE TABLE HoaDon (
	MaHD varchar(10) not null primary key,
	MaKH varchar(10) not null,
	NgayLap datetime not null,
	MaNV varchar(10) not null,
	
	MaHTTT varchar(10),
	TrangThai bit,
	constraint fk_httt foreign key (MaHTTT) references HTTT(MaHTTT),

	foreign key (MaKH) references KhachHang(MaKH),
	foreign key (MaNV) references NhanVien(MaNV)
)


CREATE TABLE HoaDonChiTiet (
	MaHD varchar(10) not null,
	MaSP varchar(10) not null,
	SoLuong int,
	constraint fk_hoadon foreign key (MaHD) references HoaDon(MaHD),
	constraint fk_hang foreign key (MaSP) references SanPham(MaSP),
	constraint pk primary key (MaHD, MaSP)
)

CREATE TABLE TaiKhoan (
	MaTaiKhoan nchar(10) not null primary key,
	MatKhau varchar(30) not null,
	MaCV varchar(10) not null,
	constraint FK_ChucVu foreign Key(MaCV) references ChucVu(MaCV)
)

CREATE TABLE PhieuNhap
(
	MaPN varchar(10) not null primary key,
	MaSP varchar(10) not null,
	SoLuongNhap int,
	DonGiaNhap money,
	NgayNhap date,
	MaNCC varchar(10),
	constraint fk_pnhap1 foreign key(MaNCC) references NhaCungCap(MaNCC),
	constraint fk_pnhap2 foreign key(MaSP) references SanPham(MaSP)
)

CREATE TABLE PhieuThu
(
	MaPT varchar(20) not null primary key,
	MaKH varchar(10),
	NgayLap datetime,
	NguoiLapPhieu nvarchar(20),
	SoTienThu money,
	DiaChi nvarchar(100),
	SDT nchar(11),
	constraint fk_PhieuThu1 foreign key(MaKH) references KhachHang(MaKH),
)
drop table ID
CREATE TABLE ID(
	MaID char(10) primary key,
	id_hoaDon int,
	id_sanPham int,
	id_khachHang int
)


CREATE TABLE PhieuChi
(
	MaPC varchar(20) not null primary key,
	MaNCC varchar(10) not null,
	NgayLap datetime,
	NguoiLap nvarchar(20),
	SoTienChi money,
	DiaChi nvarchar(100),
	SDT nchar(11),
	Email varchar(30),
	constraint fk_PhieuChi1 foreign key(MaNCC) references NhaCungCap(MaNCC),
)



-- INSERT DATA ID
insert into ID values ('ID01', 10,11,10)

-- INSERT DATA LOẠI HÀNG
insert into LoaiSP values('L1', N'Chăm sóc da', N'Chăm sóc loại 1')
insert into LoaiSP values('L2', N'Kem chống nắng', N'Chăm sóc loại 2')
insert into LoaiSP values('L3', N'Thực phẩm chức năng', N'Hàng xách tay')
insert into LoaiSP values('L4', N'Mặt nạ', N'Đã qua kiểm định của Bộ Y Tế')

-- INSERT DATA NHÀ CUNG CẤP
insert into NhaCungCap values('NCC1', N'Sunny', N'Mỹ', '123456789','sunnycompany@gmail.com')
insert into NhaCungCap values('NCC2', N'Đông Á', N'Hà Nội - Việt Nam', '123456789','dongacompany@gmail.com')
insert into NhaCungCap values('NCC3', N'Vingroup', N'Hà Nội - Việt Nam', '123456789','svincompany@gmail.com')
insert into NhaCungCap values('NCC4', N'Okee', N'Mỹ', '123456789','okecompany@gmail.com')
insert into NhaCungCap values('NCC5', N'Chanel', N'Mỹ', '123456789','chancompany@gmail.com')
insert into NhaCungCap values('NCC6', N'Dior', N'Mỹ',' 123456789','doircompany@gmail.com')
insert into NhaCungCap values('NCC7', N'Tâm Bình', N'Hà Nội - Việt Nam',' 123456789','tambingcompany@gmail.com')
insert into NhaCungCap values('NCC8', N'Versa', N'Mỹ', '123456789','vercompany@gmail.com')
insert into NhaCungCap values('NCC9', N'Á Châu', N'Trung Quốc', '123456789','achaucompany@gmail.com')

-- INSERT DATA Nhãn hiệu
insert into NhanHieu values('NH1', N'Ponds', N'Việt Nam')
insert into NhanHieu values('NH2', N'Inness Free', N'Hàn Quốc')
insert into NhanHieu values('NH3', N'Emchenter', N'Anh')
insert into NhanHieu values('NH4', N'Dior', N'Mỹ')

-- INSERT DATA HÀNG
insert into SanPham values('H1', 'Serum X', 1200000, 11,'NH1', 'L1', 'NCC1',N'VN3297489372',N'Dành cho da mụn')
insert into SanPham values('H2', N'Kem chống lão hóa', 450000, 200, 'NH1', 'L4', 'NCC2',N'VN3297V489372',N'Dành cho da dầu')
insert into SanPham values('H3', 'Converse CC', 800000, 11,'NH2','L2', 'NCC5',N'VN32974893472',N'Làm da trắng sáng')
insert into SanPham values('H4', N'Mặt nạ', 400000, 30,'NH2','L3', 'NCC9',N'VN32974489372',N'Bổ sung vitamin cho da')
insert into SanPham values('H5', N'Thực phẩm bổ sung', 850000, 20,'NH2','L1', 'NCC4',N'VN32917489372',N'Dành cho mọi lứa tuổi')
insert into SanPham values('H6', N'Viên uống Collagen', 790000, 50,'NH3','L3', 'NCC9',N'VN32974890372',N'Cải thiện tình trang da')
insert into SanPham values('H7', N'Ketamin', 900000, 150,'NH3','L4', 'NCC7',N'VN329741289372',N'đẹp da')
insert into SanPham values('H8', 'Xịt khoáng', 130000, 10,'NH4', 'L1', 'NCC8',N'VN311297489372',N'Cấp ẩm')
insert into SanPham values('H9', N'Mặt nạ hoa hồng', 150000, 5, 'NH4', 'L1', 'NCC3',N'VN32967489372',N'Dành cho da mụn')
insert into SanPham values('H10', 'Dior V', 350000, 25,'NH4', 'L2', 'NCC1',N'VN32974893072',N'Dành cho da khô')
 --INSERT HTTT
insert into HTTT values('HT1',N'VNPay')
insert into HTTT values('HT2',N'Tiền mặt')

-- INSERT DATA Chức vụ
insert into ChucVu values('TD1', N'Nhân viên')
insert into ChucVu values('TD2', N'Quản lý')
insert into ChucVu values('TD3', N'Admin')

-- INSERT DATA NHÂN VIÊN
insert into NhanVien values('NV1', N'Nguyễn Hữu Nhật', N'Hoài Đức - Hà Nội', '123456789', 'TD1')
insert into NhanVien values('NV2', N'Phạm Xuân Lộc', N'Hà Nội', '123456789', 'TD2')
insert into NhanVien values('NV3', N'Nguyễn Duy Phòng', N'Hà Nội', '123456789', 'TD3')
-- INSERT DATA NHÓM KHÁCH HÀNG
insert into NhomKH values('N1',N'Khách sỉ')
insert into NhomKH values('N2',N'Khách lẻ')
insert into NhomKH values('N3',N'Khách Vip')


-- INSERT DATA KHÁCH HÀNG
insert into KhachHang values('KH1', N'Nguyễn Văn Huy', N'Quốc Oai - Hà Nội', '123456789','N1')
insert into KhachHang values('KH2', N'Phạm Nhật Tân', N'Thanh Hóa', '123456789','N2')
insert into KhachHang values('KH3', N'Ngọc ANh', N'Thanh Hóa', '123456789','N3')
insert into KhachHang values('KH4', N'Duy Phòng', N'Thanh Hóa', '123456789','N3')
insert into KhachHang values('KHLe', N'Khách lẻ', N'  ', ' ','N3')

--INSERT DATA HÓA ĐON
insert into HoaDon values('HD1','KH1','5/11/2021','NV1','HT2',0)
insert into HoaDon values('HD2','KH2','6/11/2021','NV2','HT1',0)
insert into HoaDon values('HD3','KH1','3/11/2021','NV1','HT2',0)
insert into HoaDon values('HD4','KH2','1/11/2021','NV3','HT1',0)
insert into HoaDon values('HD5','KH1','4/11/2021','NV1','HT2',0)
insert into HoaDon values('HD6','KH2','2/11/2021','NV3','HT1',0)

-- INSERT DATA HÓA ĐON CHI TIẾT
insert into HoaDonChiTiet values('HD1','H1',4)
insert into HoaDonChiTiet values('HD2','H2',9)
insert into HoaDonChiTiet values('HD3','H3',5)
insert into HoaDonChiTiet values('HD4','H4',10)
insert into HoaDonChiTiet values('HD5','H5',2)
insert into HoaDonChiTiet values('HD6','H6',1)
insert into HoaDonChiTiet values('HD6','H5',1)

-- INSERT DATA TÀI KHOẢN
insert into TaiKhoan  values('TK1','123456','TD1' )
insert into TaiKhoan  values('TK2', '123456', 'TD2')
insert into TaiKhoan  values('TK3','123456', 'TD2')
insert into TaiKhoan  values('TK4', '123456', 'TD3')

--INSERT DATA PHIẾU THU
insert into PhieuThu values
('PT1','KH1','2021-05-11',N'Nguyễn Hữu Nhật','100000',N'Quốc Oai - Hà Nội','123456789'),
('PT2','KH2','2021-06-11',N'Nguyễn Duy Phòng','100000',N'Thanh Hóa','123456789'),
('PT3','KH1','2021-03-11',N'Nguyễn Hữu Nhật','100000',N'Quốc Oai - Hà Nội','123456789'),
('PT4','KH2','2021-01-11',N'Nguyễn Duy Phòng','100000',N'Thanh Hóa','123456789'),
('PT5','KH1','2021-04-11',N'Nguyễn Hữu Nhật','100000',N'Quốc Oai - Hà Nội','123456789'),
('PT6','KH2','2021-02-11',N'Nguyễn Duy Phòng','100000',N'Thanh Hóa','123456789')
--INSERT DATA PHIẾU THU
insert into PhieuChi values
('PC1','NCC1','10/7/2021',N'Tự động','150000000',N'Mỹ','123456789','sunnycompany@gmail.com'),
('PC2','NCC2','10/8/2021',N'Tự động','150000000',N'Hà Nội - Việt Nam','123456789','dongacompany@gmail.com'),
('PC3','NCC3','9/7/2021',N'Tự động','150000000',N'Hà Nội - Việt Nam','123456789','svincompany@gmail.com'),
('PC4','NCC4','12/7/2021',N'Tự động','150000000',N'Mỹ','123456789','okecompany@gmail.com'),
('PC5','NCC5','1/20/2021',N'Tự động','150000000',N'Mỹ','123456789','chancompany@gmail.com')
--INSERT DATA PHIẾU NHẬP
insert into PhieuNhap values('PN1','H1',1500,20000,'10/7/2021','NCC1')
insert into PhieuNhap values('PN2','H2',1500,20000,'10/8/2021','NCC2')
insert into PhieuNhap values('PN3','H3',1500,10000,'9/7/2021','NCC3')
insert into PhieuNhap values('PN4','H4',1500,30000,'12/7/2021','NCC4')
insert into PhieuNhap values('PN5','H5',1500,90000,'1/20/2021','NCC5')
select *from LoaiSP
select *from SanPham
select *from NhanHieu
select *from NhaCungCap
select *from HoaDon
select *from HoaDonChiTiet
select *from NhanVien
select *from ChucVu
select *from KhachHang


select *from NhomKH
select *from TaiKhoan
select *from HTTT
select *from PhieuNhap
select *from PhieuChi
select *from PhieuThu


