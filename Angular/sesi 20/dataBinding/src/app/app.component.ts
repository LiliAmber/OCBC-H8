import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'dataBinding';
  currentCustomer = "Maria"
  message = "abcd"
  itemImageUrl = "../assets/Get Todo By Id.png"
  
}
