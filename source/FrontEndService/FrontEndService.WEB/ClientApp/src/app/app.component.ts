import { Component }                from '@angular/core';
import { ActivatedRoute, Router }   from '@angular/router';
import { LinkService }              from './Services/Link.service';
import { GetLinkByCodeQueryResult } from './Queries/GetLinkByCodeQuery';

@Component({
  selector   : 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent {
  title = 'app';

  constructor(

  ) {
    // this.route.url.subscribe(urlSegment => {
    //   if (urlSegment.length > 0) {
    //     const shortCode = urlSegment[0].path;
    //     this.redirectToOriginalUrl(shortCode);
    //   }
    //   else {
    //     alert('No short code provided');
    //   }
    // });
  }

  // redirectToOriginalUrl(shortCode: string) {
  //   this.linkService
  //     .GetByCode(shortCode)
  //     .subscribe((result: GetLinkByCodeQueryResult) => {
  //       window.location.href = result.originalUrl;
  //     });
  // }
}
