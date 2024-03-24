import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ShortenLinkCommand, ShortenLinkCommandResult } from '../Commands/ShortenLinkCommand';

@Injectable({
  providedIn: 'root',
})
export class LinkService {
  appUrl = 'http://localhost:5211/api/Links';

  constructor(private http: HttpClient) { }

  shorten(url: string) {
    var command = new ShortenLinkCommand(url);

    return this.http.post<ShortenLinkCommandResult>(this.appUrl+"/Create", command);
  }
}
