import { Component, OnInit } from '@angular/core';
import { SharedService } from '../services/shared.service';
import { Card } from '../models/card.model';
import { Player } from '../models/player-dto.model';

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
    this.shuffle();
    this.flipCards();
    this.dealRound();
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

  shuffle() {
    for (let i = 0; i < this.players.length; i++) {
      let j = Math.floor(Math.random() * (this.deck.length));

      [this.deck[i], this.deck[j]] = [this.deck[j], this.deck[i]];
    }
  }

  flipCards() {
    this.showingCards = true;
    for (let i = 0; i < this.players.length; i++) {
      this.deck[i].visible = true;
    }

    setTimeout(() => {
      for (let i = 0; i < this.players.length; i++) {
        this.deck[i].visible = false;
      }
      this.showingCards = false;
    }, 5000);
  }

  dealRound() {
    let max = 0;

    for (let i = 0; i < this.players.length; i++) {
      if (this.deck[i].rank == 1) {
        max = 14;
      }
      if (this.deck[i].rank > max) {
        max = this.deck[i].rank;
      }
    }

    for (let i = 0; i < this.players.length; i++) {
      if (this.deck[i].rank == max || (max == 14 && this.deck[i].rank == 1)) {
        this.players[i].score += 1;
        console.log(this.players[i]);
        this.service.updatePlayer(this.players[i] as Player).subscribe(response => { console.log(response); });
        

        if (this.players[i].score >= 10) {
          alert(this.players[i].name + " wins!");
        }
      }
    }
  }
}
