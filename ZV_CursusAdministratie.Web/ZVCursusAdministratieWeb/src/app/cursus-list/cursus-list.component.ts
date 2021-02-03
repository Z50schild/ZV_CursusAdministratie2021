import { Component, Input, NgModule, OnInit } from "@angular/core";
import { Cursus } from "../api/models/cursus";
import { CursusService } from "../api/services/cursus.service";
import { CursusInstantie } from "../api/models/cursusInstantie";
import { HttpClient } from '@angular/common/http';

// @NgModule({
//   declarations: [
//     UploadFileComponent
//   ],
//   providers:[
//     UploadService
//   ]
//   })

@Component({
    selector: 'cursus-list',
    templateUrl: './cursus-list.component.html',
    styleUrls: ['./cursus-list.component.css']
})

export class CursusListComponent implements OnInit {

    cursusInstanties!: CursusInstantie[];

    constructor(private cursusService: CursusService) { }

    ngOnInit() {
        this.cursusService.getCursusInstanties()
            .subscribe(
                data => {
                    this.cursusInstanties = data as CursusInstantie[]
                }
            )
    }



}