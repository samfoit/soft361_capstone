import { Component, OnInit } from '@angular/core';
import { SharedService } from '../services/shared.service';
import { Card } from '../models/card.model';
import { Player } from '../models/player-dto.model';

@Component({
  selector: 'app-war-game',
  templateUrl: './war-game.component.html',
  styleUrls: ['./war-game.component.css']
})

export class deck {

  shuffle(players, deck) {
    for (let i = 0; i < players.length; i++) {
      let j = Math.floor(Math.random() * (deck.length));

      [deck[i], deck[j]] = [deck[j], deck[i]];
    }
    return deck;
  }

  flipCards(players, deck) {
    for (let i = 0; i < players.length; i++) {
      deck[i].visible = true;
    }
    return deck;
  }

  dealRound(players, deck) {
    let max = 0;

    for (let i = 0; i < players.length; i++) {
      if (deck[i].rank == 1) {
        max = 14;
      }
      if (deck[i].rank > max) {
        max = deck[i].rank;
      }
    }
    
    for (let i = 0; i < players.length; i++) {
      if (deck[i].rank == max || (max == 14 && deck[i].rank == 1)) {
        players[i].score += 1;
        console.log(players[i]);

        if (players[i].score >= 10) {
          alert(players[i].name + " wins!");
        }
      }
    }
    return players;
  }
}
