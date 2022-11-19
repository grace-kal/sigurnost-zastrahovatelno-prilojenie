using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Sigurnost_Models;

namespace Sigurnost_DataAccess
{
    public class SigurnostDbContext : IdentityDbContext
    {
        public SigurnostDbContext(DbContextOptions<SigurnostDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<InsuranceContract> InsuranceContracts { get; set; }
        public DbSet<InsuranceLevel> InsuranceLevels { get; set; }
        public DbSet<CarInsuranceInfo> CarInsuranceInfos { get; set; }
        public DbSet<HomeInsuranceInfo> HomeInsuranceInfos { get; set; }
        public DbSet<InsuranceType> InsuranceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<InsuranceContract>()
                .HasOne(e => e.Agent)
                .WithMany(a => a.SoldInsuranceContracts)
                .HasForeignKey(e => e.AgentId);

            builder.Entity<InsuranceContract>()
                .HasOne(e => e.Client)
                .WithMany(a => a.BoughtInsuranceContracts)
                .HasForeignKey(e => e.ClientId);

            base.OnModelCreating(builder);
        }
    }
}
