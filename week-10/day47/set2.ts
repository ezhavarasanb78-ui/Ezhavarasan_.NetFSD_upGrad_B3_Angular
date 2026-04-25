const myname:string="Ezhavarasan";
let myage:number=23;
function getwelcomemessage(myname:string):string
{
    return `welcome ${myname}! glad to have a onboard on Cognizant`;
}
console.log(getwelcomemessage(myname));
function getuserinfo(myname:string,myage?:number):string
{
    if(myage!==undefined)
    {
        return `user ${myname} is ${myage} years old`;
    }
  return `user ${myname} has not provided age information`;
}
function getsubscription(myname:string,issub:boolean=false):string
{
    return issub ? `${myname} has subscribed to premium` : `${myname} has not subscribed`;
}
function iseligible(myage:number):boolean
{
    return myage>18;
}
const getaccount=(myname:string):string=>{
    return `hello ${myname},your account has updated successfully`;
}
const ns={
    appName:"MyApp",
    sendNotification:(userName:string):string=> {
        return `Hello${userName},your have new notification from ${ns.appName}`;
    }
};
console.log(getuserinfo(myname,myage));
console.log(getuserinfo(myname));
console.log(getsubscription(myname,true));
console.log(getsubscription(myname));
console.log("elgibility preuminum",iseligible(myage));
console.log(getaccount(myname));
console.log(ns.sendNotification(myname));
