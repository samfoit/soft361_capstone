import { Routes, RouterModule } from '@angular/router';

import { CardComponent } from './card/card.component';
import { SolitaireComponent } from './solitaire/solitaire.component';

const routes: Routes = [
  // you should have 4 components home, solitaire, multiplayer_create, and war
  // {path: '', component: HomeComponent},
  // {path: 'solitaire', component: SolitaireComponent},
  // {path: 'multiplayer', component: MultiplayerComponent},
  // {path: 'wargame', component: WarGameComponent}
];

export const appRoutingModule = RouterModule.forRoot(routes);
