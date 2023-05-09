using Microsoft.EntityFrameworkCore;

namespace ESite.Model
{
    public class DBConTextProd : DbContext
    {
        public DBConTextProd(DbContextOptions<DBConTextProd> options): base(options)
        {

        }

        public DbSet<EsiteHome> esiteHomes { get; set; }
    }
}
