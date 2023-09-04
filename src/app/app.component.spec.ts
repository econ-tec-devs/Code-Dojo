import { AppComponent } from './app.component';

describe('AppComponent', () => {
  test('ctor_called_returnsNewInstance', () => {
    expect(new AppComponent()).toBeTruthy();
  });
});
