import{CustomDatePipe} from './custom.datepipe'
import {CursusInstantie} from '../../api/models/cursusInstantie';
import { Cursus } from 'src/app/api/models/cursus';


describe('Pipe: customDate', () =>{
    let customDatePipe: CustomDatePipe;

    beforeEach(()=>{
        customDatePipe = new CustomDatePipe('en-US');
    });

    it('should format a date', ()=>{
        let c= new CursusInstantie(1, new Date('2020-02-02'), new Cursus(1, 5, 'testTitel', 'tst'),1);
        expect(customDatePipe.transform(c.Startdatum, undefined)).toBe('02/02/2020')
    })
})