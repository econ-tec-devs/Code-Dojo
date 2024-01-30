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
    number = this.romanSpliceUp(10, number);
    number = this.romanSpliceDown(10, number);

    number = this.romanSpliceUp(5, number);
    number = this.romanSpliceDown(5, number);

    for (let i = 0; i < number; i++) {
      this.tempResult += 'I';
    }

    return this.tempResult;
  }

  /**
   * Handles upward splicing for roman literals like "V" as decimal 5 or "XI" as decimal 11.
   * @param base decimal base which should be used for splicing while conversion to roman
   * @param input integer value which should be converted to roman
   * @returns returns updated (rest) integer value
   */
  private romanSpliceUp(base: number, input: number): number {
    const tempX = input % this.literals[base].arabic;
    if (tempX != input) {
      this.tempResult += this.literals[base].roman;
      return input - this.literals[base].arabic;
    }
    return input;
  }

  /**
   * Handles downward splicing for roman literals like "IV" as decimal 4 or "IX" as decimal 9.
   * @param base decimal base which should be used for splicing while convertion to roman
   * @param input integer value which should be converted to roman
   * @returns returns updated (rest) integer value
   */
  private romanSpliceDown(base: number, input: number): number {
    const temp = input % this.literals[base].arabic;
    if (temp == this.literals[base].arabic - 1) {
      this.tempResult += `I${this.literals[base].roman}`;
      input = input - temp;
    }
    return input;
  }
}

interface ILiterals {
  arabic: number;
  roman: string;
}
