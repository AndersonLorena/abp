using Volo.Abp.Modularity;

namespace AL.Abp;

public abstract class AbpApplicationTestBase<TStartupModule> : AbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
