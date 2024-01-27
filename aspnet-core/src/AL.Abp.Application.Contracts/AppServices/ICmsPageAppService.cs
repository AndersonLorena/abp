using AL.Abp.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AL.Abp.AppServices
{
    public interface ICmsPageAppService : ICrudAppService<
        CmsPageDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCmsPageDto>
    { }
}