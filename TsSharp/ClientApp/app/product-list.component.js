var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Input, Component } from '@angular/core';
import { DataService } from './data.service';
import { ActivatedRoute } from '@angular/router';
var ProductListComponent = /** @class */ (function () {
    function ProductListComponent(dataService, activeRoute) {
        this.dataService = dataService;
    }
    ProductListComponent.prototype.ngOnInit = function () {
        this.load();
    };
    ProductListComponent.prototype.load = function () {
        var _this = this;
        this.dataService.getProducts(this.catId).subscribe(function (data) { return _this.products = data; });
    };
    ProductListComponent.prototype.delete = function (id) {
        var _this = this;
        this.dataService.deleteProduct(id).subscribe(function (data) { return _this.load(); });
    };
    __decorate([
        Input(),
        __metadata("design:type", Number)
    ], ProductListComponent.prototype, "catId", void 0);
    ProductListComponent = __decorate([
        Component({
            selector: 'product-list',
            templateUrl: './product-list.component.html'
        }),
        __metadata("design:paramtypes", [DataService, ActivatedRoute])
    ], ProductListComponent);
    return ProductListComponent;
}());
export { ProductListComponent };
//# sourceMappingURL=product-list.component.js.map