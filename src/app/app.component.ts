import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  public toRoman(number: number): string {
    let tempV = number % 5;
    let result = "";

    if (number == 9) {
      return 'IX';
    }

    if (tempV != number) {
      result += "V";
      number = number - 5;
    }

    if (number == 4) {
      return 'IV';
    }

    for (let i = 0; i < number; i++) {
      result += 'I';
    }

    return result;
  }
}
