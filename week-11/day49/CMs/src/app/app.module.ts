import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { AppComponent } from "./app.component";
import{contactcomponent} from "./components/contact";
import { Phone } from "./pipes/phone";
import { Status } from "./pipes/status";
import { Search } from "./pipes/serach";
@NgModule({
    declarations:[
        AppComponent,
        contactcomponent,
        Phone,
        Status,
        Search
    ],
    imports:[
        BrowserModule,
        FormsModule
    ],
    bootstrap:[AppComponent]
})
export class AppModule{}