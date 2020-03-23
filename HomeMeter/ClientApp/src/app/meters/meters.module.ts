import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MeterDetailComponent } from './meter-detail/meter-detail.component';
import { MaterialModule } from '../material.module';




@NgModule({
  declarations: [MeterDetailComponent],
  imports: [
    CommonModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  exports: [
    MeterDetailComponent
  ]
})
export class MetersModule { }
