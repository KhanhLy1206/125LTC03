namespace BaiTap_MVC.Models
{
    public class LopHocPhan
    {
        public int Id { get; set; }

        public string TenLopHocPhan { get; set; } = "";

        public int KhoaHocId { get; set; }
        public KhoaHoc? KhoaHoc { get; set; }

        public int GiaoVienId { get; set; }
        public GiaoVien? GiaoVien { get; set; }

        public List<DangKyHoc> DangKyHocs { get; set; } = new();;
    }
}
