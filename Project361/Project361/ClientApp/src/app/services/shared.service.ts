import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.prod';
import { Card } from '../models/card.model';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  private accessPoint: string = "https://localhost:7297/api/cards";

  constructor(private httpClient: HttpClient)
  {
  }

  public getAllCards() {
    return this.httpClient.get(this.accessPoint);
  }
}
