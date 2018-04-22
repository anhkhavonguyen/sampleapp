import { Component, OnInit } from '@angular/core';
import { UserModel } from "app/container/users-list/users-list.service";


@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})

export class HomeComponent implements OnInit {

    currentUser: UserModel;

    constructor() {
        this.currentUser = JSON.parse(localStorage.getItem('currentUser'));
    }

    ngOnInit() {
    }
}