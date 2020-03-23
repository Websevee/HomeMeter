import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HousesListComponent } from './houses-list/houses-list.component';
import { HouseDetailComponent } from './house-detail/house-detail.component';


const routes: Routes = [
  { path: 'houses', component: HousesListComponent },
  { path: 'house/:id', component: HouseDetailComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HousesRoutingModule { }
