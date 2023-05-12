import { Component, OnInit } from '@angular/core';
import { SharedService } from '../services/shared.service';
import { Card } from '../models/card.model';
import { Player } from '../models/player-dto.model';
import * as deck from './deck';

@Component({
  selector: 'app-war-game',
  templateUrl: './war-game.component.html',
  styleUrls: ['./war-game.component.css']
})
export class WarGameComponent implements OnInit {
  public players;
  public deck;
  public game;

  public showingCards: boolean = false;

  constructor(private service: SharedService) { }

  ngOnInit(): void {
    this.startGame();
  }
  onPlayButtonClicked() {
    let d = new deck.deck();
    this.deck = d.shuffle(this.players, this.deck);
    this.showingCards = true;
    this.deck = d.flipCards(this.players, this.deck);
    setTimeout(() => {
      for (let i = 0; i < this.players.length; i++) {
        this.deck[i].visible = false;
      }
    }, 5000);
    this.showingCards = false;
    this.players = d.dealRound(this.players, this.deck);
    for (let i = 0; i < this.players.length; i++) {
      this.service.updatePlayer(this.players[i] as Player).subscribe(response => { console.log(response); });
    }
  }

  startGame() {
    this.service.getGameId().subscribe(response => {
      this.game = response;
      this.getPlayers();
    });
  }

  getPlayers() {
    this.service.getPlayers(this.game).subscribe(response => {
      this.players = response;
      this.getDeck();
    });
  }

  getDeck() {
    this.service.getDeck().subscribe(response => {
      this.deck = response;
    });
  }
}
