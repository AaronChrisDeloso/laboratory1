using System.Threading.Tasks;
using sourcetree.Configuration.Dto;

namespace sourcetree.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
