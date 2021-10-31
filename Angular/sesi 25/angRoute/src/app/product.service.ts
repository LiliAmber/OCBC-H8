import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators'

import { Product } from './models/product';
import { PRODUCTS } from './models/mock-product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor() { }
  
  products = of(PRODUCTS)
  getProducts(): Observable<Product[]> {
    return this.products
  }

  // getOneProduct(id: number): Product {
    // let product: Product
  //   this.getProducts()
  //   .subscribe(products => product = products
  //                                     .find(p => p.id === id)!
  //     )

  //     return product!
  // }
  getProductById(id: number): Observable<Product> {
    // const product = PRODUCTS.find((product) => product.id == id)!
    // return of(product)
    return this.products.pipe
    (map(
      products => products.find(product => product.id === +id)!
      )
    )
  }
}


