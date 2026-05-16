import { Component } from "@angular/core";
import { ContactListComponent } from "./Components/contactlist/cl";
import { ContactDetailComponent } from "./Components/contactdetails/cd";
@Component({
  selector:'app-root',
  imports:[ContactDetailComponent,ContactListComponent],
  standalone:true,
  templateUrl:'./app.component.html'
})
export class AppComponent{}
