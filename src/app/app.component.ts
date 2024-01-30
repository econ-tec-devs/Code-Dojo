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

    if (number == 8) {
      return 'VIII';
    }

    if (number == 7) {
      return 'VII';
    }

    if (number == 6) {
      return 'VI';
    }

    if (number == 5) {
      return 'V';
    }

    if (number == 4) {
      return 'IV';
    }

    let result = '';
    for (let i = 0; i < number; i++) {
      result += 'I';
    }

    return result;
  }
}
