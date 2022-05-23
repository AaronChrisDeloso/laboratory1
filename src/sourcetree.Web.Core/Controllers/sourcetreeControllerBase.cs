using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace sourcetree.Controllers
{
    public abstract class sourcetreeControllerBase: AbpController
    {
        protected sourcetreeControllerBase()
        {
            LocalizationSourceName = sourcetreeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
