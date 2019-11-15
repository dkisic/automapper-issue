using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AutomapperIssue.Authorization;

namespace AutomapperIssue
{
    [DependsOn(
        typeof(AutomapperIssueCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AutomapperIssueApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AutomapperIssueAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AutomapperIssueApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
