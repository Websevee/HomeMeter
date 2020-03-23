import { Injectable, Inject } from '@angular/core';
import { Observable, throwError, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import { House } from './house';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class HouseService {
  houseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.houseUrl = baseUrl + 'api/House/';
  }

  getHouses(): Observable<House[]> {
    return this.http.get<House[]>(this.houseUrl)
      .pipe(catchError(this.handleError<House[]>('getHouses')));
  }

  getHouse(id: number): Observable<House> {
    return this.http.get<House>(this.houseUrl + id)
      .pipe(catchError(this.handleError<House>('getHouse')));
  }

  getMaxReadingHouse(revert: boolean = false): Observable<House> {
    return this.http.get<House>(this.houseUrl + "MaxReading", { params: { revert: revert ? 'true' : 'false' }})
      .pipe(catchError(this.handleError<House>('getMaxReadingHouse')));
  }

  deleteHouse(id: number) {
    return this.http.delete(this.houseUrl + id)
      .pipe(catchError(this.handleError<House>('deleteHouse')));
  }

  addHouse(house: House): Observable<House> {
    return this.http.post<House>(this.houseUrl, house)
      .pipe(catchError(this.handleError<House>('addHouse')));
  }

  updateHouse(house: House): Observable<House> {
    return this.http.put<House>(this.houseUrl + house.id, house)
      .pipe(catchError(this.handleError<House>('updateHouse')));
  }


  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      
      console.error(error); // log to console instead
      alert('Error!\n' + error.message);
  
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}