using Microsoft.EntityFrameworkCore;

namespace BudgetManager.Models
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
