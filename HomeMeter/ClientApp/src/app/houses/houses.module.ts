import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatSliderModule } from '@angular/material/slider';

import { HousesRoutingModule } from './houses-routing.module';
import { HousesDetailComponent } from './houses-detail/houses-detail.component';
import { HousesListComponent } from './houses-list/houses-list.component';


@NgModule({
  declarations: [
    HousesListComponent,
    HousesDetailComponent
  ],
  imports: [
    CommonModule,
    MatSliderModule,
    HousesRoutingModule
  ]
})
export class HousesModule { }
