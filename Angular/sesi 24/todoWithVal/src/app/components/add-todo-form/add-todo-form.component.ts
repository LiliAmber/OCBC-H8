import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Todo } from 'src/app/Model/Todo';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css']
})
export class AddTodoFormComponent implements OnInit {
  @Output() newTodoEvent = new EventEmitter()
  inputTodo: string = ''

  // addTodo() {
  //   const todo: Todo = {
  //     content: this.inputTodo,
  //     completed: false
  //   };
  //   this.newTodoEvent.emit(todo)
  //   this.inputTodo = ''
  // }

  todo: Todo = {
    completed: false,
    content: '',
    editing: false
  }

  addForm = new FormGroup({
    content: new FormControl('', [
      Validators.required,
      Validators.minLength(5)
    ])
  })

  get content() {
    return this.addForm.get('content')
  }

  addTodo() {
    console.log(this.addForm)
  }
  constructor() { }

  ngOnInit(): void {
  }

}
