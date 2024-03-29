import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';
import { LinkService }       from 'src/app/Services/Link.service';

@Component({
  selector   : 'app-redirect',
  templateUrl: './redirect.component.html',
  styleUrls  : ['./redirect.component.css'],
})
export class RedirectComponent implements OnInit {
  constructor(private linkService: LinkService) {
    try {
      const code      = window.location.pathname.substring(1);
      const googleUrl = `https://www.google.com/search?q=${code}`;
      console.log('Redirecting to:', googleUrl); // Check if this log appears in the console
      window.location.href = googleUrl;
    } catch (error) {
      console.error('Error occurred during redirection:', error); // Log any errors that occur
    }
  }

  ngOnInit() {
  }
}
