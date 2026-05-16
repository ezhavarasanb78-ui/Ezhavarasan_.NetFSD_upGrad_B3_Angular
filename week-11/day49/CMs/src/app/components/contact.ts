import { Component } from "@angular/core";
@Component({
        selector:'contact',
        templateUrl:'contact.html',
        styleUrls:['contact.css']
    })
export class contactcomponent{
    searchText:string='';
    count:number=5;
    contacts = [
    { name: 'ezhavarasan', email: 'EZHA@MAIL.COM', phone: '9876543210', status: true },
    { name: 'arun kumar', email: 'ARUN@MAIL.COM', phone: '9123456780', status: false },
    { name: 'kavin', email: 'KAVIN@MAIL.COM', phone: '9988776655', status: true },
    { name: 'vijay', email: 'VIJAY@MAIL.COM', phone: '8877665544', status: false },
    { name: 'suresh', email: 'SURESH@MAIL.COM', phone: '7766554433', status: true },
    { name: 'mani', email: 'MANI@MAIL.COM', phone: '6655443322', status: true },
    { name: 'raja', email: 'RAJA@MAIL.COM', phone: '5544332211', status: false },
    { name: 'hari', email: 'HARI@MAIL.COM', phone: '4433221100', status: true },
    { name: 'bala', email: 'BALA@MAIL.COM', phone: '3322110099', status: false },
    { name: 'gopi', email: 'GOPI@MAIL.COM', phone: '2211009988', status: true }
  ];
  toggleStatus(contact:any)
  {
    contact.status= !contact.status;
  }
}