import { Injectable } from '@angular/core';
import { Contact } from '../Models/contacts';

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  private contacts: Contact[] = [
    { id: 1, name: 'John Doe', email: 'john@gmail.com', phone: '9876543210' },
    { id: 2, name: 'Jane Smith', email: 'jane@gmail.com', phone: '9123456780' }
  ];

  constructor() {}

  getContacts(): Contact[] {
    return this.contacts;
  }

  addContact(contact: Contact): void {
    this.contacts.push(contact);
  }

  getContactById(id: number): Contact | undefined {
    return this.contacts.find(c => c.id === id);
  }
}