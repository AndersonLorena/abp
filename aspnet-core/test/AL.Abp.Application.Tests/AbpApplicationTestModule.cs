using Volo.Abp.Modularity;

namespace AL.Abp;

[DependsOn(
    typeof(AbpApplicationModule),
    typeof(AbpDomainTestModule)
)]
public class AbpApplicationTestModule : AbpModule
{

}
