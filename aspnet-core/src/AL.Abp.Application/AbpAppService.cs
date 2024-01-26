using System;
using System.Collections.Generic;
using System.Text;
using AL.Abp.Localization;
using Volo.Abp.Application.Services;

namespace AL.Abp;

/* Inherit your application services from this class.
 */
public abstract class AbpAppService : ApplicationService
{
    protected AbpAppService()
    {
        LocalizationResource = typeof(AbpResource);
    }
}
