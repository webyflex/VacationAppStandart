using System.Data.Entity;
using VacationPolicyDAL.Configuration;
using VacationPolicyDAL.Models.Auth;

namespace VacationPolicyDAL.Repository.Base
{
    public class AppDbContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }

        public AppDbContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            AppUserConfiguration.Configure(modelBuilder);
            UserInfoConfiguration.Configure(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
