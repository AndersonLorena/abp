import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CmsPageDto, CreateUpdateCmsPageDto } from '../dtos/models';

@Injectable({
  providedIn: 'root',
})
export class CmsPageService {
  apiName = 'Default';
  

  create = (input: CreateUpdateCmsPageDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CmsPageDto>({
      method: 'POST',
      url: '/api/app/cms-page',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/cms-page/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CmsPageDto>({
      method: 'GET',
      url: `/api/app/cms-page/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<CmsPageDto>>({
      method: 'GET',
      url: '/api/app/cms-page',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdateCmsPageDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CmsPageDto>({
      method: 'PUT',
      url: `/api/app/cms-page/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
