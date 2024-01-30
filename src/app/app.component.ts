import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  public toRoman(number: number): string {
    if (number == 11) {
      return 'XI';
    }

    if (number == 10) {
      return 'X';
    }

    if (number == 9) {
      return 'IX';
    }

    if (number == 4) {
      return 'IV';
    }

    const tempV = number % 5;
    let result = '';
    if (tempV != number) {
      result += 'V';
      number = number - 5;
    }

    for (let i = 0; i < number; i++) {
      result += 'I';
    }

    return result;
  }
}
