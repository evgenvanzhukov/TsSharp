import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from './data.service';
import { Cat } from './cat';
import { Product } from './product';

@Component({
    templateUrl: './cat-list.component.html',
    providers: [DataService]
})

export class CatListComponent implements OnInit {

    cats: Cat[];
    loaded: boolean = false;
    products: Product[];

    constructor(private dataService: DataService, activeRoute: ActivatedRoute) {
        this.load();
    }

    ngOnInit() {
        this.load();
    }

    load() {
        this.dataService.getCatList().subscribe((data: Cat[]) => this.cats = data);
    }


}