import { Card } from './card';

export class Deck {
  cards;

  constructor() {
    this.cards = [
      { id: 1, suit: "spades", rank: 1, visible: true },
      { id: 2, suit: "spades", rank: 2, visible: true },
      { id: 3, suit: "spades", rank: 3, visible: true },
      { id: 4, suit: "spades", rank: 4, visible: true },
      { id: 5, suit: "spades", rank: 5, visible: true },
      { id: 6, suit: "spades", rank: 6, visible: true },
    ];
  }

  shuffle() {
    for (let i = 0; i < this.cards.length; i++) {
      let j = Math.floor(Math.random() * (this.cards.length));
      console.log(j);

      [this.cards[i], this.cards[j]] = [this.cards[j], this.cards[i]];
    }

    return this.cards;
  }
}
