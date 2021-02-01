import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {CursusListComponent} from './cursus-list/cursus-list.component'

const routes: Routes = [
  {path: 'cursus', component: CursusListComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
