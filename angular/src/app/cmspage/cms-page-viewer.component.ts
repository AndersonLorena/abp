import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CmsPageService } from '@proxy/app-services';
import { CmsPageDto } from '@proxy/dtos';

@Component({
  selector: 'app-cms-page-viewer',
  template: '<div [innerHTML]="htmlContent"></div>',
})
export class CmsPageViewerComponent implements OnInit {
  htmlContent: string = '';

  constructor(
    private route: ActivatedRoute,
    private cmsPageService: CmsPageService
  ) {}

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const pageId = params.get('id');
      if (pageId) {
        this.cmsPageService.get(pageId).subscribe((page: CmsPageDto) => {
          this.htmlContent = page.htmlContent || '';
        });
      }
    });
  }
}
