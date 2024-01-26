using Xunit;

namespace AL.Abp.EntityFrameworkCore;

[CollectionDefinition(AbpTestConsts.CollectionDefinitionName)]
public class AbpEntityFrameworkCoreCollection : ICollectionFixture<AbpEntityFrameworkCoreFixture>
{

}
