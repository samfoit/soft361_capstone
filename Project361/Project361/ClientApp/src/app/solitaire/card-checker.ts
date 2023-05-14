import { Card } from '../models/card.model';
import { Player } from '../models/player-dto.model';

export class CardChecker {
  constructor() { }
  // returns the suite number Spades = 0, Hearts = 1, Clubs = 2, Diamonds = 3 (ABSTRACT)
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
  topRowCard(card: Card, stackNumber: number, cardRows: Card[][]) {
    const row: Card[] = cardRows[stackNumber];

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
  botRowCard(card: Card, stackNumber: number, cardRows: Card[][]) {
    const row: Card[] = cardRows[stackNumber];

    for (let i = 0; i < row.length; i++) {
      if (row[i].id == card.id && (i + 1) == row.length) {
        return true;
      }
    }

    return false;
  }
}
