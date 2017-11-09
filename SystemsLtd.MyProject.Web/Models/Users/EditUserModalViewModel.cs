using System.Collections.Generic;
using System.Linq;
using SystemsLtd.MyProject.Roles.Dto;
using SystemsLtd.MyProject.Users.Dto;

namespace SystemsLtd.MyProject.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.Roles != null && User.Roles.Any(r => r == role.DisplayName);
        }
    }
}