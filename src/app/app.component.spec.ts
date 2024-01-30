import { AppComponent } from './app.component';

describe('AppComponent', () => {
  test('toRoman_input0_returnEmptyString', () => {
    // Arrange
    const sut = new AppComponent();

    // Act
    const actual: string = sut.toRoman(0);

    // Assert
    expect(actual).toBe('');
  });

  test('toRoman_input1_returnI', () => {
    // Arrange
    const sut = new AppComponent();

    // Act
    const actual: string = sut.toRoman(1);

    // Assert
    expect(actual).toBe('I');
  });
});
