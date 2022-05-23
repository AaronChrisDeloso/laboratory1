using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace sourcetree.Localization
{
    public static class sourcetreeLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(sourcetreeConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(sourcetreeLocalizationConfigurer).GetAssembly(),
                        "sourcetree.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
