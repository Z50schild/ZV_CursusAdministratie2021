import {Injectable} from '@angular/core';
import {CursusInstantie} from '../models/cursusInstantie';
import {HttpClient} from '@angular/common/http';
import {Observable, Subscriber} from 'rxjs'

@Injectable({
    providedIn: 'root'
})   

export class CursusService {
    url = 'https://localhost:44347/api/cursusinstantie'
    constructor(private http: HttpClient){}

    private cursusObservable!: Observable<CursusInstantie[]>;
    private cursusSubscriber!: Subscriber<CursusInstantie[]>;

    getCursusInstanties() {
        if(!this.cursusObservable){
            this.cursusObservable = new Observable(cs => {
                this.cursusSubscriber = cs;
            });
        }
        this.http.get<CursusInstantie[]>(this.url).subscribe(cursusinstanties =>{
            this.cursusSubscriber.next(cursusinstanties);
        });
        return this.cursusObservable;
    }
}