using System.Collections.Generic;
using VacationPolicyBL.Repository.Base;

namespace VacationPolicyBL.Models
{
    public class UserInfo : IIdentity
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual UserInfo Parent { get; set; }
        public virtual List<UserInfo> Children { get; set; }
    }
}
