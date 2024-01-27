using AL.Abp.Dtos;
using AL.Abp.Entities;
using AutoMapper;

namespace AL.Abp;

public class AbpApplicationAutoMapperProfile : Profile
{
    public AbpApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<CmsPage, CmsPageDto>();
        CreateMap<CreateUpdateCmsPageDto, CmsPage>();
    }
}