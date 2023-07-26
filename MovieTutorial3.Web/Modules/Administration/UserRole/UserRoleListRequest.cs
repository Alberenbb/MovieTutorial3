using Serenity.Services;

namespace MovieTutorial3.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}