using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace sourcetree.Web.Views
{
    public abstract class sourcetreeRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected sourcetreeRazorPage()
        {
            LocalizationSourceName = sourcetreeConsts.LocalizationSourceName;
        }
    }
}
