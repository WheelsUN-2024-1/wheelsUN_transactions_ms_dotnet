using Microsoft.EntityFrameworkCore;


namespace wheelsUN_transaction_ms.wheelsUN_transaction_db.Data
{
    public class wheelsUN_transaction_context : DbContext
    {
        public wheelsUN_transaction_context(DbContextOptions<wheelsUN_transaction_context> options)
            : base(options)
        {
        }
        public DbSet<TransactionD> Transactions { get; set; }
        public DbSet<CreditCardD> CreditCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
