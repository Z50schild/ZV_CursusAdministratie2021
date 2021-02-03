import { Cursus } from './cursus'


export class CursusInstantie {
    constructor(public id: number, public startdatum: Date, public cursus: Cursus, public cursusId: number) {}
    // id: number;
    // startdatum: Date;
}