using ColaComNois.Context.DB;
using System.Data.Entity;

namespace ColaComNois.Context
{
    public class ColaComNoisContext : DbContext
    {
        public ColaComNoisContext()
            : base("ColaComNoisFutsalEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<CCN_Jogadores> Jogadores { get; set; }
        public virtual DbSet<CCN_Despesas> Despesas { get; set; }
        public virtual DbSet<CCN_Rateios> Rateios { get; set; }
        public virtual DbSet<CCN_Adversario> Adversarios { get; set; }
        public virtual DbSet<CCN_Logins> Logins { get; set; }
        public virtual DbSet<CCN_Jogos> Jogos { get; set; }

    }
}