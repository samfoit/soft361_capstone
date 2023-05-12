import { HttpResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators, ReactiveFormsModule, FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { PlayerDTO } from '../models/player.model';
import { SharedService } from '../services/shared.service';

@Component({
  selector: 'app-multiplayer',
  templateUrl: './multiplayer.component.html',
  styleUrls: ['./multiplayer.component.css']
})
export class MultiplayerComponent implements OnInit {

  public multiplayerForm: FormGroup = new FormGroup({
  });
  players?: number;

  public newGameId;
  public displayPlayButton: boolean = false;

  constructor(private router: Router, private service: SharedService) { }

  ngOnInit(): void {
    this.createForm();
    this.players = 1;
    this.addPlayer();
    this.getGameId();
  }

  createForm() {
    this.multiplayerForm = new FormGroup({
      players: new FormArray([
        new FormGroup({
          username: new FormControl("", [Validators.required, Validators.minLength(1)])
        })
      ])
    });
  }

  addPlayer() {
    const control = <FormArray>this.multiplayerForm.controls['players'];

    if (this.players < 8) {
      this.players++;
      control.push(new FormGroup({
        username: new FormControl("", [Validators.required, Validators.minLength(1)]),
      }));
    }
  }

  removePlayer() {
    if (this.players > 2) {
      const control = <FormArray>this.multiplayerForm.controls['players'];
      control.removeAt(control.length - 1);

      this.players--;
    }
  }

  getGameId() {
    this.service.getGameId().subscribe(id => {
      this.newGameId = id;
      this.newGameId++;
    });
  }

  onSubmit() {
    if (this.multiplayerForm.valid) {
      for (const player of this.multiplayerForm.value.players) {
        let newPlayer = { gameId: this.newGameId, name: player.username, score: 0 } as PlayerDTO;
        this.postPlayer(newPlayer);
      }
      // this.multiplayerForm.reset();
      this.displayPlayButton = true;
    } else {
      alert("Input not valid.\nAre you missing a name?");
    }
  }

  warLink() {
    this.router.navigate(['/war']);
  }

  postPlayer(player: PlayerDTO) {
    this.service.postPlayer(player).subscribe(response => {
      console.log(response);
    });
  }

}
