import { Injectable, ErrorHandler } from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders} from '@angular/common/http'; 
import { Observable } from 'rxjs';
import { DataItem } from './data-item';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  /*
  private _baseUrl: string = "http://localhost:27251/api/";

  constructor(private _httpClient: HttpClient) {  }

  getAllItem(): Observable<any[]>{
    // s2: 
    return this._httpClient.get<any[]>(this._baseUrl + "event");
  }

  getItemById(id) {
    return this._httpClient.get(this._baseUrl + "event/" + id)
  }

  addUpdateItem(data: DataItem): Observable<any> {
    if (data.ID > 0) {
        return this._httpClient.put<any>(this._baseUrl + "event/", data, {
            headers: new HttpHeaders({
                'Content-Type': 'Application/json'
            })
        });
    }
    return this._httpClient.post<any>(this._baseUrl + "event", data, {            
        headers: new HttpHeaders({
            'Content-Type': 'Application/json'
        })
    });
}

deleteByID(id): Observable<void> {
  return this._httpClient.delete<void>(this._baseUrl + "Color/" + id)
}
*/


baseUrl: string;
constructor(private _httpClient: HttpClient) {
    this.baseUrl = `http://${location.hostname}:57087/api/`
}
getAllEvent(): Observable<DataItem[]> {
    return this._httpClient.get<DataItem[]>(this.baseUrl + "event");
}
save(data: DataItem): Observable<DataItem> {
    if (data.id > 0) {
        return this._httpClient.put<DataItem>(this.baseUrl + "event/" + data.id, data, {
            headers: new HttpHeaders({
                'Content-Type': 'Application/json'
            })
        });
    }
    return this._httpClient.post<DataItem>(this.baseUrl + "event", data, {            
        headers: new HttpHeaders({
            'Content-Type': 'Application/json'
        })
    });
}
getEventById(id) {
    return this._httpClient.get(this.baseUrl + "event/" + id)
}
deleteEventById(id): Observable<void> {
    return this._httpClient.delete<void>(this.baseUrl + "event/" + id)
}




}
