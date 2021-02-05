import { TestBed, inject } from '@angular/core/testing';
import {CursusListComponent} from './cursus-list.component';
import {CursusService} from '../api/services/cursus.service';
import {HttpClient} from '@angular/common/http';
import { of } from 'rxjs';


describe('Componnent: cursus-list', ()=>{
let component: CursusListComponent;
let service: CursusService;
let spy: any;
let http: HttpClient;

beforeEach(()=>{
    
    service = new CursusService(http);
    component = new CursusListComponent(service)
});

afterEach(()=>{
    service = null as any;
    component = null as any;
})

it('should component returns data on instantiate', ()=>{
    spy = spyOn(service, 'getCursusInstanties').and.returnValue(of([]))
    component.ngOnInit();
    expect(service.getCursusInstanties).toHaveBeenCalled();
})

})