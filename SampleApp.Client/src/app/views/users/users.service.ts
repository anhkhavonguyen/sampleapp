import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers, Request, RequestMethod } from '@angular/http';

@Injectable()
export class UsersService {

  apiUrl = 'localhost:4200/api';
  headers : Headers;
  requestoptions : RequestOptions;
  constructor(private http:Http) { 
    this.headers = new Headers();
    this.headers.append("Content-Type", 'application/json');
    //this.headers.append("Authorization", 'Bearer ' + localStorage.getItem('id_token'))
    
  }

  public getUser() : Array<UserModel>{
    // http.get('data.json')
    //   .subscribe((data)=> {
    //     setTimeout(()=> {
    //       this.data = data.json();
    //     }, 2000);
    //   });
    return [
        {
          id: '1',
          lastName: 'Vo',
          firstName: 'Kha',
          email: 'khavo@gmail.com',
          profile: {
            avatar: './assets/images/avatar/man.svg',
            dateOfBirth: null,
          }
        },
        {
          id: '2',
          lastName: 'Nguyen',
          firstName: 'Justin',
          email: 'justin@gmail.com',
          profile: {
            avatar: './assets/images/avatar/man.svg',
            dateOfBirth: null,
          }
        },
        {
          id: '3',
          lastName: 'Pham',
          firstName: 'Hung',
          email: 'Hung@gmail.com',
          profile: {
            avatar: './assets/images/avatar/man.svg',
            dateOfBirth: null,
          }
        }
      ];
  }

    public add(user:UserModel){
        this.requestoptions = new RequestOptions({
            method: RequestMethod.Post,
            url: this.apiUrl,
            headers: this.headers,
            body: JSON.stringify(user)
        })

        return this.http.request(new Request(this.requestoptions))
            .map((res: Response) => {
                if (res) {
                    return [{ status: res.status, json: res.json() }]
                }
            });
    }

    public edit(user:UserModel){
        this.requestoptions = new RequestOptions({
            method: RequestMethod.Post,
            url: this.apiUrl,
            headers: this.headers,
            body: JSON.stringify(user)
        })

        return this.http.request(new Request(this.requestoptions))
            .map((res: Response) => {
                if (res) {
                    return [{ status: res.status, json: res.json() }]
                }
            });
    }

    public delete(userId:string){
        const url = this.apiUrl + '/delete/' + userId;
        return this.http.delete(url).map((res: Response) => {
            if (res) {
                return [{ status: res.status, json: res.json() }]
            }
        });
    }
}

export class UserModel{
    id:string;
    firstName:string;
    lastName:string;
    email:string;
    profile :
    {
        avatar:string;
        dateOfBirth:Date;
    }
}