using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class DBContextx : DbContext
    {
        public DBContextx(DbContextOptions<DBContextx> options) : base(options)
        {

        }
        public DbSet<PhieuXuat> PhieuXuats { get; set; }
    }
}
