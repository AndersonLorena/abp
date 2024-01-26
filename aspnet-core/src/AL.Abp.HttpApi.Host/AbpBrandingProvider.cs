using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AL.Abp;

[Dependency(ReplaceServices = true)]
public class AbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Abp";
}
