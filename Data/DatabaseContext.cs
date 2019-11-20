using Microsoft.EntityFrameworkCore;
using RedirectApp.Models;

namespace RedirectApp.Data
{
  public class DatabaseContext : DbContext
  {
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    public DbSet<CounterRecord> CounterRecords { get; set; }
  }
}