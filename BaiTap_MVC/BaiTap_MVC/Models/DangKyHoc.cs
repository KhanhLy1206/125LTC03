namespace BaiTap_MVC.Models
{
    public class DangKyHoc
    {
        public int Id { get; set; }

        public int SinhVienId { get; set; }
        public SinhVien? SinhVien { get; set; }

        public int LopHocPhanId { get; set; }
        public LopHocPhan? LopHocPhan { get; set; }
    }
}
