namespace VacationPolicyDAL.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models.Auth;
    using Repository.Base;
    using System.Data.Entity.Migrations;
    using VacationPolicyBL.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context)
        {
            var manager = new UserManager<AppUser>(new UserStore<AppUser>(context));

            var user = new AppUser()
            {
                UserName = "su",
                Email = "super.user@gmail.com",
                EmailConfirmed = true,
                UserInfo = new UserInfo()
                {
                    FirstName = "Super",
                    LastName = "User",
                }
            };

            manager.Create(user, "test123");
        }
    }
}
