import { Component, OnInit } from '@angular/core';
import { HouseService } from '../house.service';
import { House } from '../house';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-houses-list',
  templateUrl: './houses-list.component.html',
  styleUrls: ['./houses-list.component.css']
})
export class HousesListComponent implements OnInit {
  houses$: Observable<House[]>;


  constructor(private service: HouseService) { }

  ngOnInit() {
    this.houses$ = this.service.getHouses();
  }

}
