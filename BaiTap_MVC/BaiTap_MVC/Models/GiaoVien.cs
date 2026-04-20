namespace BaiTap_MVC.Models
{
    public class GiaoVien
    {
        public int Id { get; set; }

        public string HoTen { get; set; } = "";

        public List<LopHocPhan> LopHocPhans { get; set; } = new();
    }
}
