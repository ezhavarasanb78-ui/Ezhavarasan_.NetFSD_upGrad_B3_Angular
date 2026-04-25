"use strict";
const myname = "Ezhavarasan";
let myage = 23;
function getwelcomemessage(myname) {
    return `welcome ${myname}! glad to have a onboard on Cognizant`;
}
console.log(getwelcomemessage(myname));
function getuserinfo(myname, myage) {
    if (myage !== undefined) {
        return `user ${myname} is ${myage} years old`;
    }
    return `user ${myname} has not provided age information`;
}
function getsubscription(myname, issub = false) {
    return issub ? `${myname} has subscribed to premium` : `${myname} has not subscribed`;
}
function iseligible(myage) {
    return myage > 18;
}
const getaccount = (myname) => {
    return `hello ${myname},your account has updated successfully`;
};
const ns = {
    appName: "MyApp",
    sendNotification: (userName) => {
        return `Hello${userName},your have new notification from ${ns.appName}`;
    }
};
console.log(getuserinfo(myname, myage));
console.log(getuserinfo(myname));
console.log(getsubscription(myname, true));
console.log(getsubscription(myname));
console.log("elgibility preuminum", iseligible(myage));
console.log(getaccount(myname));
console.log(ns.sendNotification(myname));
