using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Library
    {
        public const string DANGNHAP = "Đăng nhập hệ thống.";
        public const string DANGXUAT = "Đăng xuất hệ thống.";
        // Lỗi thẻ BHYT
        public const string KyTuTheBHYT = "Mã thẻ bắt buộc 15 ký tự!";
        public const string HaiKyTuDau = "Hai ký tự đầu mã thẻ không hợp lệ!";
        public const string BaKyTuDau = "Ba ký tự đầu mã thẻ không hợp lệ!";
        public const string HaiKyTuTinh = "Hai ký mã tỉnh không hợp lệ!";
        public const string KhongPhaiBNBHYT = "Bệnh nhân không có thẻ BHYT!";
        public const string KetNoiCong = "Không thể kết nối tới cổng bảo hiểm!";
        public const string KetNoiInternet = "Không có kết nối internet!";
        public const string GanThongTinThe = "Có lỗi trong quá trình lấy gán thông tin thẻ";
        // Lỗi Thông tin thẻ
        public const string NhapHoTen = "Chưa nhập họ tên bệnh nhân.";
        public const string NhapMaThe = "Chưa nhập mã thẻ BHYT.";
        public const string NhapNgaySinh = "Chưa nhập ngày sinh bệnh nhân.";
        public const string NhapDiaChi = "Chưa nhập địa chỉ bệnh nhân.";
        public const string NhapTheTu = "Chưa nhập giá trị thẻ từ.";
        public const string NhapTheDen = "Chưa nhập giá trị thẻ đến.";
        public const string NhapKCBBD = "Chưa nhập nơi đăng ký KCB ban đầu.";
        public const string TheTuLonHonTheDen = "Giá trị thẻ từ (ngày) lớn hơn giá trị thẻ đến (ngày).";
        public const string TheTuLonHonHienTai = "Giá trị thẻ từ (ngày) lớn hơn ngày hiện tại (Thẻ chưa đến hạn, vui lòng kiểm tra lại).";
        // Lấy thông tin bệnh nhân
        public const string BenhNhanDaTiepNhan = "Bệnh nhân này đã tiếp nhận hôm nay.";
        public const string MaBNKhongTonTai = "Mã bệnh nhân không tồn tại.";
        public const string BenhNhanDaKhamRaVien = "Bệnh nhân đã khám hoặc đã ra viện.";
        public const string ChuyenBenhNhan = "Chuyển bệnh nhân sang phòng: ";
        public const string ChuyenTuyenBenhNhan = "Chuyển tuyến bệnh nhân này?";
        // lưu thông tin
        public const string LuuThanhCong = "Đã lưu thông tin thành công.";
        // câu  lệnh sql
        public const string SqlChoKham = "MaBenh is null And NgayRa is null And TinhTrangRaVien is null";
        public const string SqlDaKham = "MaBenh is not null And NgayRa is null";
        public const string SqlChuyenTuyen = "TinhTrangRaVien = 2";
        public const string SqlNhapVien = "MaLoaiKCB = 3";
        public const string SqlRaVien = "MaBenh is not null And NgayRa is not null";
    }
}
