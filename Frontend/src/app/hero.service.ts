import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Hero } from './hero';

@Injectable({
  providedIn: 'root' //torna isto acessivel em toda a aplicacao
})
export class HeroService {
  private apiUrl = 'http://localhost:23828/Hero/AddHero';

  constructor(private http: HttpClient) { }

  addHero(hero: Hero): Observable<Hero> {
    return this.http.post<Hero>(this.apiUrl, hero);
  }
}