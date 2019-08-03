import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';


import { AppComponent } from './app.component';
import { CatComponent } from './cat.component';
import { CatListComponent } from './cat-list.component';
import { ProductListComponent } from './product-list.component';
import { ProductDetailComponent } from './product-detail.component'
import { ProductFormComponent } from './product-form.component';
import { ProductCreateComponent } from './product-create.component';
import { ProductEditComponent } from './product-edit.component';
import { NotFoundComponent } from './not-found.component';

import { DataService } from './data.service';

//определение маршрутов
const appRoutes: Routes = [
    { path: '', component: CatListComponent },
    { path: 'api/cats/:id', component: CatComponent },
    { path: 'api/products/cat:id', component: ProductListComponent },
    { path: 'api/product/:id', component: ProductDetailComponent },
    { path: 'api/product/create', component: ProductCreateComponent },
    { path: 'api/edit/:id', component: ProductEditComponent },
    { path: '**', component: NotFoundComponent }
];

@NgModule({
    imports: [BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, CatListComponent, CatComponent, ProductListComponent, ProductDetailComponent,
        ProductCreateComponent, ProductEditComponent, ProductFormComponent, NotFoundComponent],
    providers: [DataService],
    bootstrap: [AppComponent]
})
export class AppModule { }