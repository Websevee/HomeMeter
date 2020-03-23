import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HousesRoutingModule } from './houses-routing.module';
import { HouseDetailComponent } from './house-detail/house-detail.component';
import { HousesListComponent } from './houses-list/houses-list.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { HouseCreateComponent } from './house-create/house-create.component';
import { MaterialModule } from '../material.module';
import { MetersModule } from '../meters/meters.module';


@NgModule({
  declarations: [
    HousesListComponent,
    HouseDetailComponent,
    HouseCreateComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    HousesRoutingModule,
    MetersModule
  ]
})
export class HousesModule { }
