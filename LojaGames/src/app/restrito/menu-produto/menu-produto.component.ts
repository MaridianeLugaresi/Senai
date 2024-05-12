import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from 'src/app/login.service';

@Component({
  selector: 'app-menu-restrito',
  templateUrl: './menu-produto.component.html',
  styleUrls: ['./menu-produto.component.css']
})
export class MenuRestritoComponent {

  constructor( private _router: Router,private _loginService:LoginService){}  

  logout(){
    localStorage.clear();
    this._loginService.setMostraMenu(true);
    this._router.navigate(['/login']);
  }
}