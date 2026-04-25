"use strict";
function getFirstElement(items) {
    return items[0];
}
class DataManager {
    items = [];
    add(item) {
        this.items.push(item);
    }
    getAll() {
        return this.items;
    }
}
const userManager = new DataManager();
userManager.add({ id: 1, name: "John" });
userManager.add({ id: 2, name: "Alice" });
const productManager = new DataManager();
productManager.add({ id: 101, title: "Laptop" });
productManager.add({ id: 102, title: "Mobile" });
const users = userManager.getAll();
console.log("Users:", users);
const products = productManager.getAll();
console.log("Products:", products);
const firstUser = getFirstElement(users);
const firstProduct = getFirstElement(products);
console.log("First User:", firstUser);
console.log("First Product:", firstProduct);
