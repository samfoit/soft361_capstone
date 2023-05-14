import { Component, ElementRef, OnInit, Renderer2, ViewChild } from '@angular/core';
import { Card } from '../models/card.model';
import { SharedService } from '../services/shared.service';
import { CardChecker } from './card-checker';
import { CardPlacement } from './card-placement';
import { Deck } from './deck';

@Component({
  selector: 'app-solitaire',
  templateUrl: './solitaire.component.html',
  styleUrls: ['./solitaire.component.css']
})
export class SolitaireComponent implements OnInit {
  public deck: Card[];
  public cardRows: Card[][] = [];
  public drawPile: Card[] = [];
  public suiteStack: Card[][] = [[], [], [], []];
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
    this.deck = new Deck().shuffle(this.deck);
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

  // moves a card from deck to drawPile
  draw() {
    if (this.deck.length > 0) {
      const card = this.deck[this.deck.length - 1];
      this.drawPile.push(card);
      card.visible = true;
      this.deck.pop();
    } else {
      for (let i = this.drawPile.length - 1; i >= 0; i--) {
        this.deck.push(this.drawPile[i]);
      }

      this.drawPile = [];
    }
  }

  // (abstract)
  moveCardFromRow(card: Card, rowNum: number) {
    if (!card.visible) { return; }
    const placer = new CardPlacement();
    const checker = new CardChecker();

    if (checker.botRowCard(card, rowNum, this.cardRows)) {
      this.moveCard(card, rowNum);
    } else if (checker.topRowCard(card, rowNum, this.cardRows)) {
      const cardMovement = placer.placeCards(card, rowNum, this.cardRows);
      if (cardMovement != undefined) {
        this.cardRows = cardMovement;
        this.revealCard(rowNum);
      }
    }
  }

  // moves a card from the draw pile
  moveCardFromDraw(card: Card, rowNum: number) {
    this.moveCard(card, rowNum);
  }

  moveCard(card, rowNum) {
    const placer = new CardPlacement();
    let cardMovement = placer.stackSuites(card, rowNum, this.suiteStack);

    if (cardMovement != undefined) {
      this.suiteStack = cardMovement;
      this.revealCard(rowNum);
    } else {
      cardMovement = placer.placeCard(card, rowNum, this.cardRows);
      if (cardMovement != undefined) {
        this.cardRows = cardMovement;
        this.revealCard(rowNum);
      }
    }
  }

  // removes the moved card from proper stack and reveals the next card
  revealCard(rowNum: number) {
    if (rowNum > -1) {
      this.cardRows[rowNum].pop();

      if (this.cardRows[rowNum].length > 0)
      {
        const endOfRow = this.cardRows[rowNum].length - 1;
        this.cardRows[rowNum][endOfRow].visible = true;
      }
    } else {
      this.drawPile.pop();
    }
  }
}
