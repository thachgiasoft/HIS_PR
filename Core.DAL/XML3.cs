using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    [DataContract]
    public class XML3
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string MaLk { get; set; }
        [DataMember]
        public string Stt { get; set; }
        [DataMember]
        public string MaDichVu { get; set; }
        [DataMember]
        public string MaVatTu { get; set; }
        [DataMember]
        public string MaNhom { get; set; }
        [DataMember]
        public string TenDichVu { get; set; }
        [DataMember]
        public string DonViTinh { get; set; }
        [DataMember]
        public string SoLuong { get; set; }
        [DataMember]
        public string DonGia { get; set; }
        [DataMember]
        public string TyleTt { get; set; }
        [DataMember]
        public string ThanhTien { get; set; }
        [DataMember]
        public string MaKhoa { get; set; }
        [DataMember]
        public string MaBacSi { get; set; }
        [DataMember]
        public string MaBenh { get; set; }
        [DataMember]
        public string NgayYl { get; set; }
        [DataMember]
        public string NgayKq { get; set; }
        [DataMember]
        public string MaPttt { get; set; }
        [DataMember]
        public string CosokcbId { get; set; }
        [DataMember]
        public string TinhthanhId { get; set; }
        [DataMember]
        public string Trangthai { get; set; }
        [DataMember]
        public string HosoId { get; set; }
        [DataMember]
        public string Mieuta { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string TNguonkhac { get; set; }
        [DataMember]
        public string Xml19324Id { get; set; }
        [DataMember]
        public string KygiamdinhId { get; set; }
        [DataMember]
        public string NguoigiamdinhId { get; set; }
        [DataMember]
        public string MaGiaDv { get; set; }
        [DataMember]
        public string KyQT { get; set; }
        [DataMember]
        public string MaCskcb { get; set; }
    }
}
