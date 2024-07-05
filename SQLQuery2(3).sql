DROP DATABASE QL_BANVE

CREATE DATABASE QL_BANVE
use QL_BANVE

Create table HANGSX
(
	MAHANGSX char(10),
	TENHANGSX char(20),
	Constraint PK_HANGSX Primary key(MAHANGSX)
)
Create table LOAIXE
(
	MALOAIXE char(10),
	TENLOAIXE nvarchar(10),
	SOGHE INT,
	Constraint PK_LOAIXE Primary key(MALOAIXE)
)
Create table XE
(
	Maxe char(10),
	TENXE CHAR(25),
	BIENSOXE CHAR(10),
	MALOAIXE CHAR(10),
	MAHANGSX CHAR(10),
	Constraint PK_XE Primary key(MaXe),
	CONSTRAINT FK_XE_LOAIXE FOREIGN KEY (MALOAIXE) REFERENCES LOAIXE (MALOAIXE),
	CONSTRAINT FK_XE_HANGSX FOREIGN KEY (MAHANGSX) REFERENCES HANGSX (MAHANGSX)
)
Create table TuyenXe
(
	MaTuyen char(5) not null,
	TenTuyen nvarchar(50),
	DiemXP nvarchar(50),
	DiemDen nvarchar(50),
	Constraint PK_TuyenXe Primary key(MaTuyen)
)

CREATE TABLE Xe_TuyenXe (
    Maxe CHAR(10),
    MaTuyen CHAR(5),
    CONSTRAINT PK_Xe_TuyenXe PRIMARY KEY (Maxe, MaTuyen),
    CONSTRAINT FK_Xe_TuyenXe_Xe FOREIGN KEY (MaXe) REFERENCES Xe (MaXe),
    CONSTRAINT FK_Xe_TuyenXe_TuyenXe FOREIGN KEY (MaTuyen) REFERENCES TuyenXe (MaTuyen)
);

Create table Taixe
(
	MaTX CHAR(10) not null,
	TenTX NVARCHAR(50),
	SDT CHAR(10),
	NGAYSINH DATE,
	GIOITINH NVARCHAR(3),
	DIACHI NVARCHAR(70),
	CCCD CHAR(12),
	EMAIL CHAR(20),
	Constraint PK_Taixe Primary key(MaTX)
)
Create table ChuyenXe
(
	MaChuyen char(4) not null,
    Maxe CHAR(10),
    MaTuyen CHAR(5),
	NgayXP date,
	NgayDen date,
	GioXP time,
	GioDen time,
	Gia float,
	SOGHETRONG int,
	MaTX CHAR(10) not null,
	Constraint PK_ChuyenXe Primary key(MaChuyen),
	CONSTRAINT FK_ChuyenXe_TaiXe FOREIGN KEY (MaTX) REFERENCES TaiXe (MaTX),
	CONSTRAINT FK_ChuyenXe_Xe_TuyenXe FOREIGN KEY (Maxe, MaTuyen) REFERENCES Xe_TuyenXe (Maxe, MaTuyen)
)
Create table KhachHang
(
	MaKh INT IDENTITY (1,1) not null,
	TenKH nvarchar(50),
	NGAYSINH DATE,
	GIOITINH NVARCHAR(3),
	DIACHI NVARCHAR(70),
	CCCD CHAR(12),
	EMAIL CHAR(20),
	SDT CHAR(10),
	TAIKHOAN CHAR(20),
	MATKHAU CHAR(20),
	Constraint PK_KhachHang Primary key(MaKh)
)
CREATE TABLE ChucVu
(
	MAChucVu CHAR(10),
	TENChucVu NVARCHAR(20),
	Constraint PK_ChucVu Primary key(MAChucVu)
)
Create table NhanVien
(
	MaNV char(10)not null,
	TenNV nvarchar(50),
	SDT CHAR(10),
	NGAYSINH DATE,
	GIOITINH NVARCHAR(3),
	DIACHI NVARCHAR(70),
	CCCD CHAR(12),
	EMAIL CHAR(20),
	TAIKHOAN CHAR(20),
	MATKHAU CHAR(20),
	MACHUCVU CHAR(10),
	Constraint PK_NhanVien Primary key(MaNV),
	CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY (MACHUCVU) REFERENCES CHUCVU (MACHUCVU)
)
Create table Ve
(
	MaVe INT IDENTITY(1,1),
	MaChuyen char(4),
	MaKh INT,
	ThanhTien float,
	SOLUONG INT,
	NGAYDATVE DATE,
	CONSTRAINT PK_Ve Primary key(MaVe),
	CONSTRAINT FK_Ve_ChuyenXe FOREIGN KEY (MaChuyen) REFERENCES ChuyenXe (MaChuyen),
	CONSTRAINT FK_Ve_KhachHang FOREIGN KEY (MAKH) REFERENCES KhachHang (MAKH)
)

INSERT INTO HANGSX
VALUES ('H001', 'Hyundai'),
('H002','Mercedes Benz'),
('H003', 'Thaco');

INSERT INTO LOAIXE
VALUES ('L001', N'Loại 1', '25'),
('L002', N'Loại 2', '35'),
('L003', N'Loại 3', '45');

INSERT INTO Xe
VALUES ('X001', 'New Universe', '12A-123.12','L003','H001'),
('X002', 'New County', '56B-456.12','L002','H001'),
('X003', 'Mercedes Benz Montero S' , '45C-123.45','L003','H002'),
('X004', 'Mercedes Benz Montero SL', '98D-678.34','L001','H002'),
('X005', 'Mobihome Deluxe', '98D-678.34','L001','H003');

INSERT INTO TuyenXe
VALUES 
('T001', 	'Sài Gòn - Vũng Tàu',	'Sài Gòn',	'Vũng Tàu'),
('T002',	'Vũng Tàu - Sài Gòn',	'Vũng Tàu',	'Sài Gòn'),    
('T003', 	'Sài Gòn - Đà Lạt',	'Sài Gòn',	'Đà Lạt'),
('T004', 	'Đà Lạt - Sài Gòn',	'Đà Lạt',	'Sài Gòn'),    
('T005', 	'Tây Ninh - Bình Dương',	'Tây Ninh',	'Bình Dương'),      
('T006', 	'Bình Dương - Tây Ninh',	'Bình Dương',	'Tây Ninh'),    
('T007', 	'Cà Mau - Bến Tre',	'Cà Mau',	'Bến Tre'),
('T008', 	'Bến Tre - Cà Mau',	'Bến Tre',	'Cà Mau'),    
('T009', 	'Tiền Giang - An Giang',	'Tiền Giang',	'An Giang'),      
('T010', 	'An Giang - Tiền Giang',	'An Giang',	'Tiền Giang');

INSERT INTO Xe_TuyenXe
VALUES 
('X001', 'T001'),
('X001', 'T002'),
('X002', 'T001'),
('X003', 'T003'),
('X002', 'T003');

INSERT INTO Xe_TuyenXe
VALUES 
('X001', 'T003'),
('X001', 'T004'),
('X001', 'T005'),
('X001', 'T006'),
('X001', 'T007'),
('X001', 'T008'),
('X001', 'T009'),
('X001', 'T010'),
('X002', 'T002'),
('X002', 'T004'),
('X002', 'T005'),
('X002', 'T006'),
('X002', 'T007'),
('X002', 'T008'),
('X002', 'T009'),
('X002', 'T010'),
('X003', 'T001'),
('X003', 'T002');

INSERT INTO Xe_TuyenXe
VALUES 
('X005', 'T001'),
('X005', 'T002'),
('X005', 'T003'),
('X005', 'T004'),
('X005', 'T005'),
('X005', 'T006'),
('X005', 'T007'),
('X005', 'T008'),
('X005', 'T009'),
('X005', 'T010'),
('X003', 'T009'),
('X003', 'T007'),
('X003', 'T005'),
('X004', 'T004'),
('X004', 'T005'),
('X004', 'T006'),
('X004', 'T007'),
('X004', 'T008');

INSERT INTO Taixe
VALUES ('TX001', N'Nguyễn Văn A', '0884782979','1990-01-02', N'Nam', N'52 Hồ Thị Kỷ, P. 1, Q. 10, HCM', '123456789123', 'ngva@gmail.com'),
 ('TX002', N'Nguyễn Thị B ', '0987654321', '1995-02-02', N'Nữ', N'496 Đ. Nguyễn Thị Minh Khai, P. 2, Q. 3, Hà Nội', '123456789456','levanc@gmail.com'),
 ('TX003', N'Lê Văn C ', '0987654567', '1993-01-12', N'Nam', N'214/C15B Đ. Nguyễn Trãi, P. Nguyễn Cư Trinh, Q. 1, Đà Lạt', '123456789789', 'phavand@gmail.com'),
 ('TX004', N'Phạm Văn D ', '0987654312', '1989-12-22', N'Nữ', N'1A Đ. Tôn Thất Tùng, P. Phạm Ngũ Lão, Q. 1, TP. HCM', '123456789321', NULL),
 ('TX005', N'Phan Thị E', '0879654321', '1988-05-15', N'Nam', N'132 Đ. Bến Vân Đồn, P. 6, Q. 4, TP. HCM', '123456789543', NULL)

INSERT INTO CHUYENXE
VALUES ('C001', 'X001', 'T001','2023-01-01', '2023-01-01',	'07:00:00',	'09:30:00',	'100000', '45',	'TX001'),  
('C002', 'X001', 'T002', '2023-01-01',	'2023-01-01', '17:00:00', '20:30:00', '100000','45','TX001'),   
('C003', 'X002', 'T001', '2023-06-15',	'2023-06-16', '20:00:00', '04:30:00', '500000','35','TX002'),   
('C004', 'X002', 'T003', '2023-06-20',	'2023-06-20', '17:00:00', '20:30:00', '500000','35','TX002');

INSERT INTO CHUYENXE
VALUES('C005', 'X002', 'T003', '2024-06-20',	'2024-06-20', '17:00:00', '20:30:00', '500000','35','TX002'),
('C006', 'X002', 'T003', '2024-06-20',	'2024-06-20', '17:00:00', '20:30:00', '500000','35','TX002');

INSERT INTO KhachHang
VALUES ('Nguyễn Thị X',	'1990-01-02','Nam','52 Hồ Thị Kỷ, P.1, Q.10, HCM','123456789129','ngtx@gmail.com','123459876','kh01','123'),                
('Trần Thị Y',	'1995-02-02','Nữ',	'496 Đ. Nguyễn Thị Minh Khai, P.2, Q.3, Hà Nội',	'123456789458',	'tranty@gmail.com', '0123456987',	'kh02','456'),                 
('Chu Văn Z', 	'1993-01-12','Nam',	'214/C15B Đ. Nguyễn Trãi, P.Nguyễn Cư Trinh, Q. 1, Đà Lạt',	'123456789787',	'chuvz@gmail.com', '0321456789','kh03','678'),                 
('Do Thị R',	'1989-12-22','Nữ',	'1A Đ. Tôn Thất Tùng, P.Phạm Ngũ Lão, Q. 1, HCM',	'123456789326',	'dotr@gmail.com', '0123456999',	'kh04', '999'),        
('Vo Văn T',	'1988-05-15','Nam',	'132 Đ. Bến Vân Đồn, P.6, Q.4, HCM',	'123456789545',	'vovt@gmail.com', '0912345688',	'kh05', '888');

INSERT INTO ChucVu
VALUES ('CV001', 'Quản Lý'),
('CV002', 'Nhân Viên')

INSERT INTO NhanVien
VALUES 
('NV001',     	'Ngo Thị G',	'0999456789',	'1990-01-02',	'Nữ',	'52 Hồ Thị Kỷ, P.1, Q.10, HCM',	'723456789123',	'ngtg@gmail.com', 'admin123','ad123', 'CV001'),
('NV002',     	'Chung Van H',	'0888456789',	'1995-02-02',	'Nam',	'496 Đ. Nguyễn Thị Minh Khai, P.2, Q.3, Hà Nội',	'823456789456',	'tranty@gmail.com', 'nhanvien1', 'nv456', 'CV002'),     
('NV003',     	'Chu Văn Z', 	'0777456789',	'1993-01-12',	'Nam',	'214/C15B Đ. Nguyễn Trãi, P.Nguyễn Cư Trinh, Q.1, Đà Lạt',	'923456789789',	'chuvz@gmail.com',	'nhanvien2', 'nv678', 'CV002');     

INSERT INTO VE 
VALUES ('C001', '1', '100000', '1','2022-11-01'),
('C001', '2', '100000', '2','2022-11-28'),
('C002', '3', '100000', '1','2022-12-28'),
('C003', '4', '100000', '3','2023-02-01'),
('C004', '5', '100000', '5','2023-03-03');

CREATE FUNCTION GetTuyenChuyenInfo()
RETURNS TABLE
AS
RETURN
(
    SELECT
        T.MaTuyen,
        T.TenTuyen,
        C.MaChuyen,
		T.DiemXP,
		T.DiemDen,
		C.NgayXP,
		C.NgayDen,
        C.GioXP,
        C.GioDen,
		C.Gia,
		C.SOGHETRONG,
		TX.TenTX,
        X.TENXE,
        H.TENHANGSX
    FROM
        TuyenXe T
        INNER JOIN Xe_TuyenXe XT ON T.MaTuyen = XT.MaTuyen
		INNER JOIN Xe X ON XT.Maxe = X.Maxe
        INNER JOIN ChuyenXe C ON XT.MaTuyen = C.MaTuyen AND X.Maxe = C.Maxe
        INNER JOIN HANGSX H ON X.MAHANGSX = H.MAHANGSX
		INNER JOIN TAIXE TX ON C.MaTX = TX.MaTX
);

SELECT * FROM GetTuyenChuyenInfo();
SELECT * FROM GetTuyenChuyenInfo() WHERE TenTuyen = 'Sài Gòn - Vũng Tàu'
SELECT GIA FROM GetTuyenChuyenInfo() WHERE MATUYEN = 'T003'
--CREATE TRIGGER Calculate_ThanhTien_SoGheTrong
--ON ChuyenXe
--AFTER INSERT, UPDATE
--AS
--BEGIN
--    UPDATE Ve
--    SET ThanhTien = SOLUONG * Gia
--    FROM Ve
--    INNER JOIN inserted ON Ve.MaChuyen = inserted.MaChuyen;

--    UPDATE ChuyenXe
--    SET SOGHETRONG = SOGHETRONG - (SELECT SUM(SOLUONG) FROM inserted WHERE ChuyenXe.MaChuyen = inserted.MaChuyen)
--    FROM ChuyenXe
--    INNER JOIN inserted ON ChuyenXe.MaChuyen = inserted.MaChuyen;
--END;
-- Trigger cho phép tính toán trường "ThanhTien" và cập nhật trường "SoGheTrong"
CREATE TRIGGER Calculate_ThanhTien_SoGheTrong
ON Ve
For INSERT, UPDATE
AS
BEGIN
UPDATE Ve
SET ThanhTien = (SELECT ChuyenXe.Gia FROM ChuyenXe WHERE ChuyenXe.MaChuyen = Ve.MaChuyen) * Ve.SOLUONG
FROM Ve
INNER JOIN inserted ON Ve.MaVe = inserted.MaVe;

UPDATE ChuyenXe
SET SOGHETRONG = (SELECT SOGHE FROM LOAIXE 
                  INNER JOIN XE ON LOAIXE.MALOAIXE = XE.MALOAIXE
                  WHERE XE.Maxe = (SELECT MaXe FROM ChuyenXe WHERE ChuyenXe.MaChuyen = (SELECT MaChuyen FROM inserted)))
WHERE MaChuyen IN (SELECT MaChuyen FROM inserted);
END;


-- Trigger để kiểm tra số ghế trống trước khi đặt vé
CREATE TRIGGER Check_SoGheTrong
ON Ve
FOR INSERT
AS
BEGIN
    -- Kiểm tra số ghế trống của chuyến xe
    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN ChuyenXe cx ON i.MaChuyen = cx.MaChuyen
        WHERE cx.SoGheTrong = 0
    )
    BEGIN
        -- Nếu số ghế trống bằng 0, hủy thêm vé và hiển thị thông báo lỗi
        ROLLBACK TRANSACTION;
        RAISERROR('Không thể đặt vé. Số ghế trống đã hết.', 16, 1);
    END;
END;

CREATE PROCEDURE UpdateNhanVien
(
    @MaNV CHAR(10),
    @TenNV NVARCHAR(50),
    @SDT CHAR(10),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(3),
    @DiaChi NVARCHAR(70),
    @CCCD CHAR(12),
    @Email CHAR(20),
    @TaiKhoan CHAR(20),
    @MatKhau CHAR(20),
    @MaChucVu CHAR(10)
)
AS
BEGIN
    UPDATE NhanVien
    SET
        TenNV = @TenNV,
        SDT = @SDT,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        DiaChi = @DiaChi,
        CCCD = @CCCD,
        Email = @Email,
        TaiKhoan = @TaiKhoan,
        MatKhau = @MatKhau,
        MaChucVu = @MaChucVu
    WHERE
        MaNV = @MaNV
END


CREATE PROCEDURE UpdateNhanVien1
    @MaNV CHAR(10),
    @TenNV NVARCHAR(50),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(3),
    @DiaChi NVARCHAR(70),
    @CCCD CHAR(12),
    @Email CHAR(20),
    @SDT CHAR(10),
    @TaiKhoan CHAR(20),
    @MatKhau CHAR(20)
AS
BEGIN
    UPDATE NHANVIEN
    SET TenNV = @TenNV,
        NGAYSINH = @NgaySinh,
        GIOITINH = @GioiTinh,
        DiaChi = @DiaChi,
        CCCD = @CCCD,
        Email = @Email,
        SDT = @SDT,
        TAIKHOAN = @TaiKhoan,
        MATKHAU = @MatKhau
    WHERE MANV = @MaNV;
END

CREATE FUNCTION GetVeInformation()
RETURNS TABLE
AS
RETURN
(
    SELECT v.MaVe, v.MaChuyen, v.MaKh, v.ThanhTien, v.SOLUONG, v.NGAYDATVE, c.MaTuyen, c.Maxe, c.NgayXP, c.NgayDen, c.GioXP, c.GioDen, c.Gia, t.TenTuyen, t.DiemDen, t.DiemXP, k.TenKH, x.BIENSOXE, h.TENHANGSX
    FROM Ve AS v
	JOIN ChuyenXe AS c ON v.MaChuyen = c.MaChuyen
	JOIN Xe_TuyenXe AS xt ON c.MaTuyen = xt.MaTuyen AND c.Maxe = xt.Maxe
    JOIN TuyenXe AS t ON xt.MaTuyen = t.MaTuyen
	JOIN Xe AS x ON xt.Maxe = x.MaXe
	JOIN HANGSX AS h ON x.MAHANGSX = h.MAHANGSX
    JOIN KhachHang AS k ON v.MaKh = k.MaKh
);

SELECT *
FROM GetVeInformation()
WHERE MAKH = 1;

CREATE PROCEDURE UpdateNhanVien
(
    @MaNV CHAR(10),
    @TenNV NVARCHAR(50),
    @SDT CHAR(10),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(3),
    @DiaChi NVARCHAR(70),
    @CCCD CHAR(12),
    @Email CHAR(20),
    @TaiKhoan CHAR(20),
    @MatKhau CHAR(20),
    @MaChucVu CHAR(10)
)
AS
BEGIN
    UPDATE NhanVien
    SET
        TenNV = @TenNV,
        SDT = @SDT,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        DiaChi = @DiaChi,
        CCCD = @CCCD,
        Email = @Email,
        TaiKhoan = @TaiKhoan,
        MatKhau = @MatKhau,
        MaChucVu = @MaChucVu
    WHERE
        MaNV = @MaNV
END

EXEC UpdateNhanVien
    @MaNV = 'NV001',
    @TenNV = N'Nguyễn Văn A',
    @SDT = '0987654321',
    @NgaySinh = '1990-01-01',
    @GioiTinh = N'Nam',
    @DiaChi = N'123 Đường ABC, Quận XYZ, TP. HCM',
    @CCCD = '123456789012',
    @Email = 'abc@example.com',
    @TaiKhoan = 'abc123',
    @MatKhau = '123456',
    @MaChucVu = 'CV001'

CREATE PROCEDURE UpdateKhachHang
    @MaKhachHang CHAR(10),
    @TenKH NVARCHAR(50),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(3),
    @DiaChi NVARCHAR(70),
    @CCCD CHAR(12),
    @Email CHAR(20),
    @SDT CHAR(10),
    @TaiKhoan CHAR(20),
    @MatKhau CHAR(20)
AS
BEGIN
    UPDATE KHACHHANG
    SET TenKH = @TenKH,
        NGAYSINH = @NgaySinh,
        GIOITINH = @GioiTinh,
        DiaChi = @DiaChi,
        CCCD = @CCCD,
        Email = @Email,
        SDT = @SDT,
        TAIKHOAN = @TaiKhoan,
        MATKHAU = @MatKhau
    WHERE MAKH = @MaKhachHang;
END

CREATE PROCEDURE InsertVe
(
    @MaChuyen CHAR(4),
    @MaKH INT,
    @ThanhTien FLOAT,
    @SoLuong INT,
    @NgayDatVe DATE
)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Ve WHERE MaChuyen = @MaChuyen AND MaKH = @MaKH)
    BEGIN
        UPDATE Ve
        SET SoLuong = SoLuong + @SoLuong,
            ThanhTien = (SELECT Gia FROM ChuyenXe WHERE MaChuyen = @MaChuyen) * (SoLuong + @SoLuong)
        WHERE MaChuyen = @MaChuyen AND MaKH = @MaKH;
    END
    ELSE
    BEGIN
        INSERT INTO Ve (MaChuyen, MaKH, ThanhTien, SoLuong, NgayDatVe)
        VALUES (@MaChuyen, @MaKH, @ThanhTien, @SoLuong, @NgayDatVe);
    END
END;

CREATE PROCEDURE HuyVe
    @MaVe INT
AS
BEGIN
    -- Kiểm tra xem vé có tồn tại hay không
    IF EXISTS (SELECT 1 FROM Ve WHERE MaVe = @MaVe)
    BEGIN
        -- Xóa vé từ bảng Ve
        DELETE FROM Ve WHERE MaVe = @MaVe;
        PRINT 'Hủy vé thành công.';
    END
    ELSE
    BEGIN
        PRINT 'Vé không tồn tại.';
    END
END

CREATE PROCEDURE CapNhatVe
	@MaVe INT,
	@MaChuyen CHAR(4),
	@MaKh INT,
	@ThanhTien FLOAT,
	@SoLuong INT,
	@NgayDatVe DATE
AS
BEGIN
	UPDATE Ve
	SET MaChuyen = @MaChuyen,
		MaKh = @MaKh,
		SoLuong = @SoLuong,
		NgayDatVe = @NgayDatVe
	WHERE MaVe = @MaVe AND ThanhTien = @ThanhTien;
END

CREATE TRIGGER CheckDate
ON Ve
FOR INSERT
AS
BEGIN
    DECLARE @NgayXP DATE;
    DECLARE @NgayDatVe DATE;
    DECLARE @MaChuyen CHAR(4);

    SELECT @MaChuyen = MaChuyen, @NgayDatVe = NGAYDATVE FROM inserted;

    SELECT @NgayXP = NgayXP FROM ChuyenXe WHERE MaChuyen = @MaChuyen;

    IF @NgayDatVe >= @NgayXP 
    BEGIN
        RAISERROR ('Error: Booking date must be earlier than departure date.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

--CREATE TRIGGER trg_UpdateSoGheTrong
--ON Ve
--FOR INSERT, UPDATE, DELETE
--AS
--BEGIN
--    IF EXISTS (SELECT * FROM inserted)
--    BEGIN
--        -- Cập nhật trường SOGHETRONG cho các chuyến xe bị ảnh hưởng bởi việc thêm/sửa/xóa vé
--        UPDATE ChuyenXe
--        SET SOGHETRONG = LOAIXE.SOGHE - ISNULL((SELECT SUM(SOLUONG) FROM Ve WHERE MaChuyen = ChuyenXe.MaChuyen), 0)
--        FROM ChuyenXe
--		INNER JOIN TuyenXe ON ChuyenXe.MaTuyen = TuyenXe.MaTuyen
--		INNER JOIN Xe ON Xe.MaXe = TuyenXe.Maxe
--		INNER JOIN LOAIXE ON XE.MALOAIXE = LOAIXE.MALOAIXE
--        WHERE ChuyenXe.MaChuyen IN (SELECT DISTINCT MaChuyen FROM inserted)
--    END
--    ELSE IF EXISTS (SELECT * FROM deleted)
--    BEGIN
--        -- Cập nhật trường SOGHETRONG cho các chuyến xe bị ảnh hưởng bởi việc xóa vé
--        UPDATE ChuyenXe
--        SET SOGHETRONG = LOAIXE.SOGHE - ISNULL((SELECT SUM(SOLUONG) FROM Ve WHERE MaChuyen = ChuyenXe.MaChuyen), 0)
--        FROM ChuyenXe
--		INNER JOIN TuyenXe ON ChuyenXe.MaTuyen = TuyenXe.MaTuyen
--		INNER JOIN Xe ON Xe.MaXe = TuyenXe.Maxe
--		INNER JOIN LOAIXE ON XE.MALOAIXE = LOAIXE.MALOAIXE
--        WHERE ChuyenXe.MaChuyen IN (SELECT DISTINCT MaChuyen FROM deleted)
--    END
--END

CREATE FUNCTION dbo.GetNhanVienByChucVu
(
    @MACHUCVU CHAR(10)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM NHANVIEN
    WHERE MACHUCVU = @MACHUCVU
);

SELECT *
FROM dbo.GetNhanVienByChucVu('CV001');

CREATE PROCEDURE InsertNhanVien
(
    @MaNV char(10),
    @TenNV nvarchar(50),
    @SDT char(10),
    @NgaySinh date,
    @GioiTinh nvarchar(3),
    @DiaChi nvarchar(70),
    @CCCD char(12),
    @Email char(20),
    @TaiKhoan char(20),
    @MatKhau char(20),
    @MaChucVu char(10)
)
AS
BEGIN
    INSERT INTO NhanVien (MaNV, TenNV, SDT, NgaySinh, GioiTinh, DiaChi, CCCD, Email, TaiKhoan, MatKhau, MaChucVu)
    VALUES (@MaNV, @TenNV, @SDT, @NgaySinh, @GioiTinh, @DiaChi, @CCCD, @Email, @TaiKhoan, @MatKhau, @MaChucVu)
END

CREATE PROCEDURE DeleteNhanVien
    @MaNV CHAR(10)
AS
BEGIN
    DELETE FROM NhanVien
    WHERE MaNV = @MaNV;
END;

CREATE PROCEDURE insertKhachHang
    @TenKH NVARCHAR(50),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(3),
    @DiaChi NVARCHAR(70),
    @CCCD CHAR(12),
    @Email CHAR(20),
    @SDT CHAR(10),
    @TaiKhoan CHAR(20),
    @MatKhau CHAR(20)
AS
BEGIN
    INSERT INTO KhachHang (TenKH, NGAYSINH, GIOITINH, DIACHI, CCCD, EMAIL, SDT, TAIKHOAN, MATKHAU)
    VALUES (@TenKH, @NgaySinh, @GioiTinh, @DiaChi, @CCCD, @Email, @SDT, @TaiKhoan, @MatKhau)
END

CREATE PROCEDURE deleteKhachHang
    @MaKh INT
AS
BEGIN
    DELETE FROM Ve WHERE MaKh = @MaKh;
    DELETE FROM KhachHang WHERE MaKh = @MaKh;
END

CREATE PROCEDURE InsertChuyen
(
    @MaChuyen char(4),
    @MaTuyen char(5),
	@MaXe char(10),
    @NgayXP date,
    @NgayDen date,
    @GioXP time,
    @GioDen time,
    @Gia float,
    @SoGheTrong int,
    @MaTX char(10)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Taixe WHERE MaTX = @MaTX)
    BEGIN
        RAISERROR('MaTX không tồn tại trong bảng Taixe.', 16, 1)
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM TuyenXe WHERE MaTuyen = @MaTuyen)
    BEGIN
        RAISERROR('MaTuyen không tồn tại trong bảng TuyenXe.', 16, 1)
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM Xe WHERE Maxe = @MaXe)
    BEGIN
        RAISERROR('MaXe không tồn tại trong bảng Xe.', 16, 1)
        RETURN;
    END

    INSERT INTO ChuyenXe (MaChuyen, MaXe, MaTuyen, NgayXP, NgayDen, GioXP, GioDen, Gia, SoGheTrong, MaTX)
    VALUES (@MaChuyen, @MaXe, @MaTuyen, @NgayXP, @NgayDen, @GioXP, @GioDen, @Gia, @SoGheTrong, @MaTX)

    IF @@ERROR <> 0
    BEGIN
        RAISERROR('Lỗi khi chèn dữ liệu vào bảng ChuyenXe.', 16, 1)
        RETURN;
    END

    PRINT 'Chèn thành công dữ liệu vào bảng ChuyenXe.'
END

CREATE PROCEDURE updateChuyen
    @MaChuyen char(4),
    @MaTuyen char(5),
	@MaXe char(10),
    @NgayXP date,
    @NgayDen date,
    @GioXP time,
    @GioDen time,
    @Gia float,
    @SoGheTrong int,
    @MaTX char(10)
AS
BEGIN
    UPDATE ChuyenXe
    SET MaXe = @MaXe,
		MaTuyen = @MaTuyen,
        NgayXP = @NgayXP,
        NgayDen = @NgayDen,
        GioXP = @GioXP,
        GioDen = @GioDen,
        Gia = @Gia,
        SOGHETRONG = @SoGheTrong,
        MaTX = @MaTX
    WHERE MaChuyen = @MaChuyen;
END
EXEC updateChuyen (,,)

CREATE PROCEDURE deleteChuyen
    @MaChuyen char(4)
AS
BEGIN
    DELETE FROM ChuyenXe
    WHERE MaChuyen = @MaChuyen;
END

CREATE PROCEDURE findChuyen
(
    @MaChuyen CHAR(5)
)
AS
BEGIN
    SELECT *
    FROM ChuyenXe
    WHERE MaChuyen = @MaChuyen;
END;

CREATE FUNCTION GetSoGheByMaTuyen(@MaTuyen CHAR(5))
RETURNS INT
AS
BEGIN
  DECLARE @SoGhe INT;

  SELECT @SoGhe = L.SOGHE
  FROM TuyenXe AS T
  INNER JOIN Xe_TuyenXe AS XT ON T.MaTuyen = XT.MaTuyen
  INNER JOIN Xe AS X ON XT.Maxe = X.Maxe
  INNER JOIN LoaiXe AS L ON X.MALOAIXE = L.MALOAIXE 
  WHERE T.MaTuyen = @MaTuyen;

  RETURN @SoGhe;
END;

SELECT dbo.GetSoGheByMaTuyen('T001')

CREATE PROCEDURE insertTuyenXe
(
    @MaTuyen char(5),
    @TenTuyen nvarchar(50),
    @DiemXP nvarchar(50),
    @DiemDen nvarchar(50)
)
AS
BEGIN

    INSERT INTO TuyenXe (MaTuyen, TenTuyen, DiemXP, DiemDen)
    VALUES (@MaTuyen, @TenTuyen, @DiemXP, @DiemDen);
END

CREATE PROCEDURE updateTuyenXe
(
    @MaTuyen char(5),
    @TenTuyen nvarchar(50),
    @DiemXP nvarchar(50),
    @DiemDen nvarchar(50)
)
AS
BEGIN
    UPDATE TuyenXe
    SET
        TenTuyen = @TenTuyen,
        DiemXP = @DiemXP,
        DiemDen = @DiemDen
    WHERE
        MaTuyen = @MaTuyen
END

CREATE PROCEDURE deleteTuyenXe
(
    @MaTuyen char(5)
)
AS
BEGIN
    DELETE FROM TuyenXe
    WHERE MaTuyen = @MaTuyen
END

CREATE PROCEDURE findTuyen
(
    @MaTuyen CHAR(5)
)
AS
BEGIN

    SELECT *
    FROM TuyenXe
    WHERE MaTuyen = @MaTuyen;
END;

CREATE PROCEDURE insertXe
(
    @Maxe CHAR(10),
    @TENXE CHAR(25),
    @BIENSOXE CHAR(10),
    @MALOAIXE CHAR(10),
    @MAHANGSX CHAR(10)
)
AS
BEGIN
    INSERT INTO Xe (Maxe, TENXE, BIENSOXE, MALOAIXE, MAHANGSX)
    VALUES (@Maxe, @TENXE, @BIENSOXE, @MALOAIXE, @MAHANGSX);
END;

CREATE PROCEDURE updateXe
(
    @Maxe CHAR(10),
    @TENXE CHAR(25),
    @BIENSOXE CHAR(10),
    @MALOAIXE CHAR(10),
    @MAHANGSX CHAR(10)
)
AS
BEGIN
    UPDATE Xe
    SET TENXE = @TENXE,
        BIENSOXE = @BIENSOXE,
        MALOAIXE = @MALOAIXE,
        MAHANGSX = @MAHANGSX
    WHERE Maxe = @Maxe;
END;

CREATE PROCEDURE deleteXe
(
    @Maxe CHAR(10)
)
AS
BEGIN
    DELETE FROM Xe
    WHERE Maxe = @Maxe;
END;

CREATE PROCEDURE findXe
(
    @MaXe CHAR(10)
)
AS
BEGIN
    SELECT *
    FROM Xe
    WHERE MaXe = @MaXe;
END;

CREATE PROCEDURE insertTaiXe
    @MaTX CHAR(10),
    @TenTX NVARCHAR(50),
    @SDT CHAR(10),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(3),
    @DiaChi NVARCHAR(70),
    @CCCD CHAR(12),
    @Email CHAR(20)
AS
BEGIN
    INSERT INTO Taixe (MaTX, TenTX, SDT, NgaySinh, GioiTinh, DiaChi, CCCD, Email)
    VALUES (@MaTX, @TenTX, @SDT, @NgaySinh, @GioiTinh, @DiaChi, @CCCD, @Email)
END

CREATE PROCEDURE updateTaiXe
    @MaTX CHAR(10),
    @TenTX NVARCHAR(50),
    @SDT CHAR(10),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(3),
    @DiaChi NVARCHAR(70),
    @CCCD CHAR(12),
    @Email CHAR(20)
AS
BEGIN
    UPDATE Taixe
    SET TenTX = @TenTX,
        SDT = @SDT,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        DiaChi = @DiaChi,
        CCCD = @CCCD,
        Email = @Email
    WHERE MaTX = @MaTX
END


CREATE PROCEDURE deleteTaiXe
    @MaTX CHAR(10)
AS
BEGIN
    DELETE FROM Taixe
    WHERE MaTX = @MaTX
END

CREATE PROCEDURE findTaiXe
    @MaTX CHAR(10)
AS
BEGIN
    SELECT *
    FROM Taixe
    WHERE MaTX = @MaTX
END

CREATE PROCEDURE insertLoaiXe
    @MALOAIXE CHAR(10),
    @TENLOAIXE NVARCHAR(10),
    @SOGHE INT
AS
BEGIN
    INSERT INTO LOAIXE (MALOAIXE, TENLOAIXE, SOGHE)
    VALUES (@MALOAIXE, @TENLOAIXE, @SOGHE)
END

CREATE PROCEDURE updateLoaiXe
    @MALOAIXE CHAR(10),
    @TENLOAIXE NVARCHAR(10),
    @SOGHE INT
AS
BEGIN
    UPDATE LOAIXE
    SET TENLOAIXE = @TENLOAIXE, SOGHE = @SOGHE
    WHERE MALOAIXE = @MALOAIXE
END

CREATE PROCEDURE deleteLoaiXe
    @MALOAIXE CHAR(10)
AS
BEGIN
    DELETE FROM LOAIXE
    WHERE MALOAIXE = @MALOAIXE
END

CREATE PROCEDURE findLoaiXe
    @MALOAIXE CHAR(10)
AS
BEGIN
    SELECT *
    FROM LOAIXE
    WHERE MALOAIXE = @MALOAIXE
END

CREATE PROCEDURE insertHangSX
    @MAHANGSX char(10),
    @TENHANGSX char(20)
AS
BEGIN
    INSERT INTO HANGSX (MAHANGSX, TENHANGSX)
    VALUES (@MAHANGSX, @TENHANGSX)
END

CREATE PROCEDURE updateHangSX
    @MAHANGSX char(10),
    @TENHANGSX char(20)
AS
BEGIN
    UPDATE HANGSX
    SET TENHANGSX = @TENHANGSX
    WHERE MAHANGSX = @MAHANGSX
END

CREATE PROCEDURE deleteHangSX
    @MAHANGSX char(10)
AS
BEGIN
    DELETE FROM HANGSX
    WHERE MAHANGSX = @MAHANGSX
END

CREATE PROCEDURE findHangSX
    @MAHANGSX char(10)
AS
BEGIN
    SELECT *
    FROM HANGSX
    WHERE MAHANGSX = @MAHANGSX
END

CREATE PROCEDURE insertChucVu
    @MAChucVu char(10),
    @TENChucVu nvarchar(20)
AS
BEGIN
    INSERT INTO CHUCVU (MAChucVu, TENChucVu)
    VALUES (@MAChucVu, @TENChucVu)
END

CREATE PROCEDURE updateChucVu
    @MAChucVu char(10),
    @TENChucVu nvarchar(20)
AS
BEGIN
    UPDATE CHUCVU
    SET TENChucVu = @TENChucVu
    WHERE MAChucVu = @MAChucVu
END

CREATE PROCEDURE deleteChucVu
    @MAChucVu char(10)
AS
BEGIN
    DELETE FROM CHUCVU
    WHERE MAChucVu = @MAChucVu
END

CREATE PROCEDURE findChucVu
    @MAChucVu char(10)
AS
BEGIN
    SELECT *
    FROM CHUCVU
    WHERE MAChucVu = @MAChucVu
END



CREATE FUNCTION GetSoGheByMaXe (@MaXe CHAR(10))
RETURNS INT
AS
BEGIN
    DECLARE @SoGhe INT;

    SELECT @SoGhe = SOGHE
    FROM LOAIXE
    WHERE MALOAIXE = (
        SELECT MALOAIXE
        FROM XE
        WHERE Maxe = @MaXe
    );

    RETURN @SoGhe;
END;

SELECT dbo.GetSoGheByMaXe('X001')

CREATE TRIGGER trg_Insert_Xe_TuyenXee
ON ChuyenXe
FOR INSERT
AS
BEGIN
    -- Kiểm tra các bản ghi được chèn vào bảng ChuyenXe
    -- Lấy các giá trị Maxe và MaTuyen
    DECLARE @Maxe CHAR(10), @MaTuyen CHAR(5);
    SELECT @Maxe = Maxe, @MaTuyen = MaTuyen
    FROM inserted;

    -- Kiểm tra xem khóa PK_Xe_TuyenXe đã tồn tại hay chưa
    IF NOT EXISTS (
        SELECT *
        FROM Xe_TuyenXe
        WHERE Maxe = @Maxe AND MaTuyen = @MaTuyen
    )
    BEGIN
        -- Nếu khóa PK_Xe_TuyenXe chưa tồn tại, thêm bản ghi mới vào bảng Xe_TuyenXe
        INSERT INTO Xe_TuyenXe (Maxe, MaTuyen)
        VALUES (@Maxe, @MaTuyen);
    END
END;

INSERT INTO CHUYENXE
VALUES ('C008', 'X005', 'T007','2023-01-01', '2023-01-01',	'07:00:00',	'09:30:00',	'100000', '45',	'TX001') 

CREATE FUNCTION findKhachHang(@MaKh INT)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM KhachHang
    WHERE MaKh = @MaKh
)
SELECT *
FROM dbo.findKhachHang(1)


CREATE PROCEDURE JoinVeKhachHang
AS
BEGIN
    SELECT Ve.MaVe, Ve.MaChuyen, Ve.MaKh, Ve.ThanhTien, Ve.SOLUONG, Ve.NGAYDATVE,
           KhachHang.TenKH, KhachHang.NGAYSINH, KhachHang.GIOITINH, KhachHang.DIACHI,
           KhachHang.CCCD, KhachHang.EMAIL, KhachHang.SDT, KhachHang.TAIKHOAN, KhachHang.MATKHAU
    FROM Ve
    INNER JOIN KhachHang ON Ve.MaKh = KhachHang.MaKh;
END;