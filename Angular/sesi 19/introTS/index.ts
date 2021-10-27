const hello: string = "Hello World";

console.log(hello)

let address : string = "Kebayoran"
// address = 105 //Type "number" is not assignable to type "string"

//==CARA MENULISKAN ANOTASI DATA TYPE DI VARIABEL==
let alamat: string = "Kebayoran"
let age: number = 10
let item: number | string = 105
let isActive: boolean

//==CARA MENULISKAN ANOTASO DATA TYPE DI PARAMETER FUNCTION==
function getProfileTS(name:string, age:number = 17) {
    console.log(`Hello, ${name}!, your age is ${age} old`)
}
getProfileTS("rara")

//==CARA ANOTASI DATA TYPE ARRAY==
let itemTs: string[]
itemTs = ["Sepatu", "Sendal", "Tas"]
//==JIKA LEBIH DARI SATU DATA TYPE==
let itemTs2: (string|number|boolean) []
itemTs2 = ["Sepatu", "Sendal", false, 1, 2]

//==CARA ANOTASI DATA TYPE DI OBJECT==
let personTs: {
    name: string
    age: number
} = {
    name: "Maryam",
    age: 17
}
//atau
let personTs2 : {
    name: string
    age: number|string
}
personTs2 = {
    name: "Bobi",
    age: "17"
}

//==OPTIONAL PROPERTY DI OBJECT==
let personTs3 : {
    name: string
    age?: number//=> optional
}

/* ==INTERFACE==
adalah sebuah kontrak,, yang mana ada objek atau class yang mengimplementasikan interface tersebut maka objek atau class tersebut dapat menggunakan property yang dimiliki oleh interface tersebut
*/
interface Phone {
    brand: string,
    merk: string,
    type: string,
    price: number,
    features?: string[]
}

//==interface sebagai anotasi type==
let myPhone: Phone = {
    brand: "Apple",
    merk: "Iphone",
    type: "Iphone 12 pro",
    price: 20,
    features: ["iOS 14", "Super Retina Display"]

}

let phones: Phone[] = [
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
        price: 20,
    }
]
// console.log(myPhone)
// console.log(phones)

//==ANOTASI DATA TYPE DALAM PROPERTI CLASS==
class Customer {
    name: string
    age: number
    money: number
    items: string[] = ["buku", "laptop"]

    constructor(name: string, age: number, money: number) {
        this.name = name
        this.age = age
        this.money = money
    }

    updateDataMoney(money: number) {
        this.money = money
    }

    addItem(itemName: any) {
        this.items.push(itemName)
    }
}

const raihan = new Customer("raihan", 17, 500)
raihan.updateDataMoney(1000)
raihan.addItem("smartphone")
// console.log(raihan)

//anotasi class di dilm properti class
class Shop {
    customers: Customer[] = []

    addCustomer(newCustomer: Customer) {
        this.customers.push(newCustomer)
    }
}

const shopE = new Shop()
shopE.addCustomer(raihan)
// console.log(shopE)

/* ==DATA MODIFIER==
dalam object-oriented programming, terdapat konsep enkapsulasi, dimana kita bisa mengontrol visibilitas dari suatu data dalam class: 
1. public = membuat data dapat diakses oleh siapa saja dan di scope mana saja
2. private = membuat data hanya dapat diakses dalam class miliknya
3. protecteed = membuat data hanya dapat diakses dalam class milik turunannya
*/


