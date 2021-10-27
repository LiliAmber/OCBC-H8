import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {
  @Input() name = ""
  
  @Output() 
  eventHandler = new EventEmitter() //ini emitnya

  //function to trigger counter on parent
  buttonClick() {
    this.eventHandler.emit()
  }
  constructor() { }

  ngOnInit(): void {
  }

}
