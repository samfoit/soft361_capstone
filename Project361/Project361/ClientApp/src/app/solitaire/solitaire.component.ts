import { Component, ElementRef, OnInit, Renderer2, ViewChild } from '@angular/core';
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
  public cardRows: Card[][] = [];
  @ViewChild('rows') rowHolder!: ElementRef;
  
  constructor(private renderer: Renderer2) {
  }

  ngOnInit(): void {
    this.shuffle();
    this.dealCards();
  }

  ngAfterViewInit(): void {
    this.renderRows();
  }

  shuffle() {
    this.deck = this.playingCards.shuffle();
  }

  // arbitrary function that returns an array of cards and deletes them from the top
  dealCards() {
    // create an array of cards for each row pulling from deck then push it to cardRows
    let cardsDealt: number = 0;

    for (let i = 1; i < 8; i++) {
      let stack: Card[] = [];
      for (let j = 0; j < i; j++) {
        let index = this.deck.length - 1 - cardsDealt;
        stack.push(this.deck[index]);
        cardsDealt++;
      }

      this.cardRows.push(stack);
    }

    for (let i = 0; i < 28; i++) {
      this.deck.pop();
    }

    console.log(this.cardRows);
  }

  renderRows() {
    for (const row of this.rowHolder.nativeElement.children) {
      let cards: HTMLCollection = row.children;

      for (let i = 0; i < cards.length; i++) {
        this.renderer.setStyle(cards[i], 'position', 'absolute');
        this.renderer.setStyle(cards[i], 'top', 25 * i + 'px');
      }
    }
  }
}
