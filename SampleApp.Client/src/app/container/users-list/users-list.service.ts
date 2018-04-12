import { Injectable } from "@angular/core";
import { Observable } from "rxjs/Observable";
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class UsersListService {
    private headers: HttpHeaders;
    private options: any;
    private url = 'http://localhost:63786/api/core';

    constructor(private http: HttpClient) {
        this.headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        this.options = { headers: this.headers, withCredentials: true, observe: 'body' };
    }

    getUsers(): Observable<Array<UserModel>> {
        return this.http.get<Array<UserModel>>(this.url, ...this.options);
    }
}

export class UserModel {
    id: string;
    firstName: string;
    lastName: string;
}