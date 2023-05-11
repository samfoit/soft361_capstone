import { HttpClient, HttpHandler } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Card } from './models/card.model';
import { SharedService } from './services/shared.service';


@Injectable({
  providedIn: 'root',
})
export class Deck {
  public cards: Card[];

  constructor(public service: SharedService) {
    this.service.getDeck()
      .subscribe(response => {
        this.setCards(response);
      });
  }

  setCards(data: any) {
    this.cards = data;
    console.log(data[0].Rank);
  }

  shuffle() {
    for (let i = 0; i < this.cards.length; i++) {
      let j = Math.floor(Math.random() * (this.cards.length));

      [this.cards[i], this.cards[j]] = [this.cards[j], this.cards[i]];
    }

    return this.cards;
  }
}
