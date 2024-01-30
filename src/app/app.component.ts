import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  public toRoman(number: number): string {

    if (number == 9) {
      return 'IX';
    }

    if (number == 4) {
      return 'IV';
    }

    const tempX = number % 10;
    let result = '';
    if (tempX != number) {
      result += 'X';
      number = number - 10;
    }

    const tempV = number % 5;
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
