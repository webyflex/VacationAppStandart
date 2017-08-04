using Microsoft.AspNet.Identity.EntityFramework;
using VacationPolicyBL.Models.Auth;
using VacationPolicyBL.Models;

namespace VacationPolicyDAL.Models.Auth
{
    public class AppUser : IdentityUser, IAppUser
    {
        public virtual UserInfo UserInfo { get; set; }
        public int UserInfoId { get; set; }
    }
}
