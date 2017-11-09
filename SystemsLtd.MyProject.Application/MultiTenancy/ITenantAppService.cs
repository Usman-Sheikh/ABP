using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SystemsLtd.MyProject.MultiTenancy.Dto;

namespace SystemsLtd.MyProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
