import { Injectable, Inject } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { Meter } from './meter';

@Injectable({
  providedIn: 'root'
})
export class MeterService {
  meterUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.meterUrl = baseUrl + 'api/Meter/';
  }

  getMeters(): Observable<Meter[]> {
    return this.http.get<Meter[]>(this.meterUrl)
      .pipe(catchError(this.handleError<Meter[]>('getMeters')));
  }

  getMeter(id: number): Observable<Meter> {
    return this.http.get<Meter>(this.meterUrl + id)
      .pipe(catchError(this.handleError<Meter>('getMeter')));
  }

  getHouseMeter(houseId: number): Observable<Meter> {
    return this.http.get<Meter>(this.meterUrl + 'House/' + houseId)
      .pipe(catchError(this.handleError<Meter>('getHouseMeter')));
  }

  deleteMeter(id: number) {
    return this.http.delete(this.meterUrl + id)
      .pipe(catchError(this.handleError<Meter>('deleteMeter')));
  }

  addMeter(meter: Meter): Observable<Meter> {
    return this.http.post<Meter>(this.meterUrl, meter)
      .pipe(catchError(this.handleError<Meter>('addMeter')));
  }

  updateMeter(meter: Meter): Observable<Meter> {
    return this.http.put<Meter>(this.meterUrl + meter.id, meter)
      .pipe(catchError(this.handleError<Meter>('updateMeter')));
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
