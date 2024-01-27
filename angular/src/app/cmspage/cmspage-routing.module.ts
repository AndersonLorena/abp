import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CmspageComponent } from './cmspage.component';

const routes: Routes = [{ path: '', component: CmspageComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CmspageRoutingModule { }
