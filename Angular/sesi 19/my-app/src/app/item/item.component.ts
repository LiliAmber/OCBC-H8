import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class ItemComponent implements OnInit {
  @Output() 
  newItemEvent = new EventEmitter<string>() 

  addNewItem(value: string) {
    this.newItemEvent.emit(value)
  }
  constructor() { }

  ngOnInit(): void {
  }

}
