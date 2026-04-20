using Microsoft.EntityFrameworkCore;

namespace BaiTap_MVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<GiaoVien> GiaoViens { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<LopHocPhan> LopHocPhans { get; set; }
        public DbSet<DangKyHoc> DangKyHocs { get; set; }
    }
}
