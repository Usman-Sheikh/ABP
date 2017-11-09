using System.Threading.Tasks;
using Abp.Application.Services;
using SystemsLtd.MyProject.Sessions.Dto;

namespace SystemsLtd.MyProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
