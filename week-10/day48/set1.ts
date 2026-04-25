function getFirstElement<T>(items: T[]): T {
    return items[0];
}
interface Repository<T> {
    add(item: T): void;
    getAll(): T[];
}
class DataManager<T> implements Repository<T> {
    private items: T[] = [];

    public add(item: T): void {
        this.items.push(item);
    }

    public getAll(): T[] {
        return this.items;
    }
}
interface User {
    id: number;
    name: string;
}
interface Product {
    id: number;
    title: string;
}
const userManager = new DataManager<User>();
userManager.add({ id: 1, name: "John" });
userManager.add({ id: 2, name: "Alice" });
const productManager = new DataManager<Product>();
productManager.add({ id: 101, title: "Laptop" });
productManager.add({ id: 102, title: "Mobile" });
const users: User[] = userManager.getAll();
console.log("Users:", users);
const products: Product[] = productManager.getAll();
console.log("Products:", products);
const firstUser = getFirstElement<User>(users);
const firstProduct = getFirstElement<Product>(products);
console.log("First User:", firstUser);
console.log("First Product:", firstProduct);