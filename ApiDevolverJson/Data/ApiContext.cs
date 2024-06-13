using Microsoft.EntityFrameworkCore;

namespace ApiDevolverJson.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) 
            :base(options)
        { 
        }
        public DbSet<ApiDevolverJson.Models.Dinero> Dinero { get; set; } = default!;
    }
}
