import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ArticleListComponent } from "app/container/articles-list/articles-list.component";
import { UsersListComponent } from "app/container/users-list/users-list.component";
import { DashboardComponent } from 'app/container/dashboard/dashboard.component';
import { IconsComponent } from 'app/container/icons/icons.component';
import { MapsComponent } from 'app/container/maps/maps.component';
import { NotificationsComponent } from 'app/container/notifications/notifications.component';
import { TypographyComponent } from 'app/container/typography/typography.component';
import { UserProfileComponent } from 'app/container/user-profile/user-profile.component';
import { TableListComponent } from 'app/container/table-list/table-list.component';
import { UpgradeComponent } from 'app/container/upgrade/upgrade.component';

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
    ],
    declarations: [
        UsersListComponent,
        ArticleListComponent,
        DashboardComponent,
        IconsComponent,
        MapsComponent,
        NotificationsComponent,
        TableListComponent,
        TypographyComponent,
        UserProfileComponent,
        UpgradeComponent
    ],
    exports: [
        UsersListComponent,
        ArticleListComponent,
        DashboardComponent,
        IconsComponent,
        MapsComponent,
        NotificationsComponent,
        TableListComponent,
        TypographyComponent,
        UserProfileComponent,
        UpgradeComponent
    ]
})

export class ContainerModule { }