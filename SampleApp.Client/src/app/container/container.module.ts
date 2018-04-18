import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ArticleListComponent } from "app/container/articles-list/articles-list.component";
import { UsersListComponent } from "app/container/users-list/users-list.component";

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
    ],
    declarations: [
        UsersListComponent,
        ArticleListComponent
    ],
    exports: [
        UsersListComponent,
        ArticleListComponent
    ]
})

export class ContainerModule { }