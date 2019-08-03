import { Input, Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Product } from './product';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'product-list',
    templateUrl: './product-list.component.html'
})
export class ProductListComponent implements OnInit {

    products: Product[];
    @Input() catId: number; 
    providers: [DataService]

    constructor(private dataService: DataService, activeRoute: ActivatedRoute) { }
    
    ngOnInit() {
        this.load();
    }

    load() {
        this.dataService.getProducts(this.catId).subscribe((data: Product[]) => this.products = data);
    }
    
    delete(id: number) {
        this.dataService.deleteProduct(id).subscribe(data => this.load());
    }
}