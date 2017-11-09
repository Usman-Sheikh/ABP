using Abp.Authorization;
using SystemsLtd.MyProject.Authorization.Roles;
using SystemsLtd.MyProject.Authorization.Users;

namespace SystemsLtd.MyProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
