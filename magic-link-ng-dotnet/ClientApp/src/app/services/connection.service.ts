import { LoginResponse, ConnectionRequest } from '../models/login';
import { ConnectionInfo } from './../models/connection';
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

const CONNECTION_INFO_TAG = "connectionInfo";

@Injectable({
  providedIn: 'root'
})
export class ConnectionService {
  public current: ConnectionInfo;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { 
    this.current = JSON.parse(localStorage.getItem(CONNECTION_INFO_TAG));
    if (!this.current) 
      this.current = new ConnectionInfo();
    else
      this.current.jwtToken = null; // should not be stored, but just in case
  }

  composeURL(path: string): string {
    if (this.current.isDebugEnv) {
      return `http://${this.current.rootURL}/${path}`;
    } else {
      return `https://${this.current.rootURL}/be/${path}`;
    }
  }

  getConnectionHeaders() {
    var today = new Date();
    return new HttpHeaders()
      .set("Authorization", JSON.stringify({
        Type:"JWT",
        SecurityValue: this.current.jwtToken
      }))
      .set("Server-Info", JSON.stringify({
        subscription: this.current.subscriptionKey,
        ui_culture: this.current.ui_culture,
        culture: this.current.culture,
        date : {
          day: today.getDate(),
          month: today.getMonth(),
          year: today.getFullYear()
        }
      }));
  }

  login(): Observable<Object> {
    var $login = new Observable<Object> ( observer => {
      var connectionRequest: ConnectionRequest = {
        rootURL: this.current.rootURL,
        isDebugEnv: this.current.isDebugEnv,
        accountName: this.current.accountName,
        password: this.current.password,
        subscriptionKey: this.current.subscriptionKey
      };
      this.http.post(this.baseUrl + "connection/login", connectionRequest).subscribe((data:LoginResponse) => {
        localStorage.setItem(CONNECTION_INFO_TAG, JSON.stringify(this.current));
        this.current.jwtToken = data.jwtToken;
        this.current.ui_culture = data.language;
        this.current.culture = data.regionalSettings;
        observer.next();
        observer.complete();        
      },
      (error) => {
        observer.error(`${error.status} - ${error.error} - ${error.message}`);
      });
    }) 
    return $login;
  }

  logout(): Observable<Object> {
    var $logout = new Observable<Object> ( observer => {
      // let headers = new HttpHeaders().set("Authorization", JSON.stringify({
      //   Type:"JWT",
      //   SecurityValue: this.current.jwtToken
      // }));
      // this.http.post(this.composeURL("account-manager/logoff"), { }, { headers: headers }).subscribe((data:any) => {
      //   this.current.jwtToken = null;
        observer.next();
        observer.complete(); 
    //   });
    });
    return $logout;
  }
}
