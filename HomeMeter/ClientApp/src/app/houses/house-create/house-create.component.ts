import { Component, Inject, OnInit } from "@angular/core";
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

import { House } from "../house";
import { Validators, FormBuilder } from "@angular/forms";
import { HouseService } from "../house.service";

@Component({
    selector: 'house-create',
    templateUrl: 'house-create.component.html',
  })
  export class HouseCreateComponent implements OnInit {
    addressForm = this.fb.group({
        zip: ['', Validators.required],
        country: ['', Validators.required],
        city: ['', Validators.required], 
        street: ['', Validators.required],
        number: ['', [Validators.required, Validators.min(1)]],
    });
  
    constructor(
      public dialogRef: MatDialogRef<HouseCreateComponent>,
      @Inject(MAT_DIALOG_DATA) public data: House, 
      private fb: FormBuilder,
      private service: HouseService, 
      ) {}

    ngOnInit(): void {
    }
  
    onNoClick(): void {
      this.dialogRef.close();
    }
  
    onSubmit() {
        console.log(this.addressForm.value);
        this.service.addHouse(this.addressForm.value)
          .subscribe(() => this.onNoClick());
    }
}