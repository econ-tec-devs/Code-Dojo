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

  test('toRoman_input2_returnII', () => {
    // Arrange
    const sut = new AppComponent();

    // Act
    const actual: string = sut.toRoman(2);

    // Assert
    expect(actual).toBe('II');
  });

  test('toRoman_input3_returnIII', () => {
    // Arrange
    const sut = new AppComponent();

    // Act
    const actual: string = sut.toRoman(3);

    // Assert
    expect(actual).toBe('III');
  });
});
