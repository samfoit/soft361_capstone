import { Card } from "../models/card.model";

export class Deck {
  shuffle(cards: Card[]) {
    for (let i = 0; i < cards.length; i++) {
      let j = Math.floor(Math.random() * (cards.length));

      [cards[i], cards[j]] = [cards[j], cards[i]];
    }

    return cards;
  }
}
