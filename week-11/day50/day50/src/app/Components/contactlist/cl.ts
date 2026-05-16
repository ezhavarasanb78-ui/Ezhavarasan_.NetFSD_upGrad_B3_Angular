import { Component,OnInit } from "@angular/core";
import { Contact } from "../../Models/contacts";
import { ContactService } from "../../Services/contact.service";
import { FormsModule } from "@angular/forms";
import { CommonModule } from "@angular/common";
@Component({
    selector:'contact-list',
    standalone:true,
    imports:[FormsModule,CommonModule],
    templateUrl:'./cl.html'
})
export class ContactListComponent implements OnInit {

  contacts: Contact[] = [];

  newContact: Contact = {
    id: 0,
    name: '',
    email: '',
    phone: ''
  };

  constructor(private contactService: ContactService) {}

  ngOnInit(): void {
    this.contacts = this.contactService.getContacts();
  }

  addContact() {
    this.newContact.id = this.contacts.length + 1;
    this.contactService.addContact(this.newContact);

    this.contacts = this.contactService.getContacts();

    this.newContact = { id: 0, name: '', email: '', phone: '' };
  }
}