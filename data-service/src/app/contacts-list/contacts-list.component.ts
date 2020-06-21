import { ConnectionService } from './../services/connection.service';
import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { VirtualTimeScheduler } from 'rxjs';

@Component({
  selector: 'app-contacts-list',
  templateUrl: './contacts-list.component.html',
  styleUrls: ['./contacts-list.component.css']
})
export class ContactsListComponent implements OnInit {

  public contacts = [];

  constructor(
    public connection: ConnectionService,
    private http: HttpClient
  ) { }

  ngOnInit() {
  }

  onList() {
    let headers = new HttpHeaders().set("Authorization", JSON.stringify({
          Type:"JWT",
          SecurityValue: this.connection.current.jwtToken
    }));
    this.http.get(this.connection.composeURL("data-service/getdata/ERP.Contacts.Dbl.ContactsByType/code"), { headers }).subscribe( (data:any) => {
      this.contacts = data.rows;
    },
    (error: any) => {
      console.log(error);
    });
  }
}
