import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { CmspageRoutingModule } from './cmspage-routing.module';
import { CmspageComponent } from './cmspage.component';

@NgModule({
  declarations: [
    CmspageComponent
  ],
  imports: [
    CmspageRoutingModule,
    SharedModule
  ]
})
export class CmspageModule { }
