using Volo.Abp.Modularity;

namespace AL.Abp;

[DependsOn(
    typeof(AbpDomainModule),
    typeof(AbpTestBaseModule)
)]
public class AbpDomainTestModule : AbpModule
{

}
