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
  public cardData: Card[];

  constructor(private httpClient: HttpClient, public service: SharedService) {}

  ngOnInit(): void {
    this.httpClient.get<Card[]>('https://localhost:7297/api/cards')
      .subscribe(response => {
        this.cardData = response;
        console.log(this.cardData);
      })
  }
}
