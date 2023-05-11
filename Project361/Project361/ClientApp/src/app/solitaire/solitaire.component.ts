import { Component, ElementRef, OnInit, Renderer2, ViewChild } from '@angular/core';
import { Deck } from '../deck';
import { Card } from '../models/card.model';
import { SharedService } from '../services/shared.service';

@Component({
  selector: 'app-solitaire',
  templateUrl: './solitaire.component.html',
  styleUrls: ['./solitaire.component.css']
})
export class SolitaireComponent implements OnInit {
  public deck: Card[];
  public cardRows: Card[][] = [];
  @ViewChild('rows') rowHolder!: ElementRef;
  
  constructor(public service: SharedService) {
  }

  ngOnInit(): void {
    this.getDeck();
  }

  // gets the deck from the database
  getDeck() {
    this.service.getDeck()
      .subscribe(response => {
        this.manageDeck(response);
      });
  }

  // handles the deck once it's pulled from the db
  manageDeck(data: any) {
    this.deck = data;
    console.log(this.deck.length);
    this.shuffle();
    this.dealCards();
  }

  // transfers the cards from the deck to the cardRows
  dealCards() {
    let cardsDealt: number = 0;

    for (let i = 1; i < 8; i++) {
      let stack: Card[] = [];
      for (let j = 0; j < i; j++) {
        let index = this.deck.length - 1 - cardsDealt;
        if ((i - 1) == j) {
          this.deck[index].visible = true;
        }
        stack.push(this.deck[index]);
        cardsDealt++;
      }

      this.cardRows.push(stack);
    }

    for (let i = 0; i < 28; i++) {
      this.deck.pop();
    }
  }

  // randomizes the deck
  shuffle() {
    for (let i = 0; i < this.deck.length; i++) {
      let j = Math.floor(Math.random() * (this.deck.length));

      [this.deck[i], this.deck[j]] = [this.deck[j], this.deck[i]];
    }

    return this.deck;
  }
}
