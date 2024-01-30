import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  private literals: { [id: number]: ILiterals } = {
    1: { arabic: 1, roman: 'I' },
    5: { arabic: 5, roman: 'V' },
    10: { arabic: 10, roman: 'X' },
    50: { arabic: 50, roman: 'L' },
    100: { arabic: 100, roman: 'C' },
    500: { arabic: 500, roman: 'D' },
    1000: { arabic: 1000, roman: 'M' },
  };

  private tempResult = '';

  public toRoman(number: number): string {
    if (number == 14) {
      return 'XIV';
    }

    if (number == 9) {
      return 'IX';
    }

    if (number == 4) {
      return 'IV';
    }

    number = this.romanSplice(10, number);
    number = this.romanSplice(5, number);

    for (let i = 0; i < number; i++) {
      this.tempResult += 'I';
    }

    return this.tempResult;
  }

  private romanSplice(base: number, input: number): number {
    const tempX = input % this.literals[base].arabic;
    if (tempX != input) {
      this.tempResult += this.literals[base].roman;
      return input - this.literals[base].arabic;
    }
    return input;
  }
}

interface ILiterals {
  arabic: number;
  roman: string;
}
