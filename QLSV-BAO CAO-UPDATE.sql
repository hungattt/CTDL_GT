CREATE DATABASE QLSV;

CREATE TABLE DANGNHAP
(TaiKhoan nchar(10),
MatKhau nchar(10));


CREATE TABLE KHOA
(MaKhoa nchar(10) primary key,
TenKhoa nvarchar(60));

CREATE TABLE LOP
(MaLop nchar(10) primary key,
TenLop nvarchar(60),
MaKhoa nchar(10) foreign key references KHOA);


CREATE TABLE SINHVIEN
(MaSV nchar(10) primary key,
TenSV nchar(70) ,
NamSinh date ,
GioiTinh nvarchar(10),
DiemToan float,
DiemLy float,
DiemHoa float,
DiemTB float,
MaLop nchar(10) foreign key references LOP);
-----------------------------------------------
insert into DANGNHAP(TaiKhoan,MatKhau)
values			('hung','hung'),
				('linh','linh'),
				('quang','quang');
------------------------------------------------
insert into KHOA(MaKhoa,TenKhoa)
values ('cntt',N'Công nghệ thông tin '),
		('kt',N'Kinh tế '),
		('ktd',N'kĩ thuật điện ');
---------------------------------------------------		--------------------------------------------------------
--------------------------------------------------------------------------------------
insert into LOP(MaLop,TenLop,MaKhoa)
values     ('cnpm1',N'Công nghệ phần mềm 1','cntt'),
			('cnpm2',N'Công nghệ phần mềm 2 ','cntt'),
			('attt1',N'An toàn thông tin 1 ','cntt'),
			('attt2',N'An toàn thông tin 2 ','cntt'),
			('tmdt1',N'Thương mại điện tử 1 ','cntt'),
			('tmdt2',N'Thương mại điện tử 2  ','cntt'),
			('kt1',N'Kế toán 1 ','kt'),
			('kt2',N'Kế toán 2 ','kt'),
			('kit1',N'Kiểm toán 1 ','kt'),
			('kit2',N'Kiểm toán 2  ','kt'),
			('ddd1',N'Điện dân dụng 1 ','ktd'),
			('ddd2',N'Điện dân dụng 2  ','ktd'),
			('dcn1',N'Điện công nghiệp 1 ','ktd'),
			('dcn2',N'Điện công nghiệp 2  ','ktd');
-------------------------------------------------------------------------------------------------------------
insert into SINHVIEN(MaSV,TenSV,NamSinh,GioiTinh,DiemToan,DiemLy,DiemHoa,DiemTB,MaLop)
values					('sv01',N'Bùi Xuân Hùng ','2000-07-01','Nam','10','10','10','10','cnpm1'),
						('sv02',N'Lưu Tùng Linh  ','2000-08-01','Nam','1','2','3','2','cnpm1'),
						('sv03',N'Nguyễn Mạnh Cương  ','2000-07-07','Nam','8','8','8','8','cnpm2'),
						('sv04',N'Nguyễn Minh Quang  ','2000-09-07','Nam','2','3','4','3','cnpm2'),
						('sv05',N'Quách Thị Mĩ Linh  ','2000-10-07','Nu','9','9','9','9','attt1'),
						('sv06',N'Nguyễn Thảo Minh  ','2000-11-17','Nu','6','7','8','7','attt1'),
						('sv07',N'Nguyễn Minh Hiếu ','2000-03-02','Nam','0','5','1','3','attt2'),
						('sv08',N'Trần Quốc Cường ','2000-05-12','Nam','7','8','9','8','attt2'),
						('sv09',N'Đặng Việt Cường ','2000-07-01','Nam','2','1','0','1','tmdt1'),
						('sv10',N'Nguyễn Trọng Đại','2000-08-01','Nam','7','7','7','7','tmdt1'),
						('sv11',N'Đặng Đức Minh','2000-07-07','Nam','2','2','5','3','tmdt2'),
						('sv12',N'Trần Ngọc Duy','2000-09-07','Nam','8','8','8','8','tmdt2'),
						('sv13',N'Lê Huy Hải','2000-10-07','Nam','9','9','9','9','kt1'),
						('sv14',N'Ngô Quang Hải  ','2000-11-17','Nu','1','10','1','4','kt1'),
						('sv15',N'Phạm Đức Hậu','2000-03-02','Nam','6','6','6','6','kt2'),
						('sv16',N'Phạm Trung Hoan','2000-05-12','Nam','2','6','1','3','kt2'),
						('sv17',N'Nguyễn Xuân Hồng','2000-07-01','Nam','8','8','8','8','kit1'),
						('sv18',N'Nguyễn Mạnh Hùng ','2000-08-01','Nam','7','7','7','7','kit1'),
						('sv19',N'Bùi Phương Nam ','2000-07-07','Nam','8','8','8','8','kit2'),
						('sv20',N'Lê Huy Nam','2000-09-07','Nam','8','8','8','8','kit2'),
						('sv21',N'Nguyễn Minh Nghĩa','2000-10-07','Nu','9','9','9','9','ddd1'),
						('sv22',N'Nguyễn Quảng Nguyên','2000-11-17','Nu','8','8','8','8','ddd1'),
						('sv23',N'Nguyễn Văn Thanh','2000-03-02','Nam','6','6','6','6','ddd2'),
						('sv24',N'Nguyễn Tiến Tài','2000-05-12','Nam','4','5','6','5','ddd2'),
						('sv25',N'Tô Văn Toàn','2000-07-01','Nam','8','8','8','8','dcn1'),
						('sv26',N'Mai Minh Tuấn  ','2000-08-01','Nam','7','6','5','6','dcn1'),
						('sv27',N'Cao Hưu Tú','2000-07-07','Nam','8','8','8','8','dcn2'),
						('sv28',N'Hoàng Anh Vũ','2000-09-07','Nam','8','8','8','8','dcn2');
-------------------------------------------------------------------------------------------------------------------
create proc LayToanBoSinhVien
as
select * from [SINHVIEN]

exec LayToanBoSinhVien
------------------------------------------------------------------
create proc ThemSinhVien
@ma nchar(10),
@ten nvarchar(60),
@namsinh date,
@gioitinh nchar(10),
@diemtoan float,
@diemly float,
@diemhoa float,
@diemtb float,
@malop nchar(10)
as
insert into [SINHVIEN]([MaSV],[TenSV],[NamSinh],[GioiTinh],[DiemToan],[DiemLy],[DiemHoa],[DiemTB],[MaLop])
	values(@ma,@ten,@namsinh,@gioitinh,@diemtoan,@diemly,@diemhoa,@diemtb,@malop)

	exec ThemSinhVien @ma=sv29 ,@ten=N'Nguyễn Duy Nghiem' ,@namsinh='2000-04-05',@gioitinh=nu,@diemtoan=7,@diemly=7,@diemhoa=7,@diemtb=7,@malop=cnpm2
	--------------------------------------------------------------------------------------
create proc CapNhatSinhVien
@ma nchar(10),
@ten nvarchar(60),
@namsinh date,
@gioitinh nchar(10),
@diemtoan float,
@diemly float,
@diemhoa float,
@diemtb float,
@malop nchar(10)
as
update SINHVIEN
set [TenSV]=@ten,[NamSinh]=@namsinh,[GioiTinh] =@gioitinh,[DiemToan]= @diemtoan,[DiemLy]= @diemly,[DiemHoa]= @diemhoa,[DiemTB]= @diemtb,[MaLop]= @malop
where [MaSV]=@ma

exec CapNhatSinhVien @ma=sv17 ,@ten=N'Nguyễn Van Dung' ,@namsinh='2000-07-05',@gioitinh=nam,@diemtoan=6,@diemly=7,@diemhoa=7,@diemtb=7,@malop=cnpm2
-----------------------------------------------------------------------------
create proc ChiTietSinhVienTheoMa
@ma nchar(10) 
as 
select * from SINHVIEN where [MaSV]=@ma

exec ChiTietSinhVienTheoMa @ma=sv13
---------------------------------------------------------
create proc XoaSinhVienTheoMa
@ma nchar(10)
as
delete from SINHVIEN where [MaSV]=@ma

exec XoaSinhVienTheoMa @ma=sv29
-----------------------
create proc LayToanBoLop
as
select * from LOP

exec LayToanBoLop
----------

create proc LayToanBoMaLop
as
select MaLop from LOP

exec LayToanBoMaLop



-----------------------
create proc ThemLop
@ma nchar(10),
@ten nvarchar(50),
@makhoa nchar(10)
as
insert into LOP(MaLop,TenLop,MaKhoa)
	values(@ma,@ten,@makhoa)

	exec ThemLop @ma=cnpm3 ,@ten=N'Công nghệ phần mềm 3' ,@makhoa=cntt
	-------------------------------------------------------------
create proc ChiTietLop
@ma nchar(10) 
as 
select * from LOP where MaLop=@ma

exec ChiTietLop @ma=cnpm1
--------------------------------
create proc CapNhatLopTheoMa
@ma nchar(10) ,
@ten nvarchar(60),
@makhoa nchar(100)
as
update LOP
set MaLop=@ma, TenLop=@ten,MaKhoa=@makhoa
where MaLop=@ma

exec CapNhatLopTheoMa   @ma=cnpm3 ,@ten=N'Công nghệ phần mềm 3',@makhoa=cntt
-------------------------------------------
create proc XoaLopTheoMa
@ma nchar(10)
as
delete from LOP where MaLop=@ma

exec XoaLopTheoMa @ma=cnpm3
----------------------------------------------------------
create proc LayToanBoKhoa
as
select * from KHOA

exec LayToanBoKhoa
------------------------------------

create proc LayToanBoMaKhoa
as
select MaKhoa from KHOA

exec LayToanBoMaKhoa


-------------------------------
create proc ChiTietKhoa
@ma nchar(10) 
as 
select * from KHOA where MaKhoa=@ma

exec ChiTietKhoa @ma=cntt
-----------------------------------
create proc ThemKhoa
@ma nchar(10),
@ten nvarchar(50)

as
insert into KHOA(MaKhoa,TenKhoa)
	values(@ma,@ten)

	exec ThemKhoa @ma=tl ,@ten=N'Tâm lý  ' 
	-----------------------------------------
	create proc CapNhatKhoaTheoMa
@ma nchar(10) ,
@ten nvarchar(60)
as
update KHOA
set TenKhoa=@ten
where MaKhoa =@ma

exec CapNhatKhoaTheoMa   @ma=tl ,@ten=N'Tâm lý '
----------------------------------------
create proc XoaKhoaTheoMa
@ma nchar(10)
as
delete from KHOA where MaKhoa=@ma

exec XoaKhoaTheoMa @ma=tl
------------------------------------------
create proc TimSinhVienTheoMa
@ma nchar(10)
as
select * from SinhVien where [MaSV]=@ma

exec TimSinhVienTheoMa @ma=sv14
--------------------------
select MaLop From LOP
----------------------------------
----------gioi--------------- 
select *
from SINHVIEN
where DiemTB>=8.5 and DiemTB<=10;
------------------------------
----------------------------------
----------kha--------------- 
select *
from SINHVIEN
where DiemTB>=7.0 and DiemTB<=8.4;
------------------------------
----------------------------------
----------trung binh--------------- 
select *
from SINHVIEN
where DiemTB>=5.5 and DiemTB<=6.9;
------------------------------
----------------------------------
----------TB yeu--------------- 
select *
from SINHVIEN
where DiemTB>=4.0 and DiemTB<=5.4;
------------------------------
----------------------------------
----------kem--------------- 
select *
from SINHVIEN
where DiemTB>=0.0 and DiemTB<=3.9;
------------------------------
Select MaLop
from LOP 
where MaKhoa= N'kt'
-------------------------
Select MaLop
from LOP 
--------------
select * from LOP where MaLop=N'attt1';
---------------------------------------
select *
from SINHVIEN
order by DiemToan,DiemLy ASC
