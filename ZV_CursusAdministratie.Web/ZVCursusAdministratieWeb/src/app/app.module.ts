import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CursusService } from './api/services/cursus.service';
import { UploadService } from './api/services/upload.service';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CursusListComponent } from './cursus-list/cursus-list.component';
import { CustomDatePipe } from './shared/pipes/custom.datepipe';
import { UploadFileComponent } from './file-upload/file-upload.component'
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    CursusListComponent,
    UploadFileComponent,
    CustomDatePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [
    CursusService,
    UploadService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }


