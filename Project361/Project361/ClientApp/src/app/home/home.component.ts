import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Card } from '../models/card.model';
import { SharedService } from '../services/shared.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public cardData;

  constructor(public service: SharedService) {}

  ngOnInit(): void {
    this.getDeck();
  }

  getDeck() {
    this.service.getDeck()
      .subscribe(response => {
        this.setCardData(response);
      });
  }

  setCardData(data: any) {
    this.cardData = data;
  }

  createSolitaireGame() {
    
  }
}
