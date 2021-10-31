import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { Product } from '../models/product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent {
  productId: number
  product: Product = {} as Product

  constructor(private activatedRoute: ActivatedRoute, private productService: ProductService) {
    this.productId = this.activatedRoute.snapshot.params.id
  }

  ngOnInit(): void {
    this.getProductById(this.productId)
  }

  getProductById(id: number) {
    console.log(id, "id product")
    console.log(typeof id, 'id data type')
    this.productService 
    .getProductById(id)
    .subscribe(p => this.product = p)
  }
}
