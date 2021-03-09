using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace InvManSaas.Controllers
{
    public abstract class InvManSaasControllerBase: AbpController
    {
        protected InvManSaasControllerBase()
        {
            LocalizationSourceName = InvManSaasConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
