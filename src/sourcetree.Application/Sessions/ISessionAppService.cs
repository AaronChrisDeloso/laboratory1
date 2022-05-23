using System.Threading.Tasks;
using Abp.Application.Services;
using sourcetree.Sessions.Dto;

namespace sourcetree.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
