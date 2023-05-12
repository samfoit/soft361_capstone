import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-player',
  templateUrl: './player.component.html',
  styleUrls: ['./player.component.css']
})
export class PlayerComponent implements OnInit {
  @Input() name!: string;
  @Input() score!: number;
  @Input() card!: number;
  @Input() visible!: string;

  constructor() { }

  ngOnInit(): void {
  }

}
