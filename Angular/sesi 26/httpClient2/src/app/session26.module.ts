import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {HttpClientModule} from '@angular/common/http'
import { Session26Component } from './session26/session26.component';

import { Session26RoutingModule } from './session26-routing.module';


@NgModule({
  declarations: [
    Session26Component
  ],
  imports: [
    CommonModule,
    Session26RoutingModule,
    HttpClientModule
  ]
})
export class Session26Module { }
