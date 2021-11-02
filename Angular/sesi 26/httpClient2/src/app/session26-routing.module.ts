import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SigninComponent } from 'src/app/components/signin/signin.component';
import { SignupComponent } from 'src/app/components/signup/signup.component';
import { UserProfileComponent } from 'src/app/components/user-profile/user-profile.component';
import { MovieComponent } from './components/movie/movie.component';
import { StudioComponent } from './components/studio/studio.component';
import { Session26Component } from './session26/session26.component';

const routes: Routes = [
  {
    path: 'session26', 
  component: Session26Component,
    children: [
      {path: 'login', component: SigninComponent},
      {path: 'signup', component: SignupComponent},
      {path: 'user/:id', component: UserProfileComponent},
      {path: 'movies', component: MovieComponent},
      {path: 'studios', component: StudioComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class Session26RoutingModule { }
