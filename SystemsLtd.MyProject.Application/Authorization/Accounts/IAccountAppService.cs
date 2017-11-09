using System.Threading.Tasks;
using Abp.Application.Services;
using SystemsLtd.MyProject.Authorization.Accounts.Dto;

namespace SystemsLtd.MyProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
