import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'directives';

  isLoggedIn = true

  nullValue = null

  currentUser = {username: "nirmala"}

  isActive = true

  heroes = [
    {id: 1, name: "Dr.Nice", emotion: "happy"},
    {id: 2, name: "Narco", emotion: "sad"},
    {id: 3, name: "Windstorm", emotion: "confused"},
    {id: 4, name: "Magneta"}
  ]

  people: any[] = [
    {
      name: "DouGlas Pace",
      age: 35,
      country: "MARS"
    },
    {
      name: "Mcleod Mueller",
      age: 32,
      country: "USA"
    },
    {
      name: "Day Meyers",
      age: 21,
      country: "HK"
    },
    {
      name: "Aguirre Ellis",
      age: 34,
      country: "UK"
    },
    {
      name: "Cook Tyson",
      age: 32,
      country: "USA"
    }
  ]

  currentDate = new Date()
}
