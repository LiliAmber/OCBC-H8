import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { Todo } from 'src/app/Models/Todo';

@Component({
  selector: 'app-edit-todo-form',
  templateUrl: './edit-todo-form.component.html',
  styleUrls: ['./edit-todo-form.component.css']
})
export class EditTodoFormComponent implements OnInit {
  

  

  // editTodoTrigger(todo: Todo) {
  //   todo.editing = true
  //   console.log("aku di klik")
  // }
  constructor() { }

  ngOnInit(): void {
  }

}
