import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { HouseService } from '../house.service';


@Component({
  selector: 'app-house-detail',
  templateUrl: './house-detail.component.html',
  styleUrls: ['./house-detail.component.css']
})
export class HouseDetailComponent implements OnInit {
  id: number;
  addressForm = this.fb.group({
    id: '',
    zip: ['', Validators.required],
    country: ['', Validators.required],
    city: ['', Validators.required], 
    street: ['', Validators.required],
    number: ['', [Validators.required, Validators.min(1)]],
  });

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private service: HouseService, 
    private fb: FormBuilder) {  }

  ngOnInit(): void {
    this.id = +this.route.snapshot.paramMap.get('id');

    this.service.getHouse(this.id)
      .subscribe(result => this.addressForm.patchValue(result));
  }

  goBack(): void {
    this.location.back();
  }

  onSubmit() {
    this.service.updateHouse(this.addressForm.value)
      .subscribe(result => this.addressForm.patchValue(result));
  }
}
