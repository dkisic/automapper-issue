using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AutomapperIssue.Localization
{
    public static class AutomapperIssueLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AutomapperIssueConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AutomapperIssueLocalizationConfigurer).GetAssembly(),
                        "AutomapperIssue.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
