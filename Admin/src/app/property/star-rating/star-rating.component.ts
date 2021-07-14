import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-star-rating',
  templateUrl: './star-rating.component.html',
  styleUrls: ['./star-rating.component.css']
})
export class StarRatingComponent implements OnInit {

  checkedcolor!: "gold";
  uncheckedcolor!: "gray";
  size!: "24px";
  value!: 0;
  readonly!: false;
  totalstars!: 5
  constructor() { }

  ngOnInit() {
  }
  onRate($event:{oldValue:number, newValue:number, starRating:StarRatingComponent}) {
    alert(`Old Value:${$event.oldValue},
      New Value: ${$event.newValue},
      Checked Color: ${$event.starRating.checkedcolor},
      Unchecked Color: ${$event.starRating.checkedcolor}`);
  }
}
