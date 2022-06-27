using Microsoft.EntityFrameworkCore;

namespace MyOrm
{
    public class MyOrmContext : DbContext
    {
        public DbSet<BankAccount> BankAccount { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<NaturalPerson> NaturalPerson { get; set; }
        public DbSet<Organization> Organization { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=172.16.248.18;Initial Catalog=Backend_JhonyCalle;user id=jhony;password=catupiribas;Trusted_Connection=False");
        }
    }
}
