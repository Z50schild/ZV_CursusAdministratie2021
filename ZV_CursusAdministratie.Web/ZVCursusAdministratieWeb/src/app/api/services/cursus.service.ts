import {Injectable} from '@angular/core';
import {Cursus} from '../models/cursus';
import {CursusInstantie} from '../models/cursusInstantie';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs'

@Injectable({
    providedIn: 'root'
})   


export class CursusService {
    cursus: Cursus = new Cursus(1,5,'testtitel', 'tst');
    cursusinstanties: CursusInstantie[] = [new CursusInstantie(1, new Date('2021-02-20'), this.cursus, this.cursus.id)]
    cursussen: Cursus[] =
         [
            this.cursus
         ];


    url = 'https://localhost:44347/Api/CursusInstantie'
    constructor(private http: HttpClient){}


    getCursussen(){
        return this.cursussen;
    }

    getCursusInstanties(): Observable<CursusInstantie[]>{
        // return this.cursusinstanties
        return this.http.get<CursusInstantie[]>(this.url)

    }
}