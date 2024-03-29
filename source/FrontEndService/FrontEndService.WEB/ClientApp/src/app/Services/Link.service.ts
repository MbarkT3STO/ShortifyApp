import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ShortenLinkCommand, ShortenLinkCommandResult } from '../Commands/ShortenLinkCommand';
import { map, Observable } from 'rxjs';
import { GetLinkByCodeQueryResult } from '../Queries/GetLinkByCodeQuery';

@Injectable({
  providedIn: 'root',
})
export class LinkService {
  appUrl = 'http://localhost:5211/api/Links';

  constructor(private http: HttpClient) { }

  /**
   * Shortens a given URL by sending a POST request to the server with the URL wrapped in a ShortenLinkCommand object.
   * @param {string} url - The URL to be shortened.
   * @return {Observable<ShortenLinkCommandResult>} - An Observable of type ShortenLinkCommandResult containing the result of the request.
   */
  shorten(url: string): Observable<ShortenLinkCommandResult> {
    var command = new ShortenLinkCommand(url);

    return this.http.post<ShortenLinkCommandResult>(this.appUrl+"/Create", command);
  }

  /**
   * Retrieves a link by its code from the server.
   *
   * @param {string} code - The short code of the link to retrieve.
   */
  GetByCode(code: string): Observable<GetLinkByCodeQueryResult> {
    return this.http.get<GetLinkByCodeQueryResult>(this.appUrl + "/Get/" + code);
  }


  GetOriginalUrlByCode(code: string): Observable<string> {
    return this.GetByCode(code).pipe(map((result: GetLinkByCodeQueryResult) => result.originalUrl));
  }

}
