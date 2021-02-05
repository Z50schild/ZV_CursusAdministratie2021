import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CursusListComponent } from './cursus-list/cursus-list.component'
import { UploadFileComponent } from './file-upload/file-upload.component';

const routes: Routes = [
  { path: 'cursus', component: CursusListComponent },
  {path: 'upload', component: UploadFileComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
