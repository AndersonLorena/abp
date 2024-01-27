using AL.Abp.Dtos;
using AL.Abp.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AL.Abp.AppServices
{
    public class CmsPageAppService : ApplicationService, ICmsPageAppService
    {
        private readonly IRepository<CmsPage, Guid> _repository;

        public CmsPageAppService(IRepository<CmsPage, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<List<CmsPageDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<CmsPageDto> GetCMSContent(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<CmsPageDto> InsertOrUpdateCMSContent(CreateUpdateCmsPageDto dto)
        {
            throw new NotImplementedException();
        }
    }
}