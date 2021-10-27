import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Todo } from 'src/app/Models/Todo';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {

  todos: Todo[] = []
  @Output() newEditTodoEvent = new EventEmitter()
  editTodo: string = ''

  constructor() { }

  //==sama kaya created di vue==
  ngOnInit(): void {
    this.todos = [
      {
        content: "First Todo",
        completed: false
      },
      {
        content: "Second Todo",
        completed: false
      },
      {
        content: "Third Todo",
        completed: false
      },
      {
        content: "Fourth Todo",
        completed: false
      },
      {
        content: "Fifth Todo",
        completed: false
      },
      
    ]
  }

  toggleDone(id: number) {
    this.todos.map((v, i) => {
      if(i === id) {
        v.completed = !v.completed
      }
      // console.log(v)
      return v
    })
  }

  deleteTodo(id: number) {
    console.log(id, "id delete")
    this.todos = this.todos.filter((v, i) => i !== id)
  }

  addTodo(todo: Todo) {
    this.todos.push(todo)
  }
  
  editTodoTrigger(todo: Todo) {
    todo.editing = true
    console.log("aku di klik")
  }

  updateTodo(updTodo: Todo) {
    console.log(updTodo, "<<<edit")
    updTodo.content = this.editTodo
    console.log(this.editTodo, '<<<after edit')
    if(updTodo.content) {
      updTodo.content = this.editTodo
      updTodo.completed = false
      updTodo.editing = false
    }
    this.newEditTodoEvent.emit(updTodo)
    this.editTodo = ''
  }
}
