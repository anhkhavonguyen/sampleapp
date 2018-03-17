import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// DataTable
import { DataTableModule } from 'angular2-datatable';
import { HttpModule } from '@angular/http';
import { DataFilterPipe } from './datafilterpipe';
import { FormsModule } from '@angular/forms';

import { UsersComponent } from './users.component';

//Routing
import { DatatableRoutingModule } from './datatable-routing.module';
//
@NgModule({
  imports: [
    DatatableRoutingModule,
    CommonModule,
    DataTableModule,
    FormsModule,
    HttpModule
  ],
  declarations: [
    UsersComponent,
    DataFilterPipe
  ]
})
export class DatatableInitModule { }
