using Microsoft.EntityFrameworkCore;
using TranNhua.Models;
// Ensure you have installed the required NuGet package for Entity Framework Core.  
// Run the following command in the NuGet Package Manager Console:  
// Install-Package Microsoft.EntityFrameworkCore  

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<TranNhuaDep> TranNhua { get; set; }
    public DbSet<OpTuong> OpTuong { get; set; }
    public DbSet<VachNgan> VachNgan { get; set; }
    public DbSet<TranTha> TranTha { get; set; }
}
