using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using sourcetree.EntityFrameworkCore;
using sourcetree.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace sourcetree.Web.Tests
{
    [DependsOn(
        typeof(sourcetreeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class sourcetreeWebTestModule : AbpModule
    {
        public sourcetreeWebTestModule(sourcetreeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(sourcetreeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(sourcetreeWebMvcModule).Assembly);
        }
    }
}