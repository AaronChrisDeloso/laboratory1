using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using sourcetree.Configuration;

namespace sourcetree.Web.Host.Startup
{
    [DependsOn(
       typeof(sourcetreeWebCoreModule))]
    public class sourcetreeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public sourcetreeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(sourcetreeWebHostModule).GetAssembly());
        }
    }
}
