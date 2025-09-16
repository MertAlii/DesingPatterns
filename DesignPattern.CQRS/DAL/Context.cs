using DesignPattern.CQRS.DAL;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=MERTALII\\SQLEXPRESS;Database=DesingPattern2;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    }
    public DbSet<Product> Products { get; set; }
}