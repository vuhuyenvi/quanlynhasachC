CREATE DATABASE QLNS
GO
USE QLNS
GO 

USE master;
ALTER DATABASE QLNS SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
USE master;
DROP DATABASE QLNS;


CREATE TABLE TACGIA(
	MATG NVARCHAR(10) NOT NULL,
	TENTG NVARCHAR(30) NOT NULL,
	DIACHITG NVARCHAR(50),
	SODT NVARCHAR(20),
	EMAILTG VARCHAR(30),
	CONSTRAINT PK_TACGIA PRIMARY KEY (MATG)
)
CREATE TABLE NHAXUATBAN(
	MANXB NVARCHAR(10) NOT NULL,
	TENNXB NVARCHAR(50),
	DIACHINXB NVARCHAR(50),
	SODT NVARCHAR(20),
	EMAILNXB VARCHAR(30),
	CONSTRAINT PK_NHAXUATBAN PRIMARY KEY (MANXB)
)
CREATE TABLE THELOAI(
	MATL NVARCHAR(10) NOT NULL,
	TENTL NVARCHAR(20),
	DIENGIAI NVARCHAR(50),
	CONSTRAINT PK_THELOAI PRIMARY KEY (MATL)
)
CREATE TABLE CHUCVU(
	MACV VARCHAR(10) NOT NULL,
	TENCV NVARCHAR(20),
	LUONG FLOAT,
	CONSTRAINT PK_CHUCVU PRIMARY KEY (MACV)
)
CREATE TABLE KHACHHANG(
	MAKH NVARCHAR(10) NOT NULL,
	HOTENKH NVARCHAR(50),
	DIACHIKH NVARCHAR(50),
	SODT INT,
	EMAILKH VARCHAR(30),
	CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH)
)
CREATE TABLE NHANVIEN(
	MANV NVARCHAR(10) NOT NULL,
	MACV VARCHAR(10),
	HOTENNV NVARCHAR(50),
	DIACHINV NVARCHAR(50),
	SODT INT,
	EMAILNV VARCHAR(30),
	CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV),
	CONSTRAINT FK_NHANVIEN_CHUCVU FOREIGN KEY (MACV) REFERENCES CHUCVU(MACV)
)
CREATE TABLE SACH(
	MASACH NVARCHAR(10) NOT NULL,
	MANXB NVARCHAR(10) NOT NULL,
	MATL NVARCHAR(10) NOT NULL,
	TENSACH NVARCHAR(50),
	MATG NVARCHAR(10),
	NGAYXUATBAN date,
	GIABAN INT,
	SOLUONGTON INT,
	CONSTRAINT PK_SACH PRIMARY KEY (MASACH),
	CONSTRAINT FK_SACH_NHAXUATBAN FOREIGN KEY (MANXB) REFERENCES NHAXUATBAN(MANXB),
	CONSTRAINT FK_SACH_THELOAI FOREIGN KEY (MATL) REFERENCES THELOAI(MATL),
	CONSTRAINT FK_SACH_TACGIA FOREIGN KEY (MATG) REFERENCES TACGIA(MATG)
)
CREATE TABLE KHUYENMAI (
  MAKM NVARCHAR(10) NOT NULL,
  NGAYBD DATE,
  NGAYKT DATE,
  GIAMGIA FLOAT,
  CONSTRAINT PK_KHUYENMAI PRIMARY KEY (MAKM),
);

CREATE TABLE SACHKHUYENMAI (
  ID INT NOT NULL,
  MASACH NVARCHAR(10) NOT NULL,
  MAKM NVARCHAR(10) NOT NULL,
  CONSTRAINT PK_SACHKHUYENMAI PRIMARY KEY (MASACH, MAKM, ID),
  CONSTRAINT FK_SACHKHUYENMAI_SACH FOREIGN KEY (MASACH) REFERENCES SACH(MASACH),
  CONSTRAINT FK_SACHKHUYENMAI_KHUYENMAI FOREIGN KEY (MAKM) REFERENCES KHUYENMAI(MAKM)
);

CREATE TABLE HOADON(
	MAHD NVARCHAR(10) NOT NULL,
	MANV NVARCHAR(10) NOT NULL,
	MAKH NVARCHAR(10) NOT NULL,
	NGAYLAP DATE,
	TRANGTHAIDH NVARCHAR(10),
	THANHTIEN INT,
	CONSTRAINT PK_HOADON PRIMARY KEY (MAHD),
	CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)
)
CREATE TABLE CHITIETHD(
	MASACH NVARCHAR(10) NOT NULL,
	MAHD NVARCHAR(10) NOT NULL,
	GIABAN INT,
	SOLUONG INT,
	TONGTIEN MONEY,
	CONSTRAINT PK_CHITIETHD PRIMARY KEY(MASACH,MAHD),
	CONSTRAINT FK_CHITIETHD_SACH FOREIGN KEY (MASACH) REFERENCES SACH(MASACH),
	CONSTRAINT FK_CHITIETHD_HOADON FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
)
CREATE TABLE TAIKHOAN(
	TENDN NVARCHAR(30) NOT NULL,
	TENHT NVARCHAR(30) NOT NULL,
	MATKHAU NVARCHAR(30),
	PHANQUYEN NVARCHAR(30),
	MANV NVARCHAR(10),
	CONSTRAINT FK_TAIKHOAN_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT PK_TAIKHOAN PRIMARY KEY(TENDN)
)

CREATE TABLE NHACUNGCAP(
	MANCC NVARCHAR(10) NOT NULL,
	TENNCC NVARCHAR(50),
	DIACHINCC NVARCHAR(50),
	SODT NVARCHAR(20),
	EMAILNCC VARCHAR(30),
	CONSTRAINT PK_NHACUNGCAP PRIMARY KEY (MANCC)
)

CREATE TABLE PHIEUNHAP(
	MAPHIEUNHAP NVARCHAR(20) NOT NULL,
	NGAYNHAP DATE,
	THANHTIEN MONEY,
	MANV NVARCHAR(10),
	MANCC NVARCHAR(10),
	CONSTRAINT PK_PHIEUNHAP PRIMARY KEY(MAPHIEUNHAP),
	CONSTRAINT FK_PHIEUNHAP_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT FK_PHIEUNHAP_NHACUNGCAP FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP(MANCC)
)

CREATE TABLE CHITIETPN(
	MASACH NVARCHAR(10) NOT NULL,
	MAPHIEUNHAP NVARCHAR(20) NOT NULL,
	GIANHAP INT,
	SOLUONGNHAP INT,
	TONGTIEN MONEY,
	CONSTRAINT PK_CHITIETPN PRIMARY KEY(MASACH,MAPHIEUNHAP),
	CONSTRAINT FK_CHITIETPN_SACH FOREIGN KEY (MASACH) REFERENCES SACH(MASACH),
	CONSTRAINT FK_CHITIETPN_PHIEUNHAP FOREIGN KEY (MAPHIEUNHAP) REFERENCES PHIEUNHAP(MAPHIEUNHAP),
)


INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHINCC, SODT, EMAILNCC)
VALUES
    ('NCC001', N'Công Ty Cổ Phần Phát Hành Sách Tp. HCM (FAHASA)', N'60-62 Lê Lợi, P. Bến Nghé, Q. 1, Tp. Hồ Chí Minh', '1234567890', 'nccA@email.com'),
    ('NCC002', N'Công Ty Cổ Phần Sách & Thiết Bị Giáo Dục Trí Tuệ', N'187 Giảng Võ, Q. Đống Đa, Hà Nội', '0987654321', 'nccB@email.com'),
    ('NCC003', N'Công Ty TNHH Văn Hóa Việt Long', N'Đào Duy Anh, P.9, Q. Phú Nhuận, Tp. Hồ Chí Minh', '5555555555', 'nccC@email.com'),
    ('NCC004', N'Công Ty TNHH Đăng Nguyên', N'Suối Nghệ, H. Châu Đức, Bà Rịa-Vũng Tàu', '9999999999', 'nccD@email.com'),
    ('NCC005', N'Công Ty Cổ Phần Sách Mcbooks', N'Phúc Diễm, Q. Bắc Từ Liêm, Hà Nội', '7777777777', 'nccE@email.com');




SELECT * FROM TAIKHOAN
INSERT INTO TACGIA (MATG, TENTG, DIACHITG, SODT, EMAILTG) 
VALUES
    ('TG1', N'Nguyễn Nhật Ánh', N'Hà Nội', '0987654321', 'nhatanh@gmail.com'),
    ('TG2', N'Ngô Tất Tố', N'Hồ Chí Minh', '0901234567', 'ngott@gmail.com'),
    ('TG3', N'Hồ Biểu Chánh', N'Hà Nội', '0912345678', 'ho.bieu.chanh@gmail.com'),
    ('TG4', N'Nguyễn Xuân Trường', N'Hải Phòng', '0976543210', 'xuantruong@gmail.com'),
    ('TG5', N'Lê Lịch', N'Đà Nẵng', '0945678901', 'lelich@gmail.com'),
    ('TG6', N'Nguyễn Du', N'Huế', '0932109876', 'nguyendu@gmail.com'),
    ('TG7', N'Tô Hoài', N'Hà Nội', '0965432198', 'tohoai@gmail.com'),
    ('TG8', N'Xuân Diệu', N'Hồ Chí Minh', '0923456789', 'xuandieu@gmail.com'),
    ('TG9', N'Tô Hoài', N'Hà Nội', '0956789012', 'tohoai@gmail.com'),
    ('TG10', N'Ngô Thì Nhậm', N'Đà Nẵng', '0910987654', 'ngothinham@gmail.com');

INSERT INTO NHAXUATBAN (MANXB, TENNXB, DIACHINXB, SODT, EMAILNXB) 
VALUES
    ('NXB1', N'Nhà Xuất Bản Trẻ', N'Hà Nội', '0987654321', 'nxbtre@gmail.com'),
    ('NXB2', N'Nhà Xuất Bản Kim Đồng', N'Hồ Chí Minh', '0901234567', 'nxbkimdong@gmail.com'),
    ('NXB3', N'Nhà Xuất Bản Văn Học', N'Hà Nội', '0912345678', 'nxbvanhoc@gmail.com'),
    ('NXB4', N'Nhà Xuất Bản Lao Động', N'Hải Phòng', '0976543210', 'nxblaodong@gmail.com'),
    ('NXB5', N'Nhà Xuất Bản Đại Học Quốc Gia Hà Nội', N'Hà Nội', '0945678901', 'nxbdhqghanoi@gmail.com'),
    ('NXB6', N'Nhà Xuất Bản Tổng Hợp TPHCM', N'Hồ Chí Minh', '0932109876', 'nxbtnhcm@gmail.com'),
    ('NXB7', N'Nhà Xuất Bản Phụ Nữ', N'Hà Nội', '0965432198', 'nxbphunu@gmail.com'),
    ('NXB8', N'Nhà Xuất Bản Thanh Niên', N'Hồ Chí Minh', '0923456789', 'nxbthanhnien@gmail.com'),
    ('NXB9', N'Nhà Xuất Bản Văn Lang', N'Hồ Chí Minh', '0956789012', 'nxbvanlang@gmail.com'),
    ('NXB10', N'Nhà Xuất Bản Tri Thức', N'Hà Nội', '0910987654', 'nxbtrithuc@gmail.com');

INSERT INTO THELOAI (MATL, TENTL, DIENGIAI) 
VALUES
    ('TL1', N'Văn Học', N'Thể loại văn học'),
    ('TL2', N'Khoa Học', N'Thể loại khoa học'),
    ('TL3', N'Lịch Sử', N'Thể loại lịch sử'),
    ('TL4', N'Tiểu Thuyết', N'Thể loại tiểu thuyết'),
    ('TL5', N'Kinh Tế', N'Thể loại kinh tế'),
    ('TL6', N'Tâm Lý', N'Thể loại tâm lý'),
    ('TL7', N'Kỹ Năng Sống', N'Thể loại kỹ năng sống'),
    ('TL8', N'Thiếu Nhi', N'Thể loại thiếu nhi'),
    ('TL9', N'Làm Đẹp', N'Thể loại làm đẹp'),
    ('TL10', N'Lịch', N'Thể loại lịch');

INSERT INTO CHUCVU (MACV, TENCV, LUONG) VALUES
    ('CV1', N'Quản lý', 10000000),
    ('CV2', N'Nhân viên bán hàng', 5000000),
    ('CV3', N'Kế toán', 8000000),
    ('CV4', N'Nhân viên phục vụ', 4000000),
    ('CV5', N'Quản lý kho', 7000000),
    ('CV6', N'Nhân viên văn phòng', 4500000),
    ('CV7', N'Marketing', 6000000),
    ('CV8', N'Bảo vệ', 3500000),
    ('CV9', N'Kỹ thuật viên', 5500000),
    ('CV10', N'Tư vấn viên', 4800000);

INSERT INTO KHACHHANG (MAKH, HOTENKH, DIACHIKH, SODT, EMAILKH) VALUES
    ('KH1', N'Nguyễn Văn A', N'Hà Nội', '0987654321', 'vana@gmail.com'),
    ('KH2', N'Trần Thị B', N'Hồ Chí Minh', '0901234567', 'thib@gmail.com'),
    ('KH3', N'Lê Văn C', N'Đà Nẵng', '0912345678', 'vanc@gmail.com'),
    ('KH4', N'Phạm Thị D', N'Hải Phòng', '0976543210', 'thid@gmail.com'),
    ('KH5', N'Hoàng Văn E', N'Hà Nội', '0945678901', 'vane@gmail.com'),
    ('KH6', N'Nguyễn Thị F', N'Hồ Chí Minh', '0932109876', 'thif@gmail.com'),
    ('KH7', N'Vũ Văn G', N'Hà Nội', '0965432198', 'vang@gmail.com'),
    ('KH8', N'Đỗ Thị H', N'Hồ Chí Minh', '0923456789', 'thih@gmail.com'),
    ('KH9', N'Lý Văn I', N'Đà Nẵng', '0956789012', 'vani@gmail.com'),
    ('KH10', N'Trần Văn K', N'Hải Phòng', '0910987654', 'vank@gmail.com');

INSERT INTO NHANVIEN (MANV, MACV, HOTENNV, DIACHINV, SODT, EMAILNV) VALUES
    ('NV1', 'CV1', N'Nguyễn Văn Dũng', N'Hà Nội', '0987654321', 'nguyenb@gmail.com'),
    ('NV2', 'CV2', N'Trần Thị Lê Anh', N'Hồ Chí Minh', '0901234567', 'km123@gmail.com'),
    ('NV3', 'CV3', N'Lê Văn Duy', N'Đà Nẵng', '0912345678', 'led@gmail.com'),
    ('NV4', 'CV4', N'Phạm Thị Tú', N'Hải Phòng', '0976543210', 'phame@gmail.com'),
    ('NV5', 'CV5', N'Hoàng Văn Trung',N'Hà Nội', '0945678901', 'hoangf@gmail.com'),
    ('NV6', 'CV6', N'Nguyễn Thị Huệ', N'Hồ Chí Minh', '0932109876', 'nguyeng@gmail.com'),
    ('NV7', 'CV9', N'Vũ Văn Huy', N'Hà Nội', '0965432198', 'vuh@gmail.com'),
    ('NV8', 'CV9', N'Đỗ Thị Thiên Lý', N'Hồ Chí Minh', '0923456789', 'doi@gmail.com'),
    ('NV9', 'CV9', N'Lý Văn Kiên', N'Đà Nẵng', '0956789012', 'lyk@gmail.com'),
    ('NV10', 'CV1', N'Trần Văn Lượng', N'Hải Phòng', '0910987654', 'tranl@gmail.com'),
	('NV11', 'CV1', N'Trần Hoàng Khôi', N'Bạc Liêu', '0945361927', 'mrkhoibl789@gmail.com'),
	('NV12', 'CV3', N'Vũ Thị Huyền Vi', N'Thanh Hóa', '0386142745', 'vuhuyenvi2003@gmail.com'),
	('NV13', 'CV2', N'Nguyễn Minh Đức', N'Thái Bình', '0910987654', 'boyprolun@gmail.com');

SELECT MASACH
FROM SACH
ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)

SET DATEFORMAT DMY;
INSERT INTO SACH (MASACH, MANXB, MATL, TENSACH, MATG, NGAYXUATBAN, GIABAN, SOLUONGTON) VALUES
    ('S1', 'NXB1', 'TL1', N'Hoàng Tử Bé', 'TG1', '25-03-2022', 100000, 58),
    ('S2', 'NXB1', 'TL1', N'Tắt Đèn', 'TG2', '12-01-2021', 120000, 20),
    ('S3', 'NXB1', 'TL3', N'Đoạn Tình', 'TG3', '19-06-2021', 90000, 100),
    ('S4', 'NXB4', 'TL4', N'Quà tặng tương lai', 'TG4', '01-02-2022', 110000, 86),
    ('S5', 'NXB2', 'TL5', N'Công nhân', 'TG5', '31-01-2020', 95000, 30),
    ('S6', 'NXB6', 'TL1', N'Truyện Kiều', 'TG6', '20-06-2022', 130000, 15),
    ('S7', 'NXB3', 'TL2', N'Dế mèn phiêu lưu ký', 'TG7', '10-03-2022', 85000, 29),
    ('S8', 'NXB5', 'TL3', N'Vội vàng', 'TG8', '10-05-2021', 115000, 37),
    ('S9', 'NXB6', 'TL4', N'Vợ chồng A Phủ', 'TG9', '10-12-2020', 98000, 24),
    ('S10', 'NXB10', 'TL5', N'Con người và sự nghiệp', 'TG10', '26-08-2023', 125000, 42);

SET DATEFORMAT DMY;

INSERT INTO KHUYENMAI (MAKM, NGAYBD, NGAYKT, GIAMGIA) VALUES
    ('KM1', '01-01-2023', '31-01-2023', 0.2),
    ('KM2', '01-02-2023', '28-02-2023', 0.15),
    ('KM3', '01-03-2023', '31-03-2023', 0.25),
    ('KM4', '01-04-2023', '30-04-2023', 0.3),
    ('KM5', '01-05-2023', '31-05-2023', 0.1),
    ('KM6', '01-06-2023', '30-06-2023', 0.2),
    ('KM7', '01-07-2023', '31-07-2023', 0.15),
    ('KM8', '01-08-2023', '31-08-2023', 0.25),
    ('KM9', '01-09-2023', '30-09-2023', 0.2),
    ('KM10', '01-10-2023', '31-10-2023', 0.1);

INSERT INTO SACHKHUYENMAI (ID, MASACH, MAKM) VALUES
    (1, 'S1', 'KM1'),
    (2, 'S2', 'KM1'),
    (3, 'S3', 'KM2'),
    (4, 'S4', 'KM3'),
    (5, 'S5', 'KM5'),
    (6, 'S6', 'KM7'),
    (7, 'S7', 'KM7'),
    (8, 'S8', 'KM8'),
    (9, 'S9', 'KM9'),
    (10, 'S10', 'KM10');

INSERT INTO HOADON (MAHD, MANV, MAKH, NGAYLAP, TRANGTHAIDH, THANHTIEN) VALUES
    ('HD1', 'NV1', 'KH1', '01/01/2023', N'Hoàn thành', 560000),
    ('HD2', 'NV1', 'KH2', '02/01/2023', N'Đang xử lý', 900000),
    ('HD3', 'NV3', 'KH3', '03/01/2023', N'Hoàn thành', 220000),
    ('HD4', 'NV4', 'KH1', '04/01/2023', N'Đang xử lý', 95000),
    ('HD5', 'NV4', 'KH5', '05/01/2023', N'Hoàn thành', 520000),
    ('HD6', 'NV6', 'KH2', '06/01/2023', N'Hoàn thành', 485000),
    ('HD7', 'NV7', 'KH7', '07/01/2023', N'Đang xử lý', 255000),
    ('HD8', 'NV8', 'KH8', '08/01/2023', N'Hoàn thành', 250000);
    

INSERT INTO CHITIETHD (MASACH, MAHD, GIABAN, SOLUONG, TONGTIEN) VALUES
    ('S1', 'HD1', 100000, 2, 200000),
    ('S2', 'HD1', 120000, 3, 360000),
    ('S3', 'HD2', 90000, 1, 90000),
    ('S4', 'HD3', 110000, 2, 220000),
    ('S5', 'HD4', 95000, 1, 95000),
    ('S6', 'HD5', 130000, 4, 520000),
    ('S7', 'HD6', 85000, 3, 255000),
    ('S8', 'HD6', 115000, 2, 230000),
    ('S9', 'HD7', 98000, 1, 98000),
    ('S10', 'HD8', 125000, 2, 250000);



SET DATEFORMAT DMY;

--INSERT INTO PHIEUNHAP (MAPHIEUNHAP, NGAYNHAP, THANHTIEN, MANV, MANCC)VALUES
--    ('PN001', '25-03-2022', NULL, 'NV1', 'NCC001'),
--    ('PN002', '25-03-2022', NULL, 'NV2', 'NCC002'),
--    ('PN003', '25-03-2022', NULL, 'NV3', 'NCC003'),
--    ('PN004', '25-03-2022', NULL, 'NV4', 'NCC004'),
--    ('PN005', '25-03-2022', NULL, 'NV5', 'NCC005');

SELECT * FROM PHIEUNHAP;

UPDATE PHIEUNHAP
SET THANHTIEN = (
    SELECT SUM(TONGTIEN)
    FROM CHITIETPN
    WHERE CHITIETPN.MAPHIEUNHAP = PHIEUNHAP.MAPHIEUNHAP
);


--INSERT INTO CHITIETPN (MASACH, MAPHIEUNHAP, GIANHAP, SOLUONGNHAP, TONGTIEN)VALUES
--    ('S1', 'PN001', 100000, 20, NULL),
--    ('S2', 'PN001', 120000, 30, NULL),
--    ('S3', 'PN002', 90000, 40, NULL),
--    ('S4', 'PN003', 110000, 50, NULL),
--    ('S5', 'PN005', 95000, 60, NULL),
--	('S6', 'PN004', 130000, 10, NULL);

UPDATE CHITIETPN
SET TONGTIEN = GIANHAP * SOLUONGNHAP

SELECT * FROM CHITIETPN;

INSERT INTO TAIKHOAN
VALUES
   ('admin','Nguyen Minh Duc', 'md123', 'Admin', 'NV1'),
   ('hoangkhoi', 'Hoang Khoi', 'khoi123', 'Admin', 'NV11'),
   ('huyenvi', 'Huyen Vi', 'vhv123', 'User', 'NV12'),
   ('minhduc', 'Minh Duc', 'md123', 'User', 'NV13');


SELECT * FROM TACGIA;
SELECT * FROM NHAXUATBAN;
SELECT * FROM THELOAI;
SELECT * FROM CHUCVU;
SELECT * FROM KHACHHANG;
SELECT * FROM NHANVIEN;
SELECT * FROM SACH;
SELECT * FROM KHUYENMAI;
SELECT * FROM SACHKHUYENMAI;
SELECT * FROM HOADON;
SELECT * FROM CHITIETHD;
SELECT * FROM TAIKHOAN;

-- ========================  RANG BUOC =============================     --
-- ====================================================================  --
--                                                                       --
--                         BANG TAC GIA                             --
--                                                                       --
-- ====================================================================  --
-- Ràng buộc kiểm tra số điện thoại bắt đầu bằng chữ số
ALTER TABLE TACGIA
ADD CONSTRAINT CHK_SODT CHECK (SODT LIKE '[0-9]%')

-- Ràng buộc duy nhất cho email
ALTER TABLE TACGIA 
ADD CONSTRAINT UNI_EMAIL UNIQUE(EMAILTG) 

--Nếu không có giá trị nào được cung cấp cho cột DIACHITG trong quá trình thêm dữ liệu mới, giá trị mặc định 'CHƯA XÁC ĐỊNH' sẽ được tự động áp dụng.
ALTER TABLE TACGIA
ADD CONSTRAINT DF_DIACHITG DEFAULT N'CHƯA XÁC ĐỊNH' FOR DIACHITG

--Ràng buộc TACGIA cho cột SODT, đảm bảo rằng chỉ chứa các số điện thoại có 10 chữ số.
ALTER TABLE TACGIA
ADD CONSTRAINT CK_SODT CHECK (LEN(SODT) = 10);

--Ràng buộc này kiểm tra rằng cột EMAILNXB phải chứa một địa chỉ email hợp lệ. 
ALTER TABLE TACGIA
ADD CONSTRAINT CK_EMAIL CHECK (EMAIL LIKE '%@%.%')


-- ====================================================================  --
--                                                                       --
--                         BANG NHA XUAT BAN                             --
--                                                                       --
-- ====================================================================  --
-- Ràng buộc kiểm tra số điện thoại bắt đầu bằng chữ số
ALTER TABLE NHAXUATBAN
ADD CONSTRAINT CHK_SODT CHECK (SODT LIKE '[0-9]%')

--Ràng buộc này đảm bảo rằng mỗi giá trị trong cột EMAILNXB là duy nhất và không được phép trùng lặp.
ALTER TABLE NHAXUATBAN
ADD CONSTRAINT UNI_EMAILNXB UNIQUE(EMAILNXB)

--Ràng buộc này kiểm tra rằng cột EMAILNXB phải chứa một địa chỉ email hợp lệ. 
ALTER TABLE NHAXUATBAN
ADD CONSTRAINT CK_EMAILNXB CHECK (EMAILNXB LIKE '%@%.%')

--Ràng buộc này đảm bảo rằng mỗi giá trị trong cột MANXB là duy nhất và không được phép trùng lặp.
ALTER TABLE NHAXUATBAN
ADD CONSTRAINT UNI_MANXB UNIQUE(MANXB)

--Nếu không có giá trị nào được cung cấp cho cột TENNXB trong quá trình thêm dữ liệu mới, giá trị mặc định 'CHƯA XÁC ĐỊNH' sẽ được tự động áp dụng.
ALTER TABLE NHAXUATBAN
ADD CONSTRAINT DF_TENNXB DEFAULT N'CHƯA XÁC ĐỊNH' FOR TENNXB

--Ràng buộc CHECK cho cột SODT, đảm bảo rằng chỉ chứa các số điện thoại có 10 chữ số.
ALTER TABLE NHAXUATBAN
ADD CONSTRAINT CK_SODT CHECK (LEN(SODT) = 10);


-- ====================================================================  --
--                                                                       --
--                         BANG THE LOAI                                 --
--                                                                       --
-- ====================================================================  --

--Ràng buộc này đảm bảo rằng mỗi giá trị trong cột MATL là duy nhất và không được phép trùng lặp.
ALTER TABLE THELOAI
ADD CONSTRAINT UNI_MATL UNIQUE(MATL)

--Rang buộc trong DIENGIAI phải có chuỗi 'thể loại'
ALTER TABLE THELOAI
ADD CONSTRAINT CHK_DIENGIAI CHECK (DIENGIAI LIKE 'Thể loại')

-- ====================================================================  --
--                                                                       --
--                         BANG CHUC VU                                  --
--                                                                       --
-- ====================================================================  --
--Ràng buộc lương phải lớn hơn 0
ALTER TABLE CHUCVU
ADD CONSTRAINT CHK_LUONG CHECK (LUONG > 0)

--Ràng buộc MACV là duy nhất
ALTER TABLE CHUCVU
ADD CONSTRAINT UNI_MACV UNIQUE(MACV)


-- ====================================================================  --
--                                                                       --
--                         BANG KHACH HANG                               --
--                                                                       --
-- ====================================================================  --
--Nếu không có giá trị nào được cung cấp cho cột HOTENKH trong quá trình thêm dữ liệu mới, giá trị mặc định 'CHƯA XÁC ĐỊNH' sẽ được tự động áp dụng
ALTER TABLE KHACHHANG
ADD CONSTRAINT DF_HOTENKH DEFAULT N'KHÔNG XÁC ĐỊNH' FOR HOTENKH

--Nếu không có giá trị nào được cung cấp cho cột DIACHIKH trong quá trình thêm dữ liệu mới, giá trị mặc định 'CHƯA XÁC ĐỊNH' sẽ được tự động áp dụng.
ALTER TABLE KHACHHANG
ADD CONSTRAINT DF_DIACHIKH DEFAULT N'KHÔNG XÁC ĐỊNH' FOR DIACHIKH

--Ràng buộc CHECK cho cột SODT, đảm bảo rằng chỉ chứa các số điện thoại có 10 chữ số.
ALTER TABLE SODT
ADD CONSTRAINT CHK_SODT CHECK (LEN(SODT)= 10)

-- Ràng buộc kiểm tra số điện thoại bắt đầu bằng chữ số
ALTER TABLE SODT
ADD CONSTRAINT CHK_SODT CHECK (SODT LIKE '[0-9]%')

--Ràng buộc này đảm bảo rằng mỗi giá trị trong cột EMAILKH là duy nhất và không được phép trùng lặp.
ALTER TABLE SODT
ADD CONSTRAINT UNI_EMAILKH UNIQUE(EMAILKH)

--Ràng buộc này kiểm tra rằng cột EMAILKH phải chứa một địa chỉ email hợp lệ. 
ALTER TABLE SODT
ADD CONSTRAINT CK_EMAILKH CHECK (EMAILKH LIKE '%@%.%')


-- ====================================================================  --
--                                                                       --
--                         BANG NHAN VIEN                               --
--                                                                       --
-- ====================================================================  --
-- Ràng buộc kiểm tra MANV nhập vào phải có 2 chữ cái đầu là NV
ALTER TABLE NHANVIEN
ADD CONSTRAINT CHK_MANV CHECK (MANV LIKE 'NV')

-- Ràng buộc kiểm tra MACV nhập vào phải có 2 chữ cái đầu là CV
ALTER TABLE NHANVIEN
ADD CONSTRAINT CHK_MACV CHECK (MACV LIKE 'CV')

-- Ràng buộc đảm bảo MANV nhập vào là duy nhất và không trùng lặp
ALTER TABLE NHANVIEN
ADD CONSTRAINT UNI_MANV UNIQUE (MANV)

-- Ràng buộc đảm bảo MACV nhập vào là duy nhất và không trùng lặp
ALTER TABLE NHANVIEN
ADD CONSTRAINT UNI_MACV UNIQUE (MACV)

-- Ràng buộc đảm bảo EMAILNV nhập vào là duy nhất và không trùng lặp
ALTER TABLE NHANVIEN
ADD CONSTRAINT UNI_EMAIL UNIQUE (EMAILNV)

-- Ràng buộc giá trị mặc định được trả về là 'Không xác định' nếu DIACHINV là NULL
ALTER TABLE NHANVIEN
ADD CONSTRAINT DF_DIACHINV DEFAULT N'Không xác định' FOR DIACHINV

-- Ràng buộc giá trị mặc định được trả về là 'Không xác định' nếu SODT là NULL
ALTER TABLE NHANVIEN
ADD CONSTRAINT DF_SODT DEFAULT N'Không xác định' FOR SODT

-- ====================================================================  --
--                                                                       --
--                         BANG SACH                                     --
--                                                                       --
-- ====================================================================  --
-- Ràng buộc bảng sách
-- Ràng buộc kiểm tra MASACH nhập vào phải có chữ cái đầu là S
ALTER TABLE SACH
ADD CONSTRAINT CHK_MASACH CHECK (MASACH LIKE 'S')

-- Ràng buộc kiểm tra GIABAN nhập vào phải có giá trị > 0
ALTER TABLE SACH
ADD CONSTRAINT CHK_GIABAN CHECK (GIABAN > 0)

-- Ràng buộc kiểm tra TRANGTHAI nhập vào phải có giá trị là CB hoặc B
ALTER TABLE SACH
ADD CONSTRAINT CHK_TRANGTHAI CHECK (TRANGTHAI ='CB' OR TRANGTHAI ='B')

-- Ràng buộc đảm bảo MASACH nhập vào là duy nhất và không trùng lặp
ALTER TABLE SACH
ADD CONSTRAINT UNI_MASACH UNIQUE (MASACH)

-- ====================================================================  --
--                                                                       --
--                         BANG KHUYEN MAI                               --
--                                                                       --
-- ====================================================================  --
-- Ràng buộc kiểm tra MAKM nhập vào phải có 2 chữ cái đầu là KM 
ALTER TABLE KHUYENMAI
ADD CONSTRAINT CHK_MAKM CHECK (MAKM LIKE 'KM')

-- Ràng buộc kiểm tra NGAYBD nhập vào phải nhỏ hơn NGAYKT
ALTER TABLE KHUYENMAI
ADD CONSTRAINT CHK_NGAYBD CHECK (NGAYBD < NGAYKT)

-- Ràng buộc kiểm tra NGAYKT nhập vào phải nhỏ hơn ngày hiện tại
ALTER TABLE KHUYENMAI
ADD CONSTRAINT CHK_NGAYKT CHECK (NGAYKT < GETDATE())

-- Ràng buộc đảm bảo MAKM nhập vào là duy nhất và không trùng lặp
ALTER TABLE KHUYENMAI
ADD CONSTRAINT UNI_MAKM UNIQUE (MAKM)

-- Ràng buộc giá trị mặc định được trả về là không xác định nếu NGAYBD là NULL
ALTER TABLE KHUYENMAI
ADD CONSTRAINT DF_NGAYBD DEFAULT N'Không xác định' FOR NGAYBD


-- ====================================================================  --
--                                                                       --
--                         BANG SACH KHUYEN MAI                          --
--                                                                       --
-- ====================================================================  --
--Ràng buộc bảng SACHKHUYENMAI
-- Ràng buộc kiểm tra ID nhập vào phải có giá trị > 0
ALTER TABLE SACHKHUYENMAI
ADD CONSTRAINT CHK_ID CHECK (ID > 0 )

--Ràng buộc bảng HOADON
ALTER TABLE HOADON
-- Ràng buộc kiểm tra MAHD nhập vào phải có 2 chữ cái đầu là HD
ADD CONSTRAINT CHK_MAHD CHECK (MAHD LIKE 'HD' )

--Ràng buộc kiểm tra NGAYLAP phải nhỏ hơn hoặc bằng thời gian hiện tại
ALTER TABLE HOADON
ADD CONSTRAINT CHK_NGAYLAP CHECK (NGAYLAP <= GETDATE())

-- Ràng buộc kiểm tra TRANGTHAI được nhập vào phải bằng 'Hoàn thành' hoặc 'Đang xử lý'
ALTER TABLE HOADON
ADD CONSTRAINT CHK_TRANGTHAI CHECK (TRANGTHAI = N'Hoàn thành' OR TRANGTHAI = N'Đang xử lý')

-- Ràng buộc kiểm tra THANHTIEN được nhập vào phải lớn hơn 0
ALTER TABLE HOADON
ADD CONSTRAINT CHK_THANHTIEN CHECK (THANHTIEN > 0)

-- Ràng buộc đảm bảo MAHD nhập vào là duy nhất và không trùng lặp  
ALTER TABLE HOADON
ADD CONSTRAINT CHK_MAHD UNIQUE (MAHD)


-- ====================================================================  --
--                                                                       --
--                         BANG CHITIETHD                                --
--                                                                       --
-- ====================================================================  --
-- Ràng buộc kiểm tra MASACH nhập vào phải có chữ cái đầu là S
ALTER TABLE CHITIETHD
ADD CONSTRAINT CHK_MASACH CHECK (MASACH LIKE 'S')

--Ràng buộc kiểm tra GIABAN nhập vào phải có giá trị > 0
ALTER TABLE CHITIETHD
ADD CONSTRAINT CHK_GIABAN CHECK (GIABAN > 0)

-- Ràng buộc kiểm tra SOLUONG nhập vào phải có giá trị >  0
ALTER TABLE CHITIETHD
ADD CONSTRAINT CHK_SOLUONG CHECK (SOLUONG > 0)

-- Ràng buộc kiểm tra TONGTIEN nhập vào phải có giá trị > 0
ALTER TABLE CHITIETHD
ADD CONSTRAINT CHK_TONGTIEN CHECK (TONGTIEN > 0)










-------------------VU THI HUYEN VI----------------------
-----TRIGGER 
-----TRIGGER Kiem tra luong phai lon hon 0
CREATE TRIGGER KT_LUONG ON CHUCVU
FOR INSERT, UPDATE
AS
IF(SELECT LUONG FROM inserted) > 0
	COMMIT TRAN
ELSE
	BEGIN
		PRINT N'Lương phải lớn hơn 0'
		ROLLBACK TRAN
	END


--THEM DUOC
INSERT INTO CHUCVU
values
('CV12', N'Quan ly', 123456)

--KHONG THEM DUOC
INSERT INTO CHUCVU
values
('CV11', N'Quan ly', -1)

SELECT * FROM CHUCVU

DROP TRIGGER KT_LUONG
-----TRUY VAN CO BAN

--Cau 1: Truy vấn tên nhà xuất bản và địa chỉ của nhà xuất bản có mã 'NXB3':
SELECT TENNXB, DIACHINXB FROM NHAXUATBAN WHERE MANXB = 'NXB3';

--Cau 2: Truy vấn danh sách tên và địa chỉ của tất cả khách hàng:
SELECT HOTENKH, DIACHIKH FROM KHACHHANG;

--Cau 3: Truy vấn tên nhân viên và chức vụ của nhân viên có mã 'NV2':
SELECT HOTENNV, TENCV FROM NHANVIEN 
INNER JOIN CHUCVU ON NHANVIEN.MACV = CHUCVU.MACV
WHERE MANV = 'NV2';

--Cau 4: Truy vấn thông tin sách bao gồm tên sách, tên tác giả và tên thể loại của tất cả các sách:
SELECT TENSACH, TENTG, TENTL FROM SACH 
INNER JOIN TACGIA ON SACH.MATG = TACGIA.MATG 
INNER JOIN THELOAI ON SACH.MATL = THELOAI.MATL;

--Cau 5: Truy vấn tổng số lượng sách có trong cơ sở dữ liệu:
SELECT COUNT(*) AS N'Tổng số sách' FROM SACH;

-----TRUY VAN NANG CAO

--Cau 6: Liệt kê tên các nhà xuất bản và số sách đã xuất bản của mỗi nhà xuất bản:
SELECT NHAXUATBAN.TENNXB, COUNT(SACH.MASACH) AS SoSachXuatBan
FROM NHAXUATBAN
JOIN SACH ON NHAXUATBAN.MANXB = SACH.MANXB
GROUP BY NHAXUATBAN.TENNXB;

--Cau 7: Tìm tên tác giả và số sách đã viết của tác giả có ít nhất một sách đang trong khuyến mãi:
SELECT TACGIA.TENTG, COUNT(SACHKHUYENMAI.MASACH) AS SoSachViet
FROM TACGIA
JOIN SACH ON TACGIA.MATG = SACH.MATG
JOIN SACHKHUYENMAI ON SACH.MASACH = SACHKHUYENMAI.MASACH
GROUP BY TACGIA.TENTG
HAVING COUNT(SACHKHUYENMAI.MASACH) >= 1;

--Cau 8: Tính tổng số sách đã được bán cho mỗi khách hàng và sắp xếp theo tổng số sách giảm dần:
SELECT HOADON.MAKH, KHACHHANG.HOTENKH, COUNT(CHITIETHD.MASACH) AS TongSoSachBan
FROM HOADON
JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH
JOIN CHITIETHD ON HOADON.MAHD = CHITIETHD.MAHD
GROUP BY HOADON.MAKH, KHACHHANG.HOTENKH
ORDER BY TongSoSachBan DESC;

--Cau 9: Truy vấn danh sách tên khách hàng và số điện thoại của những khách hàng có địa chỉ ở Hà Nội và số điện thoại bắt đầu bằng số 98:
SELECT HOTENKH, SODT
FROM KHACHHANG
WHERE DIACHIKH = N'Hà Nội' AND SODT LIKE '98%';

--Cau 10: Lấy tổng số lượng sách bán được và doanh thu từng sách của mỗi hóa đơn:
SELECT HD.MAHD, SUM(CT.SOLUONG) AS TONGSOLUONG, SUM(CT.TONGTIEN) AS DOANHTHU
FROM HOADON AS HD
JOIN CHITIETHD AS CT ON HD.MAHD = CT.MAHD
GROUP BY HD.MAHD;

-------------------TRAN HOANG KHOI----------------------
-----TRIGGER
CREATE TRIGGER KT1_GIASACH
ON SACH
FOR INSERT
AS
BEGIN
    IF (SELECT GIABAN FROM inserted) > 0
	COMMIT TRAN
	ELSE
    BEGIN
        PRINT N'Giá bán phải lớn hơn 0'
        ROLLBACK TRAN
    END
END

--THEM DUOC
INSERT INTO SACH
VALUES
('S12', 'NXB10', 'TL5', 'Sách 10', 'TG10', 2022, 50000, 'CB');

--THEM KHONG DUOC
INSERT INTO SACH
VALUES
('S20', 'NXB10', 'TL5', 'Sách 10', 'TG10', 2022, -1, 'CB');

SELECT * FROM SACH

DROP TRIGGER KT1_GIASACH

-----TRUY VAN DON GIAN
--Cau 1: Tìm thông tin về tác giả có mã tác giả là 'TG2':
SELECT * FROM TACGIA WHERE MATG = 'TG2';

--Cau 2: Truy vấn danh sách tên và địa chỉ của tất cả khách hàng:
SELECT HOTENKH, DIACHIKH FROM KHACHHANG;

--Cau 3: Truy vấn danh sách các sách thuộc thể loại 'Khoa Học':
SELECT * FROM SACH 
INNER JOIN THELOAI ON SACH.MATL = THELOAI.MATL
WHERE TENTL = N'Khoa Học';

--Cau 4: Truy vấn danh sách các sách được khuyến mãi và thông tin về khuyến mãi áp dụng cho sách đó:
SELECT SACH.*, KHUYENMAI.* FROM SACH 
INNER JOIN SACHKHUYENMAI ON SACH.MASACH = SACHKHUYENMAI.MASACH
INNER JOIN KHUYENMAI ON SACHKHUYENMAI.MAKM = KHUYENMAI.MAKM;

--Cau 5: Truy vấn thông tin về hóa đơn bao gồm mã hóa đơn, tên khách hàng và tổng tiền của tất cả các hóa đơn:
SELECT HOADON.MAHD, KHACHHANG.HOTENKH, HOADON.THANHTIEN FROM HOADON 
INNER JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH;

-----TRUY VAN NANG CAO
--Cau 6: Lấy danh sách tên khách hàng và tổng số tiền đã chi tiêu cho mỗi khách hàng từ các hóa đơn (tính cả thuế VAT 10%):
SELECT KH.HOTENKH, SUM(CT.SOLUONG * S.GIABAN * 1.1) AS TONGCHITIEU
FROM KHACHHANG KH
JOIN HOADON HD ON KH.MAKH = HD.MAKH
JOIN CHITIETHD CT ON HD.MAHD = CT.MAHD
JOIN SACH S ON CT.MASACH = S.MASACH
GROUP BY KH.HOTENKH

--Cau 7: Lấy danh sách tên khách hàng và số lượng sách đã mua của mỗi khách hàng, sắp xếp theo số lượng sách đã mua giảm dần:
SELECT KH.HOTENKH, SUM(CT.SOLUONG) AS SOLUONGSACHMUA
FROM KHACHHANG KH
JOIN HOADON HD ON KH.MAKH = HD.MAKH
JOIN CHITIETHD CT ON HD.MAHD = CT.MAHD
GROUP BY KH.HOTENKH
ORDER BY SOLUONGSACHMUA DESC

--Cau 8: Lấy danh sách tên tác giả và tổng số tiền đã kiếm được từ việc bán sách của mỗi tác giả (tính cả thuế VAT 10%), sắp xếp theo tổng số tiền kiếm được tăng dần:
SELECT TG.TENTG, SUM(CT.SOLUONG * S.GIABAN * 1.1) AS TONGTIENKIEMDUOC
FROM TACGIA TG
JOIN SACH S ON TG.MATG = S.MATG
JOIN CHITIETHD CT ON S.MASACH = CT.MASACH
GROUP BY TG.TENTG
ORDER BY TONGTIENKIEMDUOC ASC

--Cau 9: Lấy danh sách tên khách hàng và tổng số tiền đã chi tiêu trong mỗi tháng, sắp xếp theo tháng tăng dần và tổng số tiền giảm dần:
SELECT KH.HOTENKH, MONTH(HD.NGAYLAP) AS THANG, SUM(CT.SOLUONG * S.GIABAN * 1.1) AS TONGTIENCHITIEU
FROM KHACHHANG KH
JOIN HOADON HD ON KH.MAKH = HD.MAKH
JOIN CHITIETHD CT ON HD.MAHD = CT.MAHD
JOIN SACH S ON CT.MASACH = S.MASACH
GROUP BY KH.HOTENKH, MONTH(HD.NGAYLAP)
ORDER BY MONTH(HD.NGAYLAP) ASC, TONGTIENCHITIEU DESC;

--Cau 10: Lấy danh sách tất cả các khách hàng đã mua ít nhất 2 sản phẩm khác nhau trong cùng một đơn hàng, kèm theo thông tin về đơn hàng và sản phẩm:
SELECT KH.HOTENKH, HD.MAHD, S.TENSACH
FROM KHACHHANG KH
JOIN HOADON HD ON KH.MAKH = HD.MAKH
JOIN CHITIETHD CT ON HD.MAHD = CT.MAHD
JOIN SACH S ON CT.MASACH = S.MASACH
WHERE HD.MAHD IN (
    SELECT MAHD
    FROM CHITIETHD
    GROUP BY MAHD
    HAVING COUNT(DISTINCT MASACH) >= 2
);

------------- LƯƠNG MAI THANH THẢO ------------------
----TRIGGER----
---NĂM XUẤT BẢN PHẢI BÉ HƠN NĂM HIỆN TẠI VÀ LỚN HƠN NĂM 1900
CREATE TRIGGER TRG_NAMBEHONHIENTAI
ON SACH
FOR INSERT
AS
BEGIN
	IF((SELECT NAMXUATBAN FROM inserted)<=YEAR(GETDATE()) AND (SELECT NAMXUATBAN FROM inserted) > 1900)
		COMMIT TRAN
	ELSE
		PRINT N'NAM XUAT BAN PHAI BE HON NAM HIEN TAI'
		ROLLBACK TRAN
END
GO

--THEM DUOC
INSERT INTO SACH (MASACH, MANXB, MATL, TENSACH, MATG, NAMXUATBAN, GIABAN, TRANGTHAI) VALUES
('S15', 'NXB1', 'TL1', 'Sách 1', 'TG1', 1938, 100000, 'CB')

--KHONG THEM DUOC
INSERT INTO SACH (MASACH, MANXB, MATL, TENSACH, MATG, NAMXUATBAN, GIABAN, TRANGTHAI) VALUES
('S30', 'NXB1', 'TL1', 'Sách 1', 'TG1', 938, 100000, 'CB')

SELECT * FROM SACH

DROP TRIGGER TRG_NAMBEHONHIENTAI

------------- Truy vấn đơn giản ---------------------
--1) Cho biết thông tin các nhân viên mang họ Nguyễn
SELECT *
FROM NHANVIEN
WHERE HOTENNV LIKE N'Nguyễn%'

--2) Cho biết mã và tên những cuốn sách có giá bán trên 90000
SELECT MASACH, TENSACH
FROM SACH
WHERE GIABAN > 90000

--3) Cho biết mã những hóa đơn đang trong giai đoạn xử lý
SELECT MAHD
FROM HOADON
WHERE TRANGTHAIDH = N'Đang xử lý'

--4) Cho biết những chương trình khuyến mãi bắt đầu từ tháng 7 năm 2023
SELECT *
FROM KHUYENMAI
WHERE NGAYBD >= '2023-7-1'

--5) Cho biết mã và tên những cuốn sách thuộc nhà xuất bản trẻ
SELECT MASACH, TENSACH
FROM SACH
LEFT JOIN NHAXUATBAN ON SACH.MANXB = NHAXUATBAN.MANXB
WHERE TENNXB = N'Nhà xuất bản trẻ'

------------- Truy vấn nâng cao ---------------------
--6) Cho biết những hóa đơn có tổng hóa đơn trên 300000
SELECT MAHD, SUM(TONGTIEN) AS N'Tổng hóa đơn'
FROM CHITIETHD
GROUP BY MAHD
HAVING SUM(TONGTIEN) > 300000

--7) Cho biết tên các trạng thái và số hóa đơn mang trạng thái đó
SELECT TRANGTHAIDH, COUNT(MAHD) AS N'Số lượng hóa đơn'
FROM HOADON 
GROUP BY TRANGTHAIDH

--8) Cho biết tên và giá bán cuốn sách có giá cao nhất
SELECT *
FROM SACH
WHERE GIABAN >= ALL (
	SELECT GIABAN
	FROM SACH
)

--9) Cho biết thông tin những nhân viên chưa lập hóa đơn lần nào
SELECT *
FROM NHANVIEN
WHERE MANV NOT IN (
	SELECT MANV
	FROM HOADON
)

--10) Cho biết tên các chức vụ và số nhân viên đang làm chức vụ đó
SELECT CHUCVU.TENCV, COUNT(MANV) AS N'Số nhân viên'
FROM CHUCVU
LEFT JOIN NHANVIEN ON CHUCVU.MACV = NHANVIEN.MACV
GROUP BY CHUCVU.TENCV


------------- Nguyễn Minh Đức ------------------
----TRIGGER
-- Kiểm tra ngày bắt đầu khuyến mãi bé hơn ngày kết thúc khuyến mãi
CREATE TRIGGER KT_KHUYENMAI
ON KHUYENMAI
FOR INSERT
AS
	BEGIN
		IF((SELECT NGAYBD FROM inserted) < (SELECT NGAYKT FROM inserted))
			COMMIT TRAN
		ELSE
		PRINT N'Nhập dữ liệu không đúng'
		ROLLBACK TRAN
	END

SET DATEFORMAT DMY;
--Nhap khong duoc 
INSERT INTO KHUYENMAI (MAKM, NGAYBD, NGAYKT, GIAMGIA) VALUES
('KM12', '31-01-2023', '20-01-2023', 0.35)
-- Thực hiện cập nhật tổng tiền trên bảng HOADON mỗi khi thêm sửa xóa ở bảng CHITIETHD
CREATE TRIGGER UD_HOADON
ON CHITIETHD
FOR INSERT, UPDATE, DELETE
AS
	BEGIN
		UPDATE HOADON
		SET THANHTIEN = THANHTIEN + (SELECT TONGTIEN FROM inserted)
		WHERE HOADON.MAHD = (SELECT MAHD FROM inserted)

		UPDATE HOADON
		SET THANHTIEN = THANHTIEN - (SELECT TONGTIEN FROM deleted)
		WHERE HOADON.MAHD = (SELECT MAHD FROM deleted)
	END
INSERT INTO CHITIETHD (MASACH, MAHD, GIABAN, SOLUONG, TONGTIEN) 
VALUES
('S1', 'HD2', 100000, 2, 200000)

DELETE FROM CHITIETHD
WHERE MASACH = 'S1' AND MAHD = 'HD2'

SELECT * FROM HOADON
SELECT * FROM CHITIETHD

DROP TRIGGER KT_KHUYENMAI

DROP TRIGGER UD_HOADON

------------- TRUY VẤN CƠ BẢN ------------------
--1) Cho biết họ tên nhân viên có chức vụ là Quản Lý
SELECT HOTENNV
FROM NHANVIEN, CHUCVU
WHERE NHANVIEN.MACV = CHUCVU.MACV AND CHUCVU.TENCV = N'Quản Lý'
GROUP BY HOTENNV

--2) Sắp xếp danh sách tác giả tăng dần theo họ tên
SELECT * FROM TACGIA
ORDER BY TACGIA.TENTG ASC

--3) Cho biết tên sách và tỷ lệ giảm giá của cuốn sách đó
SELECT SACH.TENSACH , KHUYENMAI.GIAMGIA
FROM SACH,KHUYENMAI,SACHKHUYENMAI
WHERE SACH.MASACH = SACHKHUYENMAI.MASACH AND SACHKHUYENMAI.MAKM = KHUYENMAI.MAKM
GROUP BY SACH.TENSACH, KHUYENMAI.GIAMGIA

--4) Cho biết mã các hóa đơn đã hoàn thành
SELECT MAHD
FROM HOADON
WHERE TRANGTHAIDH = N'Hoàn Thành'

--5) Tổng thành tiền các hóa đơn đã hoàn thành
SELECT SUM(THANHTIEN) N'Tổng'
FROM HOADON
WHERE TRANGTHAIDH = N'Hoàn Thành'

------------- TRUY VẤN NÂNG CAO ------------------

--6) Truy vấn họ tên, địa chỉ và số lượng mua của các khách hàng đã mua sách của nhà xuất bản trẻ
SELECT KHACHHANG.HOTENKH, KHACHHANG.DIACHIKH, SUM( CHITIETHD.SOLUONG) N'Số Lượng'
FROM HOADON
INNER JOIN CHITIETHD ON HOADON.MAHD = CHITIETHD.MAHD
INNER JOIN SACH ON CHITIETHD.MASACH = SACH.MASACH
INNER JOIN NHAXUATBAN ON SACH.MANXB = NHAXUATBAN.MANXB
INNER JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH
WHERE NHAXUATBAN.TENNXB = N'Nhà Xuất Bản Trẻ'
GROUP BY KHACHHANG.HOTENKH, KHACHHANG.DIACHIKH

--7) Kiểm tra sách đã mua có được giảm giá hay không, nếu được thì cho biết mã hóa đơn và thành tiền sau khi giảm giá
SELECT HOADON.MAHD, HOADON.THANHTIEN - SUM((SACH.GIABAN * CHITIETHD.SOLUONG) * KHUYENMAI.GIAMGIA) N'Thành Tiền'
FROM HOADON
INNER JOIN CHITIETHD ON HOADON.MAHD = CHITIETHD.MAHD
INNER JOIN SACH ON CHITIETHD.MASACH = SACH.MASACH
INNER JOIN SACHKHUYENMAI ON SACH.MASACH = SACHKHUYENMAI.MASACH
INNER JOIN KHUYENMAI ON SACHKHUYENMAI.MAKM = KHUYENMAI.MAKM
WHERE HOADON.NGAYLAP < KHUYENMAI.NGAYKT
GROUP BY HOADON.MAHD, HOADON.THANHTIEN

--8) Cho biết mã, họ tên tác giả viết nhiều sách nhất
SELECT TACGIA.MATG, TACGIA.TENTG, COUNT (SACH.MASACH) AS N'Số Lượng'
FROM TACGIA, SACH
WHERE TACGIA.MATG = SACH.MATG
GROUP BY TACGIA.MATG, TACGIA.TENTG
HAVING COUNT (SACH.MASACH) >= ALL (
	SELECT COUNT (*)
	FROM SACH
	GROUP BY MATG
)

--9) Lấy ra thông tin của các khách hàng đã mua sách trong tháng 1 năm 2023 và số lượng sách mỗi khách hàng đã mua, sắp xếp theo số lượng sách mua giảm dần và chỉ lấy ra thông tin của các khách hàng đã mua hơn 2 quyển sách
SELECT KHACHHANG.HOTENKH, KHACHHANG.DIACHIKH, KHACHHANG.SODT, KHACHHANG.EMAILKH, COUNT(CHITIETHD.MASACH)  N'Số lượng sách đã mua'
FROM KHACHHANG
JOIN HOADON ON KHACHHANG.MAKH = HOADON.MAKH
JOIN CHITIETHD ON HOADON.MAHD = CHITIETHD.MAHD
WHERE MONTH(HOADON.NGAYLAP) = 1 AND YEAR(HOADON.NGAYLAP) = 2023
GROUP BY KHACHHANG.HOTENKH, KHACHHANG.DIACHIKH, KHACHHANG.SODT, KHACHHANG.EMAILKH
HAVING COUNT(CHITIETHD.MASACH) > 2
ORDER BY COUNT(CHITIETHD.MASACH) DESC;


--10) Lấy ra thông tin của các khách hàng đã mua sách trong tháng 1 năm 2023 và số lượng sách mỗi khách hàng đã mua, sắp xếp theo số lượng sách mua giảm dần và chỉ lấy ra thông tin của các khách hàng đã mua sách của tác giả Nguyễn Nhật Ánh và số lượng sách đã mua của từng khách hàng lớn hơn hoặc bằng 2
SELECT KHACHHANG.HOTENKH, KHACHHANG.DIACHIKH, KHACHHANG.SODT, KHACHHANG.EMAILKH, CHITIETHD.MASACH, SACH.TENSACH, CHITIETHD.SOLUONG
FROM KHACHHANG
JOIN HOADON ON KHACHHANG.MAKH = HOADON.MAKH
JOIN CHITIETHD ON HOADON.MAHD = CHITIETHD.MAHD
JOIN SACH ON CHITIETHD.MASACH = SACH.MASACH
JOIN TACGIA ON SACH.MATG = TACGIA.MATG
WHERE MONTH(HOADON.NGAYLAP) = 1 AND YEAR(HOADON.NGAYLAP) = 2023 AND TACGIA.TENTG = N'Nguyễn Nhật Ánh' AND CHITIETHD.SOLUONG > = 2
ORDER BY KHACHHANG.HOTENKH ASC;
---- THÔNG TIN SÁCH ----
--SELECT SACH.TENSACH, COUNT(CHITIETHD.MASACH) AS 'Số lượng sách đã mua'
--FROM SACH
--JOIN CHITIETHD ON SACH.MASACH = CHITIETHD.MASACH
--JOIN HOADON ON CHITIETHD.MAHD = HOADON.MAHD
--WHERE MONTH(HOADON.NGAYLAP) = 1 AND YEAR(HOADON.NGAYLAP) = 2023 AND CHITIETHD.MASACH IN (
   -- SELECT CHITIETHD.MASACH
   --FROM KHACHHANG
   -- JOIN HOADON ON KHACHHANG.MAKH = HOADON.MAKH
   -- JOIN CHITIETHD ON HOADON.MAHD = CHITIETHD.MAHD
   -- JOIN SACH ON CHITIETHD.MASACH = SACH.MASACH
   -- JOIN TACGIA ON SACH.MATG = TACGIA.MATG
   -- WHERE MONTH(HOADON.NGAYLAP) = 1 AND YEAR(HOADON.NGAYLAP) = 2023 AND TACGIA.TENTG = N'Nguyễn Nhật Ánh' AND CHITIETHD.SOLUONG > = 2)
--GROUP BY SACH.TENSACH;


-------------------VO TUAN KIET----------------------
--TRIGGER
--NAM XUAT BAN PHAI LON HON 2021
CREATE TRIGGER TRG_NAMXBLONHON2021
ON SACH
FOR INSERT
AS
BEGIN
	IF((SELECT NAMXUATBAN FROM inserted)>=2021)
		COMMIT TRAN
	ELSE
		PRINT N'NAM XUAT BAN PHAI LON HON 2021'
		ROLLBACK TRAN
END
GO
--THEM DUOC
INSERT INTO SACH
VALUES
('S22', 'NXB10', 'TL5', 'Sách 10', 'TG10', 2022, 50000, 'CB');

--THEM KHONG DUOC
INSERT INTO SACH
VALUES
('S23', 'NXB10', 'TL5', 'Sách 10', 'TG10', 2000, 10000, 'CB');


SELECT * FROM SACH
-----TRUY VAN DON GIAN

--Cau 1: Tìm thông tin về đợt khuyến mãi có mã khuyến mãi là 'KM3':
SELECT * FROM KHUYENMAI WHERE MAKM = 'KM3';

--Cau 2: Truy vấn mã sách và mã xuất bản của sách:
SELECT MASACH, MANXB FROM SACH;

--Cau 3: Truy vấn tổng số hoá đơn có trong hoá đơn:
SELECT COUNT(*) AS N'Tổng số hoá đơn' FROM HOADON;

--Cau 4: Truy vấn danh sách các sách thuộc nhà xuất bản Kim Đồng:
SELECT * FROM SACH 
INNER JOIN NHAXUATBAN ON SACH.MANXB= NHAXUATBAN.MANXB
WHERE TENNXB = N'Nhà Xuất Bản Kim Đồng';

--Cau 5: Cho biết thông tin những tác giả nào có quê ở Hải Phòng
SELECT MATG,TENTG,DIACHITG, SODT, EMAILTG
FROM TACGIA
WHERE DIACHITG = N'Hải Phòng'

------TRUY VAN NANG CAO
--Cau 6: Cho biết danh sách những khách hàng mua sách trong tháng 06/2016 có địa chỉ ở TP. HCM.
SELECT KHACHHANG.MAKH, HOTENKH
FROM KHACHHANG, HOADON
WHERE KHACHHANG.MAKH = HOADON.MAKH AND MONTH(HOADON.NGAYLAP) = 1 AND YEAR(HOADON.NGAYLAP) = 2023 AND KHACHHANG.DIACHIKH = N'Hồ Chí Minh'
GROUP BY KHACHHANG.MAKH, HOTENKH

--Cau 7:Lập danh sách bao gồm tên khách hàng và mã hoá đơn có tổng tiền lớn hơn 500.000 VND.
SELECT HOTENKH, CHITIETHD.MAHD
FROM KHACHHANG
JOIN HOADON ON KHACHHANG.MAKH = HOADON.MAKH
JOIN CHITIETHD ON CHITIETHD.MAHD = HOADON.MAHD
GROUP BY HOTENKH,CHITIETHD.MAHD
HAVING SUM(CHITIETHD.TONGTIEN) > 500000

--Cau 8: Những hoá đơn nào (MAHD) có số lượng sách lớn hơn 2?
SELECT HOADON.MAHD
FROM HOADON, CHITIETHD
WHERE HOADON.MAHD = CHITIETHD.MAHD
GROUP BY HOADON.MAHD
HAVING SUM(CHITIETHD.SOLUONG) > 2

 --Cau 9: Trong tháng 05/2016 có bao nhiêu khách hàng ở Hà Nội đến mua hàng?
SELECT COUNT(HOADON.MAKH) AS SOLUONGKH
FROM HOADON,KHACHHANG
WHERE HOADON.MAKH = KHACHHANG.MAKH AND YEAR(HOADON.NGAYLAP)=2023 AND MONTH(HOADON.NGAYLAP) = 1 AND KHACHHANG.DIACHIKH =N'Hà Nội'

--Cau 10: Thông tin những linh kiện (MALK, TENLK, NSX, DVT) được bán ra trước ngày 31/05/2015.
SELECT SACH.MASACH, TENSACH, MATL, NAMXUATBAN
FROM SACH
JOIN CHITIETHD ON SACH.MASACH = CHITIETHD.MASACH
JOIN HOADON ON HOADON.MAHD = CHITIETHD.MAHD
WHERE HOADON.NGAYLAP < '05/01/2023'


