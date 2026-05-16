import { Component,OnInit } from "@angular/core";
import { Contact } from "../../Models/contacts";
import { CommonModule } from "@angular/common";
import { ContactService } from "../../Services/contact.service";
@Component({
    selector:'contact-detail',
    templateUrl:'./cd.html',
    imports:[CommonModule],
    standalone:true
})
export class ContactDetailComponent implements OnInit {

  contact?: Contact;

  constructor(private contactService: ContactService) {}

  ngOnInit(): void {
    const id = 1; 
    this.contact = this.contactService.getContactById(id);
  }
}