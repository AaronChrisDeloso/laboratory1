using Abp.AspNetCore.Mvc.ViewComponents;

namespace sourcetree.Web.Views
{
    public abstract class sourcetreeViewComponent : AbpViewComponent
    {
        protected sourcetreeViewComponent()
        {
            LocalizationSourceName = sourcetreeConsts.LocalizationSourceName;
        }
    }
}
