import { Component } from '@angular/core';
import { Category } from './models/category';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  public placeRollOnCategory(roll?: number[], category?: Category): number {
    if (roll === undefined || category === undefined) {
      return 0;
    }

    let returnValue = 0;
    const pairs: number[] = [];

    switch (category) {
      case Category.Ones:
        return roll.filter((dice) => dice === 1).length;
      case Category.Twos:
        return roll.filter((dice) => dice === 2).length * 2;

      case Category.Threes:
        return roll.filter((dice) => dice === 3).length * 3;

      case Category.Fours:
        return roll.filter((dice) => dice === 4).length * 4;

      case Category.Fives:
        return roll.filter((dice) => dice === 5).length * 5;

      case Category.Sixes:
        return roll.filter((dice) => dice === 6).length * 6;

      case Category.Pair:
        roll.sort().forEach((value, index) => {
          roll?.forEach((value2, index2) => {
            if (value === value2 && index !== index2) {
              returnValue = value * 2;
            }
          });
        });
        return returnValue;

      case Category.TwoPairs:
        roll.sort().forEach((value, index) => {
          roll?.forEach((value2, index2) => {
            if (value === value2 && index !== index2) {
              pairs.push(value * 2);
            }
          });
        });

        if (pairs.length === 4) {
          return pairs[0] + pairs[2];
        }

        return 0;

      case Category.ThreeOfAKind:
        return 0;
    }
  }
}
