import { AppComponent } from './app.component';

describe('AppComponent', () => {
  let sut: AppComponent;

  beforeEach(() => {
    sut = new AppComponent();
  });

  test.each([
    [0, ''],
    [1, 'I'],
    [2, 'II'],
    [3, 'III'],
    [4, 'IV'],
    [5, 'V'],
    [6, 'VI'],
    [7, 'VII'],
    [8, 'VIII'],
  ])('toRoman_input(%s)_return(%s)', (input, result) => {
    // Act
    const actual: string = sut.toRoman(input);

    // Assert
    expect(actual).toBe(result);
  });
});
