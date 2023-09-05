import { Component } from '@angular/core';
import { Category } from './models/category';
import { GroupBy } from './models/group-by';

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
        return this.getSumOfADigit(roll, category);

      case Category.Pair:
        return this.getSumOfHighestPair(roll);

      case Category.TwoPairs:
        return this.getSumOfAllPairs(roll);

      case Category.ThreeOfAKind:
        return this.getSumOfAKind(roll, 3);

      case Category.FourOfAKind:
        return this.getSumOfAKind(roll, 4);

      case Category.SmallStraight:
        return this.getStraight(roll, '[1,2,3,4,5]');

      case Category.LargeStraight:
        return this.getStraight(roll, '[2,3,4,5,6]');

      case Category.FullHouse:
        return this.getFullHouse(roll);

      case Category.Yahtzee:
        return this.getYahtzee(roll);

      case Category.Chance:
        return this.getSumOfAllDice(roll);
    }
  }

  private getSumOfADigit(roll: number[], category: Category): number {
    return roll.filter((dice) => dice === category).length * category;
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
    const groupedNumbers = this.getGroupedNumbers(roll);

    const pairs: number[] = [];
    for (let key = 1; key <= 6; key++) {
      if (groupedNumbers[key as keyof GroupBy] > 1) {
        pairs.push(key * 2);
      }
    }

    return pairs;
  }

  private getGroupedNumbers(roll: number[]): GroupBy {
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

    return groupedNumbers;
  }

  private getSumOfAKind(roll: number[], amount: number): number {
    let returnValue = 0;
    roll.forEach((value) => {
      if (roll.filter((value2) => value === value2).length >= amount) {
        returnValue = value * amount;
      }
    });

    return returnValue;
  }

  private getStraight(roll: number[], straight: string): number {
    return JSON.stringify(roll.sort()) === straight
      ? this.getSumOfAllDice(roll)
      : 0;
  }

  private getFullHouse(roll: number[]): number {
    if (this.getPairs(roll).length === 2 && this.getSumOfAKind(roll, 3)) {
      return this.getSumOfAllDice(roll);
    }

    return 0;
  }

  private getYahtzee(roll: number[]): number {
    return this.getSumOfAKind(roll, 5) === 0 ? 0 : 50;
  }

  private getSumOfAllDice(roll: number[]): number {
    return roll.reduce((acc, cur) => acc + cur);
  }
}
