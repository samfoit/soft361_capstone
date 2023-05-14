import { Card } from '../models/card.model';
import { Player } from '../models/player-dto.model';
import { CardChecker } from './card-checker';

export class CardPlacement {
  public checker = new CardChecker();

  // finds a spot to place a top card and moves the entire stack (abstract)
  placeCards(card: Card, rowNum, cardRows: Card[][]) {
    const cardColor = this.checker.cardSuiteIsBlack(card.suite);

    for (const row of cardRows) {
      // if we find an empty row and the topCard is a King
      if (row.length == 0 && card.rank == 13) {
        let foundCard = false;
        let cardsPushed = 0;

        for (let i = 0; i < cardRows[rowNum].length; i++) {
          if (foundCard) {
            row.push(cardRows[rowNum][i]);
            cardsPushed++;
          }
          if (cardRows[rowNum][i].id == card.id) {
            foundCard = true;
            row.push(card);
            cardsPushed++;
          }
        }

        for (let i = 0; i < cardsPushed - 1; i++) {
          cardRows[rowNum].pop();
        }
        return cardRows;
      }

      // otherwise do a normal card stack placement
      if (row.length == 0) { continue; }
      const lastCard = row[row.length - 1];
      const lastCardColor = this.checker.cardSuiteIsBlack(lastCard.suite);

      if (lastCard.rank == (card.rank + 1) && lastCardColor != cardColor) {
        let foundCard = false;
        let cardsPushed = 0;

        for (let i = 0; i < cardRows[rowNum].length; i++) {
          if (foundCard) {
            row.push(cardRows[rowNum][i]);
            cardsPushed++;
          }
          if (cardRows[rowNum][i].id == card.id) {
            foundCard = true;
            row.push(card);
            cardsPushed++;
          }
        }

        for (let i = 0; i < cardsPushed - 1; i++) {
          cardRows[rowNum].pop();
        }
        return cardRows;
      }

    }

    return undefined;
  }

  // finds a spot to place a card (if any) and moves it there
  placeCard(card: Card, rowNum: number, cardRows: Card[][]) {
    const cardColor = this.checker.cardSuiteIsBlack(card.suite);

    for (const row of cardRows) {
      if (row.length == 0 && card.rank == 13) {
        row.push(card);
        return cardRows
      }

      if (row.length == 0) { continue; }

      const lastCard = row[row.length - 1];
      const lastCardColor = this.checker.cardSuiteIsBlack(lastCard.suite);

      if (lastCard.rank == (card.rank + 1) && lastCardColor != cardColor) {
        row.push(card);
        return cardRows;
      }
    }

    return undefined;
  }

  // moves a card to the suite stack if we can (ABSTRACT)
  stackSuites(card: Card, rowNum: number, suiteStack: Card[][]) {
    const suite = this.checker.suiteNum(card.suite);
    const lookingForCardNumber = suiteStack[suite].length + 1;

    if (card.rank == lookingForCardNumber) {
      suiteStack[suite].push(card);
      return suiteStack;
    }

    return undefined;
  }

}
