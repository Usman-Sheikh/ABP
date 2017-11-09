using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SystemsLtd.MyProject.Roles.Dto;
using SystemsLtd.MyProject.Users.Dto;

namespace SystemsLtd.MyProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}