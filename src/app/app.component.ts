import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  public toRoman(number: number): string {
    if (number == 4) {
      return 'IV';
    }

    if (number == 3) {
      return 'III';
    }

    if (number == 2) {
      return 'II';
    }

    if (number == 1) {
      return 'I';
    }

    return '';
  }
}
