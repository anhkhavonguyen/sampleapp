import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { UsersService, UserModel } from 'app/views/users/users.service';

@Component({
  templateUrl: 'users.component.html',
  providers:[UsersService]
})
export class UsersComponent {

  public data : Array<UserModel>;
  public filterQuery = '';

  constructor(private usersService : UsersService) {
    
  }

  ngOnInit(){
    this.data = this.usersService.getUser();
  }

  public toInt(num:string) {
    return +num;
  }

  public sortByWordLength = (a:any) => {
    return a.name.length;
  }

  public add(user:UserModel){
    console.log(user);
    //this.data.push(user);
    //this.usersService.add(user);
  }

  public edit(user:UserModel){
    console.log(user);
    this.usersService.edit(user);
  }

  public delete(userId:string){
    let index = this.data.findIndex(item => item.id === userId);
    if (index !== -1) {
        this.data.splice(index, 1);
    }  
    // this.usersService.delete(userId).subscribe(res=>{

    // });
  }
}
