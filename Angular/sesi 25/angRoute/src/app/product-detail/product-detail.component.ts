import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent {
  productId: string

  constructor(private activatedRoute: ActivatedRoute) {
    this.productId = this.activatedRoute.snapshot.params.id
  }

  ngOnInit(): void {
  }

}
