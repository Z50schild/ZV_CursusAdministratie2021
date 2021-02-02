import {Injectable} from '@angular/core';
import {Cursus} from '../models/cursus';
import {CursusInstantie} from '../models/cursusInstantie';

@Injectable()
export class CursusService {
    cursus: Cursus = new Cursus(1,5,'testtitel', 'tst');
    cursusinstanties: CursusInstantie[] = [new CursusInstantie(1, new Date('2021-02-20'), this.cursus, this.cursus.id)]
    cursussen: Cursus[] =
         [
            this.cursus
         ];

          

    getCursussen(){
        return this.cursussen;
    }

    getCursusInstanties(){
        return this.cursusinstanties
    }
}