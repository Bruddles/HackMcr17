import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { MapComponent } from './components/map/map.component';
import { MorseComponent } from './components/morse/morse.component';
import { TestLocationComponent } from './components/testLocation/testLocation.component';
import { TwoDigitsPipe } from './pipes/two-digits.pipe';

import { locationServiceProvider } from './services/location/location.service.provider';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        MapComponent,
        MorseComponent,
        TestLocationComponent,
        TwoDigitsPipe
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'morse', pathMatch: 'full' },
            { path: 'map', component: MapComponent },
            { path: 'morse', component: MorseComponent },
            { path: '**', redirectTo: 'morse' }
        ])
    ],
    providers: [
        locationServiceProvider
    ]
})
export class AppModuleShared {
}
