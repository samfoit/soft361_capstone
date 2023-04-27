import { Card } from './card';

export class Deck {
  cards;

  constructor() {
    this.cards = [
      { id: 1, suit: "spades", rank: 1, visible: false },
      { id: 2, suit: "spades", rank: 2, visible: false },
      { id: 3, suit: "spades", rank: 3, visible: false },
      { id: 4, suit: "spades", rank: 4, visible: false },
      { id: 5, suit: "spades", rank: 5, visible: false },
      { id: 6, suit: "spades", rank: 6, visible: false },
      { id: 7, suit: "spades", rank: 7, visible: false },
      { id: 8, suit: "spades", rank: 8, visible: false },
      { id: 9, suit: "spades", rank: 9, visible: false },
      { id: 10, suit: "spades", rank: 10, visible: false },
      { id: 11, suit: "spades", rank: 11, visible: false },
      { id: 12, suit: "spades", rank: 12, visible: false },
      { id: 13, suit: "spades", rank: 13, visible: false },
      { id: 14, suit: "hearts", rank: 1, visible: false },
      { id: 15, suit: "hearts", rank: 2, visible: false },
      { id: 16, suit: "hearts", rank: 3, visible: false },
      { id: 17, suit: "hearts", rank: 4, visible: false },
      { id: 18, suit: "hearts", rank: 5, visible: false },
      { id: 19, suit: "hearts", rank: 6, visible: false },
      { id: 20, suit: "hearts", rank: 7, visible: false },
      { id: 21, suit: "hearts", rank: 8, visible: false },
      { id: 22, suit: "hearts", rank: 9, visible: false },
      { id: 23, suit: "hearts", rank: 10, visible: false },
      { id: 24, suit: "hearts", rank: 11, visible: false },
      { id: 25, suit: "hearts", rank: 12, visible: false },
      { id: 26, suit: "hearts", rank: 13, visible: false },
      { id: 27, suit: "clubs", rank: 1, visible: false },
      { id: 28, suit: "clubs", rank: 2, visible: false },
      { id: 29, suit: "clubs", rank: 3, visible: false },
      { id: 30, suit: "clubs", rank: 4, visible: false },
      { id: 31, suit: "clubs", rank: 5, visible: false },
      { id: 32, suit: "clubs", rank: 6, visible: false },
      { id: 33, suit: "clubs", rank: 7, visible: false },
      { id: 34, suit: "clubs", rank: 8, visible: false },
      { id: 35, suit: "clubs", rank: 9, visible: false },
      { id: 36, suit: "clubs", rank: 10, visible: false },
      { id: 37, suit: "clubs", rank: 11, visible: false },
      { id: 38, suit: "clubs", rank: 12, visible: false },
      { id: 39, suit: "clubs", rank: 13, visible: false },
      { id: 40, suit: "diamonds", rank: 1, visible: false },
      { id: 41, suit: "diamonds", rank: 2, visible: false },
      { id: 42, suit: "diamonds", rank: 3, visible: false },
      { id: 43, suit: "diamonds", rank: 4, visible: false },
      { id: 44, suit: "diamonds", rank: 5, visible: false },
      { id: 45, suit: "diamonds", rank: 6, visible: false },
      { id: 46, suit: "diamonds", rank: 7, visible: false },
      { id: 47, suit: "diamonds", rank: 8, visible: false },
      { id: 48, suit: "diamonds", rank: 9, visible: false },
      { id: 49, suit: "diamonds", rank: 10, visible: false },
      { id: 50, suit: "diamonds", rank: 11, visible: false },
      { id: 51, suit: "diamonds", rank: 12, visible: false },
      { id: 52, suit: "diamonds", rank: 13, visible: false },
    ];
  }

  shuffle() {
    for (let i = 0; i < this.cards.length; i++) {
      let j = Math.floor(Math.random() * (this.cards.length));

      [this.cards[i], this.cards[j]] = [this.cards[j], this.cards[i]];
    }

    return this.cards;
  }
}
