import {Injectable} from '@angular/core';
import {Cursus} from '../models/Cursus';
import {CursusInstantie} from '../models/CursusInstantie';

@Injectable()

export class CursusService {

    cursusinstanties: CursusInstantie[] = [new CursusInstantie(1, new Date('2021-02-20'))]
    cursussen: Cursus[] =
         [
            new Cursus(1,5,'testtitel', 'tst', [new CursusInstantie(1, new Date('2021-02-20'))]) 
         ];

    getCursussen(){
        return this.cursussen;
    }
}