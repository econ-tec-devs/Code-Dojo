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
    [[5, 5, 1, 3, 3], Category.Pair, 10],
    [[5, 5, 1, 3, 2], Category.TwoPairs, 0],
    [[5, 5, 1, 3, 3], Category.TwoPairs, 16],
  ])(
    'placeRollOnCategory_testCase%#place%sOn%s_returns%s',
    (roll, category, expected) =>
      expect(new AppComponent().placeRollOnCategory(roll, category)).toBe(
        expected
      )
  );
});
