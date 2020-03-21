import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HousesRoutingModule } from './houses-routing.module';
import { HousesDetailComponent } from './houses-detail/houses-detail.component';


@NgModule({
  declarations: [HousesDetailComponent],
  imports: [
    CommonModule,
    HousesRoutingModule
  ]
})
export class HousesModule { }
