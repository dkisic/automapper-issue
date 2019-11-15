using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AutomapperIssue.Configuration;

namespace AutomapperIssue.Web.Startup
{
    [DependsOn(typeof(AutomapperIssueWebCoreModule))]
    public class AutomapperIssueWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AutomapperIssueWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<AutomapperIssueNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AutomapperIssueWebMvcModule).GetAssembly());
        }
    }
}
