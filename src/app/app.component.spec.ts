import { AppComponent } from './app.component';
import { Category } from './models/category';

describe('AppComponent', () => {
  test.each([
    [undefined, undefined, 0],
    [undefined, Category.Ones, 0],
    [[1, 2, 3, 4, 5], undefined, 0],
    [[6, 2, 3, 4, 5], Category.Ones, 0],
    [[1, 2, 3, 4, 5], Category.Ones, 1],
    [[1, 2, 3, 4, 1], Category.Ones, 2],
    [[1, 6, 3, 4, 5], Category.Twos, 0],
    [[1, 2, 3, 4, 5], Category.Twos, 2],
    [[1, 2, 3, 4, 2], Category.Twos, 4],
    [[1, 2, 6, 4, 5], Category.Threes, 0],
    [[1, 2, 3, 4, 5], Category.Threes, 3],
    [[1, 2, 3, 4, 3], Category.Threes, 6],
    [[1, 2, 3, 6, 5], Category.Fours, 0],
    [[1, 2, 3, 4, 5], Category.Fours, 4],
    [[1, 2, 3, 4, 4], Category.Fours, 8],
    [[1, 4, 1, 2, 4], Category.Fives, 0],
    [[1, 4, 1, 2, 5], Category.Fives, 5],
    [[1, 4, 1, 5, 5], Category.Fives, 10],
    [[1, 4, 1, 5, 5], Category.Sixes, 0],
    [[1, 4, 1, 5, 6], Category.Sixes, 6],
    [[1, 4, 1, 6, 6], Category.Sixes, 12],
    [[1, 2, 3, 4, 5], Category.Pair, 0],
    [[1, 3, 3, 4, 5], Category.Pair, 6],
    [[1, 3, 3, 3, 5], Category.Pair, 6],
    [[5, 5, 1, 3, 3], Category.Pair, 10],
    [[5, 3, 5, 3, 3], Category.Pair, 10],
    [[5, 5, 1, 3, 2], Category.TwoPairs, 0],
    [[5, 5, 1, 3, 3], Category.TwoPairs, 16],
    [[5, 1, 3, 5, 3], Category.TwoPairs, 16],
    [[1, 1, 1, 5, 3], Category.TwoPairs, 0],
    [[5, 1, 3, 2, 3], Category.ThreeOfAKind, 0],
    [[5, 1, 3, 3, 3], Category.ThreeOfAKind, 9],
    [[3, 3, 3, 3, 3], Category.ThreeOfAKind, 9],
    [[1, 2, 3, 3, 3], Category.FourOfAKind, 0],
    [[1, 3, 3, 3, 3], Category.FourOfAKind, 12],
    [[3, 3, 3, 3, 3], Category.FourOfAKind, 12],
    [[3, 3, 3, 3, 3], Category.SmallStraight, 0],
    [[1, 2, 3, 4, 5], Category.SmallStraight, 15],
    [[1, 2, 3, 4, 5], Category.LargeStraight, 0],
    [[2, 3, 4, 5, 6], Category.LargeStraight, 20],
    [[2, 3, 4, 5, 6], Category.FullHouse, 0],
    [[1, 1, 4, 4, 4], Category.FullHouse, 14],
    [[1, 1, 1, 4, 5], Category.FullHouse, 0],
    [[6, 1, 6, 1, 6], Category.FullHouse, 20],
    [[1, 1, 1, 1, 2], Category.Yahtzee, 0],
    [[1, 1, 1, 1, 1], Category.Yahtzee, 50],
    [[1, 2, 3, 4, 5], Category.Chance, 15],
  ])(
    'placeRollOnCategory_testCase%#place%sOn%s_returns%s',
    (roll, category, expected) =>
      expect(new AppComponent().placeRollOnCategory(roll, category)).toBe(
        expected
      )
  );
});
