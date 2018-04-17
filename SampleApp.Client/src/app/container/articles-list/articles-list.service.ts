import { Injectable } from "@angular/core";
import { Observable } from "rxjs/Observable";
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class ArticleListService {
    private headers: HttpHeaders;
    private options: any;
    private url = 'http://localhost:63786/api/core/getArticles';

    constructor(private http: HttpClient) {
        this.headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        this.options = { headers: this.headers, withCredentials: true, observe: 'body' };
    }

    getArticles(): Observable<Array<ArticleModel>> {
        return this.http.get<Array<ArticleModel>>(this.url, ...this.options);
    }
}

export class ArticleModel {
    id: string;
    title: string;
    content: string;
}