import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

// Services
import { LinkService } from './Services/Link.service';

// Components
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ShortenComponent } from './Links/shorten/shorten.component';
import { RedirectComponent } from './Links/redirect/redirect.component';


// Http Interceptors
import { ShortenUrlInterceptorService } from './HTTP-Interceptors/ShortenUrlInterceptor.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ShortenComponent,
    RedirectComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      // { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'shorten', component: ShortenComponent },
      { path: 'redirect', component: RedirectComponent },
      { path: ':shortCode', component: RedirectComponent}
    ])
  ],
  providers: [
    LinkService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
