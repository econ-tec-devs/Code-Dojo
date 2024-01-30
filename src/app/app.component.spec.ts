import { AppComponent } from './app.component';

describe('AppComponent', () => {
  let sut: AppComponent;

  beforeEach(() => {
    sut = new AppComponent();
  });

  test('toRoman_input0_returnEmptyString', () => {
    // Act
    const actual: string = sut.toRoman(0);

    // Assert
    expect(actual).toBe('');
  });

  test('toRoman_input1_returnI', () => {
    // Act
    const actual: string = sut.toRoman(1);

    // Assert
    expect(actual).toBe('I');
  });

  test('toRoman_input2_returnII', () => {
    // Act
    const actual: string = sut.toRoman(2);

    // Assert
    expect(actual).toBe('II');
  });

  test('toRoman_input3_returnIII', () => {
    // Act
    const actual: string = sut.toRoman(3);

    // Assert
    expect(actual).toBe('III');
  });

  test('toRoman_input4_returnIV', () => {
    // Act
    const actual: string = sut.toRoman(4);

    // Assert
    expect(actual).toBe('IV');
  });

  test('toRoman_input5_returnV', () => {
    // Act
    const actual: string = sut.toRoman(5);

    // Assert
    expect(actual).toBe('V');
  });

  test('toRoman_input6_returnVI', () => {
    // Act
    const actual: string = sut.toRoman(6);

    // Assert
    expect(actual).toBe('VI');
  });
});
