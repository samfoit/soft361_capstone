import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Dealer } from './dealer';
import { Card } from '../models/card.model';
import { Player } from '../models/player-dto.model';


//unit testing in ts
//https://www.youtube.com/watch?v=ZYIKU1TQ_0g 
//https://youtu.be/z9ZAxe8hPw4
describe('deck component', () => {
  let DECK: Card[];
  let PLAYERS: Player[];
  let component: deck;
  beforeEach(() => {
    DECK = [{
      id: 0, rank: 1, suite: "Spades", visible: false,
    },
      {
        id: 1, rank: 2, suite: "Spades", visible: false,
      },
      {
        id: 2, rank: 3, suite: "Spades", visible: false,
      },
      {
        id: 3, rank: 4, suite: "Spades", visible: false,
      },
      {
        id: 4, rank: 5, suite: "Spades", visible: false,
      },
      {
        id: 5, rank: 6, suite: "Spades", visible: false,
      }];
    PLAYERS = [{
      id: 0, gameId: 0, name: "Sam", score: 0,
    },
      {
        id: 2, gameId: 0, name: "Chris", score: 0,
      },
      {
        id: 3, gameId: 0, name: "Aden", score: 0,
      },
      {
        id: 4, gameId: 0, name: "Indigo", score: 0,
      },
      {
        id: 5, gameId: 0, name: "Pranav", score: 0,
      },
    ];
    component = new deck();

  });

  describe('shuffle', () => {
    it('should shuffle the deck'), () => {
      component.shuffle(PLAYERS, DECK);
      expect(component.shuffle.length).toBe(5);
    }
  });

  describe('flipCards', () => {
    it('should flip all of the cards'), () => {
      component.flipCards(PLAYERS, DECK);
      for (let i = 0; i < PLAYERS.length; i++){
        expect(component.flipCards[i].visible).toBe(true);
      } 
    }
  });

  describe('dealRound', () => {
    it('give each player a card and then add one to the score of the player with the highest card value'), () => {
      component.dealRound(PLAYERS, DECK);
      let score = 0;
      for (let i = 0; i < PLAYERS.length; i++) {
        score += component.dealRound[i].score;
      }
      expect(score).toBeGreaterThan(0);
    }
  });
});



