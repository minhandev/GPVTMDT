using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
