import { CursusInstantie } from "./cursusInstantie";

export class Cursus {
    id!: number;
    duur!: number;
    titel!: string;
    code!: string;
    cursusinstanties!: CursusInstantie[];
}