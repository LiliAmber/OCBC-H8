var hello = "Hello World";
console.log(hello);
var address = "Kebayoran";
// address = 105 //Type "number" is not assignable to type "string"
//==CARA MENULISKAN ANOTASI DATA TYPE DI VARIABEL==
var alamat = "Kebayoran";
var age = 10;
var item = 105;
var isActive;
//==CARA MENULISKAN ANOTASO DATA TYPE DI PARAMETER FUNCTION==
function getProfileTS(name, age) {
    if (age === void 0) { age = 17; }
    console.log("Hello, " + name + "!, your age is " + age + " old");
}
getProfileTS("rara");
//==CARA ANOTASI DATA TYPE ARRAY==
var itemTs;
itemTs = ["Sepatu", "Sendal", "Tas"];
//==JIKA LEBIH DARI SATU DATA TYPE==
var itemTs2;
itemTs2 = ["Sepatu", "Sendal", false, 1, 2];
//==CARA ANOTASI DATA TYPE DI OBJECT==
var personTs = {
    name: "Maryam",
    age: 17
};
//atau
var personTs2;
personTs2 = {
    name: "Bobi",
    age: "17"
};
//==OPTIONAL PROPERTY DI OBJECT==
var personTs3;
//==interface sebagai anotasi type==
var myPhone = {
    brand: "Apple",
    merk: "Iphone",
    type: "Iphone 12 pro",
    price: 20,
    features: ["iOS 14", "Super Retina Display"]
};
var phones = [
    {
        brand: "Apple",
        merk: "Iphone",
        type: "Iphone 12 pro",
        price: 20,
        features: ["iOS 14", "Super Retina Display"]
    },
    {
        brand: "Samsung",
        merk: "Samsung",
        type: "Samsung Note Galaxy",
        price: 20
    }
];
// console.log(myPhone)
// console.log(phones)
//==ANOTASI DATA TYPE DALAM PROPERTI CLASS==
var Customer = /** @class */ (function () {
    function Customer(name, age, money) {
        this.items = ["buku", "laptop"];
        this.name = name;
        this.age = age;
        this.money = money;
    }
    Customer.prototype.updateDataMoney = function (money) {
        this.money = money;
    };
    Customer.prototype.addItem = function (itemName) {
        this.items.push(itemName);
    };
    return Customer;
}());
var raihan = new Customer("raihan", 17, 500);
raihan.updateDataMoney(1000);
raihan.addItem("smartphone");
console.log(raihan);
//anotasi class di dilm properti class
var Shop = /** @class */ (function () {
    function Shop() {
        this.customers = [];
    }
    Shop.prototype.addCustomer = function (newCustomer) {
        this.customers.push(newCustomer);
    };
    return Shop;
}());
var shopE = new Shop();
shopE.addCustomer(raihan);
console.log(shopE);
