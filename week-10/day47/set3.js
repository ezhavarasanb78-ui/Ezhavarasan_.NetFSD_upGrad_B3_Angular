"use strict";
class Employee {
    eid;
    ename;
    salary;
    constructor(eid, ename, salary) {
        this.eid = eid;
        this.ename = ename;
        this.salary = salary;
    }
    getsalary() {
        return this.salary;
    }
    setsalary(value) {
        if (value > 0) {
            this.salary = value;
        }
        else {
            console.log("salary must be greater than 0");
        }
    }
    displaydetails() {
        console.log(`employee id :${this.eid}`);
        console.log(`employye name :${this.ename}`);
        console.log(`salary :${this.salary}`);
    }
}
class Manager extends Employee {
    ts;
    constructor(eid, ename, salary, ts) {
        super(eid, ename, salary);
        this.ts = ts;
    }
    displaydetails() {
        super.displaydetails();
        console.log(`team size ${this.ts}`);
    }
}
const emp = new Employee(101, "Ezhavarasan", 30000);
emp.displaydetails();
const mgr = new Employee(102, "hari", 30000);
mgr.displaydetails();
