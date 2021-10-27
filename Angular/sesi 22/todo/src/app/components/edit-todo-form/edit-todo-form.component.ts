import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { Todo } from 'src/app/Models/Todo';

@Component({
  selector: 'app-edit-todo-form',
  templateUrl: './edit-todo-form.component.html',
  styleUrls: ['./edit-todo-form.component.css']
})
export class EditTodoFormComponent implements OnInit {
  @Output() newEditTodoEvent = new EventEmitter()
  editTodo: string = ''

  updateTodo() {
    console.log("aku di trigger")
    const editTodo: Todo = {
      content: this.editTodo,
      completed: false
    };
    this.newEditTodoEvent.emit(editTodo)
    this.editTodo = ''
  }

  constructor() { }

  ngOnInit(): void {
  }

}
