import { Component, OnInit } from '@angular/core';
import { UsersListService, UserModel } from 'app/container/users-list/users-list.service';

@Component({
    selector: 'users-list',
    templateUrl: './users-list.component.html',
    styleUrls: ['./users-list.component.scss']
})
export class UsersListComponent implements OnInit {

    data: Array<UserModel> = [];

    constructor(private userListService: UsersListService) { }

    ngOnInit() {
        this.getUsers();
    }

    public getUsers() {
        this.userListService.getUsers().subscribe(res => {
            this.data = res;
        });
    }

}
