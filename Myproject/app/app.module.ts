import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import {GoogleChart} from './directives/angular2-google-chart.directive';
import { ChartsModule } from 'ng2-charts';
import { AppComponent }  from './app.component';

import {HttpModule} from '@angular/http';
import {Http} from '@angular/http';


import { MdlModule } from 'angular2-mdl';
@NgModule({
  imports: [ BrowserModule,
    FormsModule,
    MdlModule,HttpModule
    ],
  declarations: [ 
    AppComponent,GoogleChart
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
