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

  // called when 
  moveCardFromRow(card: Card, rowNum: number) {
    if (!card.visible) { return; }

    if (this.botRowCard(card, rowNum)) {
      this.placeCard(card, rowNum);
    } else if (this.topRowCard(card, rowNum)) {
      this.placeCards(card, rowNum);
    }
  }

  // finds a spot to place a top card and moves the entire stack
  placeCards(card: Card, rowNum) {
    const cardColor = this.cardSuiteIsBlack(card.suite);

    for (const row of this.cardRows) {
      // if we find an empty row and the topCard is a King
      if (row.length == 0 && card.rank == 13) {
        let foundCard = false;
        let cardsPushed = 0;

        for (let i = 0; i < this.cardRows[rowNum].length; i++) {
          if (foundCard) {
            row.push(this.cardRows[rowNum][i]);
            cardsPushed++;
          }
          if (this.cardRows[rowNum][i].id == card.id) {
            foundCard = true;
            row.push(card);
            cardsPushed++;
          }
        }

        for (let i = 0; i < cardsPushed; i++) {
          this.cardRows[rowNum].pop();
        }
        this.revealCard(rowNum);
        return;
      }

      // otherwise do a normal card stack placement
      if (row.length == 0) { continue; }
      const lastCard = row[row.length - 1];
      const lastCardColor = this.cardSuiteIsBlack(lastCard.suite);

      if (lastCard.rank == (card.rank + 1) && lastCardColor != cardColor) {
        let foundCard = false;
        let cardsPushed = 0;

        for (let i = 0; i < this.cardRows[rowNum].length; i++) {
          if (foundCard) {
            row.push(this.cardRows[rowNum][i]);
            cardsPushed++;
          }
          if (this.cardRows[rowNum][i].id == card.id) {
            foundCard = true;
            row.push(card);
            cardsPushed++;
          }
        }

        for (let i = 0; i < cardsPushed; i++) {
          this.cardRows[rowNum].pop();
        }
        this.revealCard(rowNum);
        return;
      }
      
    }
  }

  // finds a spot to place a card (if any) and moves it there
  placeCard(card: Card, rowNum: number) {
    // if we are able to stack a card in the suite pile we return
    if (this.stackSuites(card, rowNum)) { return; }

    const cardColor = this.cardSuiteIsBlack(card.suite);

    for (const row of this.cardRows) {
      // push king to an empty row
      if (row.length == 0 && card.rank == 13) {
        row.push(card);
        this.revealCard(rowNum);
        return;
      }

      if (row.length == 0) { continue; }

      const lastCard = row[row.length - 1];
      const lastCardColor = this.cardSuiteIsBlack(lastCard.suite);

      if (lastCard.rank == (card.rank + 1) && lastCardColor != cardColor) {
        row.push(card);
        this.revealCard(rowNum);
        return;
      }
    }
  }

  // moves a card to the suite stack if we can
  stackSuites(card: Card, rowNum: number) {
    const suite = this.suiteNum(card.suite);
    const lookingForCardNumber = this.suiteStack[suite].length + 1;

    if (card.rank == lookingForCardNumber) {
      this.suiteStack[suite].push(card);
      this.revealCard(rowNum);
      return true;
    }

    return false;
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

  // returns the suite number Spades = 0, Hearts = 1, Clubs = 2, Diamonds = 3
  suiteNum(suite: string) {
    if (suite == "Spades") {
      return 0;
    } else if (suite == "Hearts") {
      return 1;
    } else if (suite == "Clubs") {
      return 2;
    } else if (suite == "Diamonds") {
      return 3;
    }

    return -1;
  }

  // returns true if suite color is black, false if suite color is red
  cardSuiteIsBlack(suite: string) {
    if (suite == "Spades" || suite == "Clubs") {
      return true;
    }

    return false;
  }

  // checks if the card is the top visible of the row
  topRowCard(card: Card, stackNumber: number) {
    const row: Card[] = this.cardRows[stackNumber];

    for (let i = 0; i < row.length; i++) {
      if (row[i].visible) {
        if (row[i].id == card.id) {
          return true;
        } else {
          break;
        }
      }
    }

    return false;
  }

  // checks if the card is the bottom of the row
  botRowCard(card: Card, stackNumber: number) {
    const row: Card[] = this.cardRows[stackNumber];

    for (let i = 0; i < row.length; i++) {
      if (row[i].id == card.id && (i + 1) == row.length) {
        return true;
      }
    }

    return false;
  }
}
