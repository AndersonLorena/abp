import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { CmsPageService } from '@proxy/app-services';
import { CmsPageDto } from '@proxy/dtos';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-cmspage',
  templateUrl: './cmspage.component.html',
  styleUrl: './cmspage.component.scss',
  providers: [ListService],
})
export class CmspageComponent implements OnInit {
  cmspage = { items: [], totalCount: 0 } as PagedResultDto<CmsPageDto>;

  selectedCmsPage = {} as CmsPageDto;
  form: FormGroup;
  isModalOpen = false;

  constructor(
    public readonly list: ListService,
    private cmspageService: CmsPageService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ) { }

  ngOnInit() {
    const cmspageStreamCreator = (query) => this.cmspageService.getList(query);

    this.list.hookToQuery(cmspageStreamCreator).subscribe((response) => {
      this.cmspage = response;
    });
  }

  createCmsPage() {
    this.selectedCmsPage = {} as CmsPageDto;
    this.buildForm();
    this.isModalOpen = true;
  }

  editCmsPage(id: string) {
    this.cmspageService.get(id).subscribe((cmsPage) => {
      this.selectedCmsPage = cmsPage;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.cmspageService.delete(id).subscribe(() => this.list.get());
      }
    });
  }

  buildForm() {
    this.form = this.fb.group({
      name: [this.selectedCmsPage.name || '', Validators.required],
      htmlContent: [this.selectedCmsPage.htmlContent || '', Validators.required]
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedCmsPage.id
      ? this.cmspageService.update(this.selectedCmsPage.id, this.form.value)
      : this.cmspageService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
}
