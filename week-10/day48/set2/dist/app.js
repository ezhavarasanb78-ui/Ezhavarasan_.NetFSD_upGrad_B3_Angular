"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const student_service_1 = require("./student.service");
const utils_1 = require("./utils");
const students = [
    { id: 1, name: "john", marks: 85 },
    { id: 2, name: "alice", marks: 72 },
    { id: 3, name: "bob", marks: 38 }
];
console.log("Formatted Names:");
students.forEach(s => {
    console.log((0, utils_1.formatName)(s.name));
});
console.log("\nGrades:");
students.forEach(s => {
    console.log(`${s.name} → ${(0, student_service_1.getGrade)(s.marks)}`);
});
const avg = (0, utils_1.calculateAverage)(students);
console.log("\nAverage Marks:", avg);
const topper = (0, student_service_1.getTopper)(students);
console.log("\nTopper:", topper);
