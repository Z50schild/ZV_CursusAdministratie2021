import { sharedStylesheetJitUrl } from "@angular/compiler";
import { Component, Input, OnInit } from "@angular/core";
import { Cursus } from "../api/models/cursus";
import { CursusService } from "../api/services/cursus.service";
import {CursusInstantie} from "../api/models/cursusInstantie";
import {HttpClient} from '@angular/common/http';


@Component({
    selector: 'cursus-list',
    templateUrl: './cursus-list.component.html',
    styleUrls:['./cursus-list.component.css']    
})

export class CursusListComponent implements OnInit {

    cursusInstanties!: CursusInstantie[];

    constructor(private cursusService: CursusService){}

    ngOnInit(){
        this.cursusService.getCursusInstanties()
        .subscribe(
            data =>{
                this.cursusInstanties = data as CursusInstantie[]
            }
        )
    }

    

}