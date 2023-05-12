import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Card } from '../models/card.model';
import { Observable } from 'rxjs';
import API_ENDPOINTS from 'src/app/constants/APIEndpoints';
import HTTP_OPTIONS from 'src/app/constants/HttpOptions';
import { Player } from '../models/player-dto.model';
import { PlayerDTO } from '../models/player.model';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  private headers: HttpHeaders;

  constructor(private httpClient: HttpClient) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

  public getDeck(): Observable<Card[]> {
    return this.httpClient.get<Card[]>(API_ENDPOINTS.GET_DECK);
  }

  public getGameId() {
    return this.httpClient.get(API_ENDPOINTS.GET_GAME_ID);
  }

  public getPlayers(gameId: number): Observable<Player[]> {
    return this.httpClient.get<Player[]>(API_ENDPOINTS.GET_PLAYERS + `${gameId}`);
  }

  public updatePlayer(playerToUpdate: Player) {
    return this.httpClient.put(API_ENDPOINTS.UPDATE_PLAYER + playerToUpdate.id, playerToUpdate, HTTP_OPTIONS);
  }

  public postPlayer(playerToAdd: PlayerDTO) {
    return this.httpClient.post(API_ENDPOINTS.CREATE_PLAYER, playerToAdd, { headers: this.headers });
  }
}
