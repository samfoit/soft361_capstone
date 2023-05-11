import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Card } from '../models/card.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  private cardsUrl: string = "https://localhost:7297/api/cards";

  constructor(private httpClient: HttpClient)
  {
  }

  public getDeck(): Observable<Card[]> {
    return this.httpClient.get<Card[]>(this.cardsUrl);
  }
}
