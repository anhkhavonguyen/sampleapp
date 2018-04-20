import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app.routing';

import { ComponentsModule } from './components/components.module';
import { ContainerModule } from "app/container/container.module";

import { AppComponent } from './app.component';

import { UsersListService } from 'app/container/users-list/users-list.service';
import { ArticleListService } from "app/container/articles-list/articles-list.service";
import { HomeComponent } from 'app/home/home.component';
import { AuthenticationService } from 'app/shared/services/authentication.service';
import { AuthGuard } from 'app/shared/services/auth.guard';

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        ComponentsModule,
        HttpClientModule,
        RouterModule,
        AppRoutingModule,
        ContainerModule
    ],
    providers: [UsersListService, ArticleListService, AuthenticationService, AuthGuard],
    bootstrap: [AppComponent]
})
export class AppModule { }
