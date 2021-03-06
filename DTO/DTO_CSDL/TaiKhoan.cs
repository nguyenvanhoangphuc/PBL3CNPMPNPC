using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTroLinQ.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan()
        {
            this.NguoiDung = new HashSet<NguoiDung>();
        }
        [Key]
        [StringLength(9)]
        [Required]
        public string ID { get; set; }
        public string TenTK { get; set; }
        public string MKhau { get; set; }
        public string Email { get; set; }
        public virtual ICollection<NguoiDung> NguoiDung { get; set; }
    }
}
