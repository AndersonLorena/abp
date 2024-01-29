import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';
import { CmsPageService } from '@proxy/app-services';
import type { PagedAndSortedResultRequestDto } from '@abp/ng.core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService, CmsPageService], multi: true },
];

function configureRoutes(routesService: RoutesService, cmsPageService: CmsPageService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/cmspages-config',
        name: '::Menu:CmsPagesConfig',
        iconClass: 'fas fa-sitemap',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/cmspages',
        name: '::Menu:CmsPages',
        parentName: '::Menu:CmsPagesConfig',
        iconClass: 'fas fa-cog',
        layout: eLayoutType.application,
      },
      {
        path: '/pages',
        name: '::Menu:Pages',
        iconClass: 'fas fa-bars',
        order: 3,
        layout: eLayoutType.application,
      },
    ]);

    const requestDto: PagedAndSortedResultRequestDto = {
      maxResultCount: 1000,
      skipCount: 0,
      sorting: ''
    };

    cmsPageService.getList(requestDto).subscribe((result) => {
      result.items.forEach((page) => {
        routesService.add([{
          path: `/pages/${page.id}`,
          name: `${page.name}`,
          iconClass: 'fa fa-file-code-o',
          parentName: '::Menu:Pages',
          layout: eLayoutType.application,
        }]);
      });
    });
  };
}
