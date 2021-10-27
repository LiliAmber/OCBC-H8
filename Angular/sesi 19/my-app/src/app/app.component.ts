import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'my-app';
  counter = 0;
  items = ["sepatu", "sendal", "tas"]

  // function yg di trigger di child(button)
  eventCounter() {
    this.counter ++
  }

  addItemInParent(newItem: string) {
    this.items.push(newItem)
  }
}
