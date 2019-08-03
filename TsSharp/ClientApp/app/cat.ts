import { Product } from "./product";

export class Cat {
    constructor(
        public id?: number,
        public name?: string,
        public desc?: string,
        public fulldesc?: string,
        public fotoName?: string,
        public fotoMin?: string,
        public products?: Product[],
        public cats?: Cat[]){ }
}