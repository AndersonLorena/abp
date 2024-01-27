import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { CmspageRoutingModule } from './cmspage-routing.module';
import { CmspageComponent } from './cmspage.component';
import { EditorModule } from '@tinymce/tinymce-angular';

@NgModule({
  declarations: [
    CmspageComponent
  ],
  imports: [
    CmspageRoutingModule,
    SharedModule,
    EditorModule
  ]
})
export class CmspageModule { }
