using System.Collections.Generic;
using SystemsLtd.MyProject.Roles.Dto;

namespace SystemsLtd.MyProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}