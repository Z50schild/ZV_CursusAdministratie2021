import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CursusService } from './api/services/cursus.service';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CursusListComponent } from './cursus-list/cursus-list.component';
import { CustomDatePipe } from './shared/pipes/custom.datepipe';

@NgModule({
  declarations: [
    AppComponent,
    CursusListComponent,
    CustomDatePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [CursusService],
  bootstrap: [AppComponent]
})
export class AppModule { }
