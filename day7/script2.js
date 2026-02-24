const prod=[
    { name: "Lap",price :"40000",quantity: 1},
    { name: "mouse",price :"300",quantity: 2},
    { name: "keyboard",price :"1000",quantity: 2}
 ];
 const ct = (items) =>
  items.reduce((total, item) => total + item.price * item.quantity, 0);
const res = prod.map(item =>
  `${item.name} - ₹${item.price} x ${item.quantity} = ₹${item.price * item.quantity}`
);
const ta = ct(prod);
console.log(`
${res.join("\n")}
Total Amount: ₹${ta}
`);