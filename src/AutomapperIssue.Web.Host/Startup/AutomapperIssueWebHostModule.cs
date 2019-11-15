using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AutomapperIssue.Configuration;

namespace AutomapperIssue.Web.Host.Startup
{
    [DependsOn(
       typeof(AutomapperIssueWebCoreModule))]
    public class AutomapperIssueWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AutomapperIssueWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AutomapperIssueWebHostModule).GetAssembly());
        }
    }
}
