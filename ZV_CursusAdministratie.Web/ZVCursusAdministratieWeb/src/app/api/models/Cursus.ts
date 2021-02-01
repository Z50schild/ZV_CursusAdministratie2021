import {CursusInstantie} from "./CursusInstantie";

export class Cursus {
    constructor(public id: number, public duur:number, public titel: string, public code: string, public cursusinstanties: CursusInstantie[]){}
    
    // id: number;
    // duur: number;
    // titel: string;
    // code: string;
    // cursusinstanties: CursusInstantie[];
}