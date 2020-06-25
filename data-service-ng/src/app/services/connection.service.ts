import { LoginResponse } from './../models/login-response';
import { ConnectionInfo } from './../models/connection';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

const CONNECTION_INFO_TAG = "connectionInfo";

@Injectable({
  providedIn: 'root'
})
export class ConnectionService {
  public current: ConnectionInfo;

  constructor(private http: HttpClient) { 
    this.current = JSON.parse(localStorage.getItem(CONNECTION_INFO_TAG));
    if (!this.current) 
      this.current = new ConnectionInfo();
    else
      this.current.jwtToken = null; // should not be stored, but just in case
  }

  composeURL(path: string): string {
    return `https://${this.current.rootURL}/be/${path}`;
  }

  login(): Observable<Object> {
    var $login = new Observable<Object> ( observer => {
      var loginRequest = {
        accountName: this.current.accountName,
        password: this.current.password,
        overwrite: false,
        subscriptionKey: this.current.subscriptionKey,
        appId: "Mobile"
      };
      this.http.post(this.composeURL("account-manager/login"), loginRequest).subscribe((data:LoginResponse) => {
        localStorage.setItem(CONNECTION_INFO_TAG, JSON.stringify(this.current));
        this.current.jwtToken = data.JwtToken;
        observer.next();
        observer.complete();        
      });
    }) 
    return $login;
  }

  logout(): Observable<Object> {
    var $logout = new Observable<Object> ( observer => {
      this.current.jwtToken = null;
      observer.next();
      observer.complete(); 
    });
    return $logout;
  }
}
