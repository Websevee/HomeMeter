import { Component, OnInit, Input } from '@angular/core';
import { Validators, FormBuilder } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { MeterService } from '../meter.service';
import { Meter } from '../meter';

@Component({
  selector: 'app-meter-detail',
  templateUrl: './meter-detail.component.html',
  styleUrls: ['./meter-detail.component.css']
})
export class MeterDetailComponent implements OnInit {
  @Input() houseId: number;

  meterForm = this.fb.group({
    id: 0,
    serialNumber: ['', Validators.required, Validators.min(0)],
    readings: ['', [Validators.required, Validators.min(0)]],
    houseId: null
  });

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private service: MeterService, 
    private fb: FormBuilder) {  }

  ngOnInit(): void {
    if (this.houseId)
    {
      this.service.getHouseMeter(this.houseId)
        .subscribe(result => {if (result) this.meterForm.patchValue(result)});
    }
  }

  goBack(): void {
    this.location.back();
  }

  onSubmit() {
    let value = this.meterForm.value;
    value.houseId = this.houseId;

    if (!value.id) {
      value.id = 0
      this.addMeter(value);
    }
    else this.updateMeter(value);
  }

  addMeter(meter: Meter): void {
    this.service.addMeter(meter)
      .subscribe(result => this.meterForm.patchValue(result));
  }

  updateMeter(meter: Meter): void {
    this.service.updateMeter(meter)
      .subscribe(result => this.meterForm.patchValue(meter));
  }

  deleteMeter(id): void {
    this.service.deleteMeter(id)
      .subscribe({ complete: () => {
        this.meterForm.reset();
        this.meterForm.value.houseId = this.houseId;
      } });
  }
}
