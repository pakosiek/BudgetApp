using Microsoft.EntityFrameworkCore;
namespace BudgetApp.Model
{
    public class AppDbContext:DbContext
    {
        private readonly string _connectionParameters = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\programowanie\\cv\\BudgetApp\\BudgetApp.Model\\BudgetApp.mdf;Integrated Security=True";
        public DbSet <Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder oB)
        {
            oB.UseSqlServer(_connectionParameters);
        }
    }
}
