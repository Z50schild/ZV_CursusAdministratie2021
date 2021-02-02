import {Injectable} from '@angular/core';
import {Cursus} from '../models/cursus';
import {CursusInstantie} from '../models/cursusInstantie';

@Injectable()
export class CursusService {

    cursusinstanties: CursusInstantie[] = [new CursusInstantie(1, new Date('2021-02-20'))]
    cursussen: Cursus[] =
         [
            new Cursus(1,5,'testtitel', 'tst', this.cursusinstanties) 
         ];

    getCursussen(){
        return this.cursussen;
    }
}