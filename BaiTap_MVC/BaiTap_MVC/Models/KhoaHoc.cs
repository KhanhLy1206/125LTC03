namespace BaiTap_MVC.Models
{
    public class KhoaHoc
    {
        public int Id { get; set; }

        public string TenKhoaHoc { get; set; } = "";

        public List<LopHocPhan> LopHocPhans { get; set; } = new();
    }
}
