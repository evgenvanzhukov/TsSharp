import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from './product';
import { Cat } from './cat';

@Injectable()
export class DataService {

    private productUrl = "/api/products";
    private catUrl = "/api/cats"

    constructor(private http: HttpClient) {

    }

    getCatList() {
        return this.http.get(this.catUrl)
    }
    getProducts(id: number) {
        return this.http.get(this.productUrl + '/cat' + id);
    }
    getCat(id: number) {
        return this.http.get(this.catUrl + '/' + id);
    }
    getProduct(id: number) {
        return this.http.get(this.productUrl + '/' + id);
    }

    createProduct(product: Product) {
        return this.http.post(this.productUrl, product);
    }

    updateProduct(product: Product) {
        return this.http.put(this.productUrl + '/' + product.id, product);
    }

    deleteProduct(id: number) {
        return this.http.delete(this.productUrl + '/' + id);
    }
}