using Microsoft.EntityFrameworkCore;

namespace WebAPI;

public class BaseContext:DbContext
{
    public DbSet<Book> Books {get;set;}

    public BaseContext()
    {
    
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlite("Data Source=test.db");

        base.OnConfiguring(optionsBuilder);
    }
}