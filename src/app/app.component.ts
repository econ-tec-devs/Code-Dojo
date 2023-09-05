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

    let pairs: number[] = [];

    switch (category) {
      case Category.Ones:
      case Category.Twos:
      case Category.Threes:
      case Category.Fours:
      case Category.Fives:
      case Category.Sixes:
        return roll.filter((dice) => dice === category).length * category;

      case Category.Pair:
        pairs = this.getPairs(roll);
        return pairs.length >= 1 ? pairs[pairs.length - 1] : 0;

      case Category.TwoPairs:
        pairs = this.getPairs(roll);
        return pairs.length === 2 ? pairs[0] + pairs[1] : 0;

      case Category.ThreeOfAKind:
        return this.getAmountOfAKind(roll, 3);

      case Category.FourOfAKind:
        return this.getAmountOfAKind(roll, 4);

      case Category.SmallStraight:
        return JSON.stringify(roll.sort()) === '[1,2,3,4,5]' ? 15 : 0;
    }
  }

  private getPairs(roll: number[]): number[] {
    const pairs: number[] = [];
    roll.sort().forEach((value, index, sorted) => {
      if (value === sorted[index + 1]) {
        pairs.push(value * 2);
      }
    });

    return pairs;
  }

  private getAmountOfAKind(roll: number[], amount: number): number {
    let returnValue = 0;
    roll.forEach((value) => {
      if (roll.filter((value2) => value === value2).length >= amount) {
        returnValue = value * amount;
      }
    });

    return returnValue;
  }
}
