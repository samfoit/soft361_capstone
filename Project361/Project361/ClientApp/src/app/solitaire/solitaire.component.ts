import { Component, OnInit } from '@angular/core';
import { Card } from '../card';
import { Deck } from '../deck';

@Component({
  selector: 'app-solitaire',
  templateUrl: './solitaire.component.html',
  styleUrls: ['./solitaire.component.css']
})
export class SolitaireComponent implements OnInit {
  public playingCards: Deck = new Deck();

  public deck: Card[] = this.playingCards.cards;
  
  constructor() {
  }

  ngOnInit(): void {
    this.shuffle();
  }

  shuffle() {
    this.deck = this.playingCards.shuffle();
  }
}
