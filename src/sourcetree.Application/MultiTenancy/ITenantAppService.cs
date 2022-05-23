using Abp.Application.Services;
using sourcetree.MultiTenancy.Dto;

namespace sourcetree.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

