import { Component, OnInit } from '@angular/core';
import { SharedService } from '../services/shared.service';
import { Card } from '../models/card.model';

@Component({
  selector: 'app-war-game',
  templateUrl: './war-game.component.html',
  styleUrls: ['./war-game.component.css']
})
export class WarGameComponent implements OnInit {
  constructor() { }

  ngOnInit(): void {
  }
  onPlayButtonClicked() {
    alert("You clicked the play button");
  }
}
