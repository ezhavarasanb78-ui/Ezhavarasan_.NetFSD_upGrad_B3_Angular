import { Student } from "./student.model";
import { getGrade, getTopper } from "./student.service";
import { formatName, calculateAverage } from "./utils";
const students: Student[] = [
    { id: 1, name: "john", marks: 85 },
    { id: 2, name: "alice", marks: 72 },
    { id: 3, name: "bob", marks: 38 }
];
console.log("Formatted Names:");
students.forEach(s => {
    console.log(formatName(s.name));
});
console.log("\nGrades:");
students.forEach(s => {
    console.log(`${s.name} → ${getGrade(s.marks)}`);
});
const avg = calculateAverage(students);
console.log("\nAverage Marks:", avg);
const topper = getTopper(students);
console.log("\nTopper:", topper);