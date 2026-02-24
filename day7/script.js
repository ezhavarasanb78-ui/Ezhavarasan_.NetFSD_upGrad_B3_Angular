const marks=[70,80,60,90,75];
const total=marks.reduce((sum, mark) => sum + mark, 0);
const avg=total/marks.length;
const ml=marks.map(mark=>mark);
const res=avg>=50 ? "Pass " : "Fail";
console.log(`
Marks: ${ml.join(", ")}
Total: ${total}
Average: ${avg}
Result: ${res}
`);