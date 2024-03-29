import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LinkService } from '../Services/Link.service';
import { Observable, switchMap } from 'rxjs';
import { GetLinkByCodeQueryResult } from '../Queries/GetLinkByCodeQuery';

@Injectable()
export class ShortenUrlInterceptorService implements HttpInterceptor {
  constructor(private linkService: LinkService) {}

  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    // Check if the request is containing a short code in the URL
    const shortCode = req.url.split('/')[3];
    if (shortCode) {
      return this.linkService.GetByCode(shortCode).pipe(
        switchMap((result: GetLinkByCodeQueryResult) => {
          var fullRequest = req.clone({ url: result.originalUrl });
          return next.handle(fullRequest);
        })
      );
    } else {
      return next.handle(req);
    }
  }
}
