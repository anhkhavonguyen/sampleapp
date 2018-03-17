import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TablesComponent } from './tables.component';

const routes: Routes = [
  {
    path: '',
    data: {
      title: 'Users Management'
    },
    children: [
      {
        path: 'usersdatatable',
        loadChildren: './usersdatatable/datatable.module#DatatableInitModule'
      },
      {
        path: 'tables',
        component: TablesComponent,
        data: {
          title: 'Tables'
        }
      },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TablesRoutingModule {}
