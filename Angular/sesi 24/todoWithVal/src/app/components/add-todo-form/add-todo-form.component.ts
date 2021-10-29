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
  isSubmitted: boolean = false

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
    // this.handleIsSubmittedState(true)

    this.todo = {
      completed: false,
      editing: false,
      content: this.addForm.value.content
    }
    
    this.newTodoEvent.emit(this.todo)
    this.addForm.reset()
  }

  // handleIsSubmittedState(val: boolean) {
  //   this.isSubmitted = val
  // }

  constructor() { }

  ngOnInit(): void {
  }

}
