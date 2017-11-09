using System.Threading.Tasks;
using Abp.Application.Services;
using SystemsLtd.MyProject.Configuration.Dto;

namespace SystemsLtd.MyProject.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}