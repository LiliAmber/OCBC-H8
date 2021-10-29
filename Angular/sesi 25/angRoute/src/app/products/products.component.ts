import { Component, OnInit } from '@angular/core';

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
  products: any[] = [
    { id: 1, code: "MD001", name: "Mouse Desktop MD001", price: 100 },
    { id: 2, code: "KD001", name: "Keyboard Desktop KD001", price: 110 },
    { id: 3, code: "MP001", name: "MousePad MP001", price: 10 },
    { id: 4, code: "MD002", name: "Mouse Desktop Extra MD002", price: 200 },
    { id: 5, code: "MD003", name: "Mouse Desktop Ultra MD003", price: 1000 },
  ]
  constructor() { }

  ngOnInit(): void {
  }

}
