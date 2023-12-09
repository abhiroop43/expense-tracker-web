using ExpenseTracker.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Category> Categories { get; set; }
  }
}