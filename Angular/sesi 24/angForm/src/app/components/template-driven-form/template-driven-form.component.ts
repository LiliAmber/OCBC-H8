import { Component, OnInit } from '@angular/core';
import { Task } from 'src/app/Models/Task';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-template-driven-form',
  templateUrl: './template-driven-form.component.html',
  styleUrls: ['./template-driven-form.component.css']
})
export class TemplateDrivenFormComponent implements OnInit {
  tasks: Task[] = []
  categories = ["School", "Work", "Hobby"]

  onSubmit(form: NgForm) {
    const {taskName, category} = form.value
    // console.log(taskName)
    // console.log(category)
    this.tasks = [...this.tasks, new Task(taskName, "in-progress", category)]
    // console.log(this.tasks)
    form.reset()
  }
  constructor() { }

  ngOnInit(): void {
  }

}
