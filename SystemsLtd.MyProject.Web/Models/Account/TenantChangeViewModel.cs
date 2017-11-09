using Abp.AutoMapper;
using SystemsLtd.MyProject.Sessions.Dto;

namespace SystemsLtd.MyProject.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}