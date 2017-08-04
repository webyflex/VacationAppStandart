namespace VacationPolicyBL.Models.Auth
{
    public interface IAppUser
    {
        int UserInfoId { get; set; }
        UserInfo UserInfo { get; set; }
    }
}
