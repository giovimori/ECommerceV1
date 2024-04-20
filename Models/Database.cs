using Microsoft.EntityFrameworkCore;
using morelli.giovanni._5h.Ecommerce.Models;

public class dbContext : DbContext
{
    private readonly DbContextOptions? _options;
    public dbContext() { }

    protected override void
            OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database.db");

    public DbSet<Utente> Prenotazioni { get; set; }
}