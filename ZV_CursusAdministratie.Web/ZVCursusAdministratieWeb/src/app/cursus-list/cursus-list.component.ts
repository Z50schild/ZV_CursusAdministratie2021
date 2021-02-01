import { Component, Input } from "@angular/core";
import { Cursus } from "../api/models/cursus";


@Component({
    selector: 'cursus-list',
    templateUrl: './cursus-list.component.html'
})

export class CursusListComponent{
@Input() cursussen!: Cursus[];
}