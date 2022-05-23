using Abp.Authorization;
using sourcetree.Authorization.Roles;
using sourcetree.Authorization.Users;

namespace sourcetree.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
