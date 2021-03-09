using Abp.Authorization;
using InvManSaas.Authorization.Roles;
using InvManSaas.Authorization.Users;

namespace InvManSaas.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
