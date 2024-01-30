import { AppComponent } from './app.component';

describe('AppComponent', () => {
  test('ctor_called_returnsNewInstance', () => {
    // Arrange
    const sut = new AppComponent();

    // Act
    const actual: string = sut.toRoman(0);

    // Assert
    expect(actual).toBe('');
  });
});
