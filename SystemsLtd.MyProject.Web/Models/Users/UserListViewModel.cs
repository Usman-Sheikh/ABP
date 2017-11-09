using System.Collections.Generic;
using SystemsLtd.MyProject.Roles.Dto;
using SystemsLtd.MyProject.Users.Dto;

namespace SystemsLtd.MyProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}