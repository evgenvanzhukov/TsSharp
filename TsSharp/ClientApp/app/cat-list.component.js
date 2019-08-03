var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from './data.service';
var CatListComponent = /** @class */ (function () {
    function CatListComponent(dataService, activeRoute) {
        this.dataService = dataService;
        this.loaded = false;
        this.load();
    }
    CatListComponent.prototype.ngOnInit = function () {
        this.load();
    };
    CatListComponent.prototype.load = function () {
        var _this = this;
        this.dataService.getCatList().subscribe(function (data) { return _this.cats = data; });
    };
    CatListComponent = __decorate([
        Component({
            templateUrl: './cat-list.component.html',
            providers: [DataService]
        }),
        __metadata("design:paramtypes", [DataService, ActivatedRoute])
    ], CatListComponent);
    return CatListComponent;
}());
export { CatListComponent };
//# sourceMappingURL=cat-list.component.js.map