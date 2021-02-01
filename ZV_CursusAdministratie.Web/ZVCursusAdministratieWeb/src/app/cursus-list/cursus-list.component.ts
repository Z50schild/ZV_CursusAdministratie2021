import { Component, OnInit } from "@angular/core";
import { Cursus } from "../api/models/Cursus";
import { CursusInstantie } from "../api/models/CursusInstantie";
import { CursusService } from '../api/Services/Cursus.Service';

@Component({
    selector: 'cursus-list',
    templateUrl: './cursus-list.component.html',
})

export class CursusListComponent implements OnInit {
    cursussen!: Cursus[] ;

constructor (private cursusService: CursusService){}

    ngOnInit(){
        this.cursussen = this.cursusService.getCursussen();
    }
      
};