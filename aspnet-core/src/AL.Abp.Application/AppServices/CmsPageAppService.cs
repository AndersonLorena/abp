using AL.Abp.Dtos;
using AL.Abp.Entities;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AL.Abp.AppServices
{
    [Authorize]
    public class CmsPageAppService(IRepository<CmsPage, Guid> repository) : CrudAppService<
        CmsPage, CmsPageDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCmsPageDto>(repository),
        ICmsPageAppService
    {
        [AllowAnonymous]
        public override async Task<CmsPageDto> GetAsync(Guid id)
        {
            return await base.GetAsync(id);
        }

        [AllowAnonymous]
        public override async Task<PagedResultDto<CmsPageDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return await base.GetListAsync(input);
        }
    }
}