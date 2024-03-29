import { Component, OnInit }  from '@angular/core';
import { Router }             from '@angular/router';
import { LinkService }        from 'src/app/Services/Link.service';
import { GetLinkByCodeQuery } from '../../Queries/GetLinkByCodeQuery';

@Component({
  selector   : 'app-redirect',
  templateUrl: './redirect.component.html',
  styleUrls  : ['./redirect.component.css'],
})
export class RedirectComponent implements OnInit {
  constructor(private linkService: LinkService) {
    try {
      const code = window.location.pathname.substring(1);
      this.linkService
        .GetOriginalUrlByCode(code)
        .subscribe((result: string) => {
          window.location.href = result;
        });
    } catch (error) {
      console.error('Error occurred during redirection:', error); // Log any errors that occur
    }
  }

  ngOnInit() {}
}
