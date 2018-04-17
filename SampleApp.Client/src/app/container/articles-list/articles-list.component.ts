import { Component, OnInit } from '@angular/core';
import { ArticleModel, ArticleListService } from "app/container/articles-list/articles-list.service";

@Component({
    selector: 'articles-list',
    templateUrl: './articles-list.component.html',
    styleUrls: ['./articles-list.component.scss']
})
export class ArticleListComponent implements OnInit {

    data: Array<ArticleModel> = [];

    constructor(private articleListService: ArticleListService) { }

    ngOnInit() {
        this.getArticles();
    }

    public getArticles() {
        this.articleListService.getArticles().subscribe(res => {
            this.data = res;
        });
    }

}
