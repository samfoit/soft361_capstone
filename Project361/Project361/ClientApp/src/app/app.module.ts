import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CardComponent } from './card/card.component';
import { SolitaireComponent } from './solitaire/solitaire.component';
import { MultiplayerComponent } from './multiplayer/multiplayer.component';
import { WarGameComponent } from './war-game/war-game.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CardComponent,
    SolitaireComponent,
    MultiplayerComponent,
    WarGameComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'solitaire', component: SolitaireComponent },
      { path: 'multiplayer', component: MultiplayerComponent },
      { path: 'war', component: WarGameComponent}
    ])
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
