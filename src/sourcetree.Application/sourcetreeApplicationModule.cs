using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using sourcetree.Authorization;

namespace sourcetree
{
    [DependsOn(
        typeof(sourcetreeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class sourcetreeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<sourcetreeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(sourcetreeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
