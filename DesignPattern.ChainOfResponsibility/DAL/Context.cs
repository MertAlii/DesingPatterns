using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL;

public class Context: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=MERTALII\\SQLEXPRESS;Database=DesingPattern;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    }
    public DbSet<CustomerProcess> CustomerProcesses { get; set; }
}
