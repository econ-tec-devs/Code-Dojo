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

    switch (category) {
      case Category.Ones:
      case Category.Twos:
      case Category.Threes:
      case Category.Fours:
      case Category.Fives:
      case Category.Sixes:
        return roll.filter((dice) => dice === category).length * category;

      case Category.Pair:
        return this.getSumOfHighestPair(roll);

      case Category.TwoPairs:
        return this.getSumOfAllPairs(roll);

      case Category.ThreeOfAKind:
        return this.getAmountOfAKind(roll, 3);

      case Category.FourOfAKind:
        return this.getAmountOfAKind(roll, 4);

      case Category.SmallStraight:
        return this.getStraight(roll, '[1,2,3,4,5]', 15);

      case Category.LargeStraight:
        return this.getStraight(roll, '[2,3,4,5,6]', 20);

      case Category.FullHouse:
        if (
          this.getPairs(roll).length === 2 &&
          this.getAmountOfAKind(roll, 3)
        ) {
          return roll.reduce((acc, cur) => acc + cur);
        }

        return 0;

      case Category.Yahtzee:
        return this.getAmountOfAKind(roll, 5) === 0 ? 0 : 50;

      case Category.Chance:
        return roll.reduce((acc, cur) => acc + cur);
    }
  }

  private getSumOfHighestPair(roll: number[]): number {
    const pairs = this.getPairs(roll);

    return pairs.length >= 1 ? pairs[pairs.length - 1] : 0;
  }

  private getSumOfAllPairs(roll: number[]): number {
    const pairs = this.getPairs(roll);

    return pairs.length === 2 ? pairs[0] + pairs[1] : 0;
  }

  private getPairs(roll: number[]): number[] {
    type GroupBy = {
      1: number;
      2: number;
      3: number;
      4: number;
      5: number;
      6: number;
    };

    const groupedNumbers: GroupBy = {
      1: 0,
      2: 0,
      3: 0,
      4: 0,
      5: 0,
      6: 0,
    };

    for (const num of roll) {
      groupedNumbers[num as keyof GroupBy]++;
    }

    const pairs: number[] = [];
    for (let i = 1; i <= 6; i++) {
      if (groupedNumbers[i as keyof GroupBy] > 1) {
        pairs.push(i * 2);
      }
    }

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

  private getStraight(
    roll: number[],
    straight: string,
    result: number
  ): number {
    return JSON.stringify(roll.sort()) === straight ? result : 0;
  }
}
