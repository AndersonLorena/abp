using AL.Abp.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AL.Abp.AppServices
{
    public interface ICmsPageAppService : IApplicationService
    {
        Task<List<CmsPageDto>> GetAll();

        Task<CmsPageDto> InsertOrUpdateCMSContent(CreateUpdateCmsPageDto dto);

        Task<CmsPageDto> GetCMSContent(Guid id);
    }
}