class Employee
{
   public eid:number;
   protected ename:string;
   private salary:number;

   constructor(eid:number,ename:string,salary:number)
   {
    this.eid=eid;
    this.ename=ename;
    this.salary=salary;
   }
   public getsalary():number
   {
    return this.salary;
   }
   public setsalary(value:number):void{
    if(value>0)
    {
        this.salary=value;
    }
    else
    {
        console.log("salary must be greater than 0");

    }
   }
   public displaydetails():void{
    console.log(`employee id :${this.eid}`);
    console.log(`employye name :${this.ename}`);
    console.log(`salary :${this.salary}`);
   }
}
class Manager extends Employee
{
    private ts:number;
    constructor(eid:number,ename:string,salary:number,ts:number)
    {
        super(eid,ename,salary)
        this.ts=ts;
    }
    public displaydetails(): void {
        super.displaydetails();
        console.log(`team size ${this.ts}`);
    }
}
const emp=new Employee(101,"Ezhavarasan",30000);
emp.displaydetails();
const mgr=new Employee(102,"hari",30000);
mgr.displaydetails();