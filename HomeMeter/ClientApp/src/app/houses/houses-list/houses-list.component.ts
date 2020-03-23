import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';

import { HouseService } from '../house.service';
import { House } from '../house';
import { HouseCreateComponent } from '../house-create/house-create.component';



@Component({
  selector: 'app-houses-list',
  templateUrl: './houses-list.component.html',
  styleUrls: ['./houses-list.component.css']
})
export class HousesListComponent implements OnInit {
  houses$: Observable<House[]>;


  constructor(
    private service: HouseService, 
    private router: Router,
    public dialog: MatDialog
  ) { }

  ngOnInit() {
    this.getHouses();
  }

  showCreateHouse(): void {
    const dialogRef = this.dialog.open(HouseCreateComponent, {
      data: {
        id: undefined, 
        zip: undefined, 
        country: undefined, 
        city: undefined,
        street: undefined,
        number: undefined
      }
    });

    dialogRef.afterClosed()
      .subscribe(() => this.getHouses());
  }

  detailHouse(id: number): void {
    this.router.navigateByUrl('/house/' + id);
  }

  getHouses(): void {
    this.houses$ = this.service.getHouses();
  }

  deleteHouse(id: number): void {
    this.service.deleteHouse(id)
      .subscribe({ complete: () => this.getHouses()});
  }

  addHouse(house: House): void {
    this.service.addHouse(house)
      .subscribe({ complete: () => this.getHouses()});
  }

  showMaxReadingHouse(revert: boolean = false): void {
    this.service.getMaxReadingHouse(revert)
      .subscribe(result => {if (result) alert(JSON.stringify(result))});
  }
}
