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
        return pairs.length >= 2 ? pairs[pairs.length - 1] : 0;

      case Category.TwoPairs:
        pairs = this.getPairs(roll);
        return pairs.length === 4 ? pairs[0] + pairs[2] : 0;

      case Category.ThreeOfAKind:
        return 0;
    }
  }

  private getPairs(roll: number[]): number[] {
    const pairs: number[] = [];
    roll.sort().forEach((value, index, sorted) => {
      sorted?.forEach((value2, index2) => {
        if (value === value2 && index !== index2) {
          pairs.push(value * 2);
        }
      });
    });

    return pairs;
  }
}
