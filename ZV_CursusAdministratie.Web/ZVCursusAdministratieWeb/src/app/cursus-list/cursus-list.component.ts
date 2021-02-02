import { sharedStylesheetJitUrl } from "@angular/compiler";
import { Component, Input, OnInit } from "@angular/core";
import { Cursus } from "../api/models/cursus";
import { CursusService } from "../api/services/cursus.service";
import {CursusInstantie} from "../api/models/cursusInstantie"


@Component({
    selector: 'cursus-list',
    templateUrl: './cursus-list.component.html',
    styleUrls:['./cursus-list.component.css']    
})

export class CursusListComponent {
    cursusinstanties: CursusInstantie[] = [new CursusInstantie(1, new Date('2021-02-20'))]
    cursussen: Cursus[] =
         [
            new Cursus(1,5,'testtitel', 'tst', this.cursusinstanties) 
         ];

    getCursussen(){
        return this.cursussen;
    }



// constructor(private cursusService: CursusService){}

// ngOnInit(){
//     this.cursussen = this.cursusService.getCursussen();
// }
}