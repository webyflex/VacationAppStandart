using System.Data.Entity;
using VacationPolicyBL.Models;

namespace VacationPolicyDAL.Configuration
{
    public class UserInfoConfiguration
    {
        public static void Configure(DbModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<UserInfo>();

            entity.ToTable("UserInfo");
            entity.HasKey(c => c.Id);
            entity.Property(c => c.ParentId).IsOptional();
            entity.Property(c => c.FirstName).IsRequired().HasMaxLength(50);
            entity.Property(c => c.LastName).IsRequired().HasMaxLength(50);
            entity.HasOptional(c => c.Parent).WithMany(c => c.Children).HasForeignKey(fk => fk.ParentId);
        }
    }
}
