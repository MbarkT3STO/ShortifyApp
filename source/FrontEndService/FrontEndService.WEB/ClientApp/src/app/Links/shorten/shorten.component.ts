import { Component, OnInit }          from '@angular/core';
import { ShortenLinkCommand }         from 'src/app/Commands/ShortenLinkCommand';
import { ShortenLinkCommandResult }   from './../../Commands/ShortenLinkCommand';
import { LinkService as LinkService } from 'src/app/Services/Link.service';

@Component({
  selector   : 'app-shorten',
  templateUrl: './shorten.component.html',
  styleUrls  : ['./shorten.component.css']
})
export class ShortenComponent implements OnInit {

  public shortenUrlCommand: ShortenLinkCommand             = new ShortenLinkCommand("");
  public shortenUrlCommandResult: ShortenLinkCommandResult = new ShortenLinkCommandResult(0, "", "", new Date(), new Date(), true);

  constructor(private linkService: LinkService) { }

  ngOnInit() {
  }



  public clearUrlBox() {
    this.shortenUrlCommand.originalUrl = "";
  }


  public shorten(url: string) {
    this.linkService.shorten(url).subscribe(result => {
      this.shortenUrlCommandResult = result;
    });
  }


  public copyTheShortUrlToClipboard() {

    const element = document.getElementById("new-url-label") as HTMLDivElement;

    if (element) {
      const innerText = element.innerText;

      // Remove the "Your short URL: " part
      const textToCopy = innerText.substring(15);
      navigator.clipboard.writeText(textToCopy);
    }
  }


}
