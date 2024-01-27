import type { AuditedEntityDto } from '@abp/ng.core';

export interface CmsPageDto extends AuditedEntityDto<string> {
  name?: string;
  htmlContent?: string;
}

export interface CreateUpdateCmsPageDto {
  name: string;
  htmlContent: string;
}
