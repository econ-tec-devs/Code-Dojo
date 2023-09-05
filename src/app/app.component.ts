import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  private readonly url: string =
    'https://petstore3.swagger.io/api/v3/pet/findByStatus?status=available';

  constructor(private readonly httpClient: HttpClient) {}

  public loadByXMLHttpRequest(): void {
    const xhr = new XMLHttpRequest();
    xhr.onload = (): void => console.log(xhr.response);
    xhr.open('GET', this.url, true);
    xhr.send();

    console.log('loadByXMLHttpRequest');
  }

  public loadByFetch(): void {
    const response = fetch(this.url);
    response.then((response) => console.log(response.text()));

    console.log('loadByFetch');
  }

  public loadByHttpClient(): void {
    this.httpClient
      .get(this.url)
      .subscribe((response) => console.log(response));

    console.log('loadByObservable');
  }
}
