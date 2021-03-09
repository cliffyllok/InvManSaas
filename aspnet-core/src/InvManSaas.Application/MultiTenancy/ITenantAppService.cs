using Abp.Application.Services;
using InvManSaas.MultiTenancy.Dto;

namespace InvManSaas.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

