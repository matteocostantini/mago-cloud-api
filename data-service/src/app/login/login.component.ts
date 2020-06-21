import { ConnectionService } from './../services/connection.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(
    public connection: ConnectionService,
    private router: Router
  ) { }

  ngOnInit() {
  }

  onLogin() {
    this.connection.login().subscribe(() => {
      this.router.navigate(['contacts-list'])
    });
  }
  onLogout() {
    this.connection.logout().subscribe(() => {

    });
  }
}
