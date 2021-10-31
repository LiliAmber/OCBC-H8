import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  products1: any[] = [
    {
      id: 1,
      name: "product1",
      description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
    },
    {
      id: 2,
      name: "product2",
      description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
    },
    {
      id: 3,
      name: "product3",
      description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
    },
    {
      id: 4,
      name: "product4",
      description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
    },
    {
      id: 5,
      name: "product5",
      description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
    },
  ]

  products: Product[] = []

  constructor(
    private productService: ProductService
  ) { }

  ngOnInit(): void {
    this.getProducts()
  }

  getProducts() {
    this.productService
    .getProducts()
    .subscribe(products => this.products = products)
  }
}
