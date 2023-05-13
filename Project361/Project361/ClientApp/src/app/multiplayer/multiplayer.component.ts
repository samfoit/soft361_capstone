import { AbstractControl, ValidatorFn, FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PlayerDTO } from '../models/player.model';
import { SharedService } from '../services/shared.service';

// Custom validator to blacklist certain special characters.
export function forbiddenCharactersValidator(forbiddenChars: RegExp): ValidatorFn {
  return (control: AbstractControl): { [key: string]: any } | null => {
    const forbidden = forbiddenChars.test(control.value);
    return forbidden ? { 'forbiddenCharacters': { value: control.value } } : null;
  };
}

@Component({
  selector: 'app-multiplayer',
  templateUrl: './multiplayer.component.html',
  styleUrls: ['./multiplayer.component.css']
})
export class MultiplayerComponent implements OnInit {

  public multiplayerForm: FormGroup = new FormGroup({});
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
          username: new FormControl("", [Validators.required, Validators.minLength(1), forbiddenCharactersValidator(/[\0\x08\x09\x1a\n\r"'\\\%]/g)])
        })
      ])
    });
  }

  addPlayer() {
    const control = <FormArray>this.multiplayerForm.controls['players'];

    if (this.players < 8) {
      this.players++;
      control.push(new FormGroup({
        username: new FormControl("", [Validators.required, Validators.minLength(1), forbiddenCharactersValidator(/[\0\x08\x09\x1a\n\r"'\\\%]/g)]),
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
      this.displayPlayButton = true;
    } else {
      alert("Input not valid.\nAre you missing a name or using forbidden characters?");
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
