using Microsoft.EntityFrameworkCore;

namespace MyWebApiApp.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        #region DbSet
        public DbSet<HangHoa> HangHoas { get; set; }    
        #endregion  
    }
}
