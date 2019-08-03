import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from './data.service';
import { Cat } from './cat';
import { Product } from './product';

@Component({
    templateUrl:'./cat.component.html',
    providers: [DataService]
})
export class CatComponent implements OnInit {
    id: number;
    cat: Cat;
    loaded: boolean = false;
    products: Product[];

    constructor(private dataService: DataService, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        if (this.id)
            this.dataService.getCat(this.id)
                .subscribe((data: Cat) => { this.cat = data; this.products = data.products; this.loaded = true; });
    }
}