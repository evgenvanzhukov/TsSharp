var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { Component } from '@angular/core';
var AppComponent = /** @class */ (function () {
    function AppComponent() {
    }
    AppComponent = __decorate([
        Component({
            selector: 'app',
            templateUrl: './app.component.html'
        })
    ], AppComponent);
    return AppComponent;
}());
export { AppComponent };
//import { Component, OnInit } from '@angular/core';
//import { DataService } from './data.service';
//import { Product } from './product';
//import { HttpResponse } from '@angular/common/http';
//@Component({
//    selector: 'app',
//    templateUrl: './app.component.html',
//    providers: [DataService]
//})
//export class AppComponent implements OnInit {
//    product: Product = new Product();   // изменяемый товар
//    products: Product[];                // массив товаров
//    tableMode: boolean = true;          // табличный режим
//    constructor(private dataService: DataService) { }
//    ngOnInit() {
//        this.loadProducts();    // загрузка данных при старте компонента  
//    }
//    // получаем данные через сервис
//    loadProducts() {
//        this.dataService.getProducts()
//            .subscribe((data: Product[]) => this.products = data);
//    }
//    // сохранение данных
//    save() {
//        if (this.product.id == null) {
//            this.dataService.createProduct(this.product)
//                .subscribe((data: Product) => {
//                    this.products.push(data);
//                });
//        } else {
//            this.dataService.updateProduct(this.product)
//                .subscribe(data => this.loadProducts());
//        }
//        this.cancel();
//    }
//    editProduct(p: Product) {
//        this.product = p;
//    }
//    cancel() {
//        this.product = new Product();
//        this.tableMode = true;
//    }
//    delete(p: Product) {
//        this.dataService.deleteProduct(p.id)
//            .subscribe(data => this.loadProducts());
//    }
//    add() {
//        this.cancel();
//        this.tableMode = false;
//    }
//}
//# sourceMappingURL=app.component.js.map