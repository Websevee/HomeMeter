import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import { House } from './house';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class HouseService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  getHouses(): Observable<House[]> {
    return this.http.get<House[]>(this.baseUrl + 'api/House');
  }
}