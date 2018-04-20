import { NgModule } from '@angular/core';
import { CommonModule, } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { Routes, RouterModule } from '@angular/router';
import { UsersListComponent } from 'app/container/users-list/users-list.component';
import { ArticleListComponent } from "app/container/articles-list/articles-list.component";
import { DashboardComponent } from 'app/container/dashboard/dashboard.component';
import { TypographyComponent } from 'app/container/typography/typography.component';
import { UserProfileComponent } from 'app/container/user-profile/user-profile.component';
import { TableListComponent } from 'app/container/table-list/table-list.component';
import { IconsComponent } from 'app/container/icons/icons.component';
import { MapsComponent } from 'app/container/maps/maps.component';
import { UpgradeComponent } from 'app/container/upgrade/upgrade.component';
import { NotificationsComponent } from 'app/container/notifications/notifications.component';
import { HomeComponent } from 'app/home/home.component';
import { AuthGuard } from 'app/shared/services/auth.guard';

const routes: Routes = [
    { path: 'dashboard', component: DashboardComponent },
    { path: 'user-profile', component: UserProfileComponent },
    { path: 'table-list', component: TableListComponent },
    { path: 'typography', component: TypographyComponent },
    { path: 'icons', component: IconsComponent },
    { path: 'maps', component: MapsComponent },
    { path: 'notifications', component: NotificationsComponent },
    { path: 'upgrade', component: UpgradeComponent },
    { path: 'users-list', component: UsersListComponent },
    { path: 'articles-list', component: ArticleListComponent },
    { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
    { path: 'home', component: HomeComponent, canActivate: [AuthGuard] },
];

@NgModule({
    imports: [
        CommonModule,
        BrowserModule,
        RouterModule.forRoot(routes)
    ],
    exports: [
    ],
})
export class AppRoutingModule { }
