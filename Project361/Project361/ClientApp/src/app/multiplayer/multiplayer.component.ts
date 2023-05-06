import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators, ReactiveFormsModule, FormsModule } from '@angular/forms';

@Component({
  selector: 'app-multiplayer',
  templateUrl: './multiplayer.component.html',
  styleUrls: ['./multiplayer.component.css']
})
export class MultiplayerComponent implements OnInit {

  public multiplayerForm: FormGroup = new FormGroup({
  });
  players?: number;

  constructor() { }

  ngOnInit(): void {
    this.createForm();
    this.players = 1;
    this.addPlayer();
  }

  createForm() {
    this.multiplayerForm = new FormGroup({
      players: new FormArray([
        new FormGroup({
          username: new FormControl("")
        })
      ])
    });
  }

  addPlayer() {
    const control = <FormArray>this.multiplayerForm.controls['players'];

    if (this.players < 8) {
      this.players++;
      control.push(new FormGroup({
        username: new FormControl(""),
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

}
