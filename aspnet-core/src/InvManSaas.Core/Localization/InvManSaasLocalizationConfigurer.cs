using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace InvManSaas.Localization
{
    public static class InvManSaasLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(InvManSaasConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(InvManSaasLocalizationConfigurer).GetAssembly(),
                        "InvManSaas.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
