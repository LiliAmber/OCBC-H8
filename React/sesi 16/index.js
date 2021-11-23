let num = 1
let bool = true
let world = 'coding'
let str = `i love ${world}`

// console.log(str)
// console.log(num)
// console.log(bool)

let numArr = [1, 2, 3, 4, 5, 6, 7, 8]
let strArr = ['saya', 'lagi', 'coding']
let boolArr = [true, false]

// console.log(numArr)

let students = [
    ['Nico', 'front-end developer', true],
    ['Ricky', 'back-end developer', true],
    ['Fauzi', 'full-stack developer', false]
]

// for(let i = 0; i < students.length; i++) {
//     const student = students[i]
//     console.log(
//         `Halo! Nama saya ${student[0]},
//         Saya adalah ${student[1]},
//         dan saya ${!student[2] ? 'bukan': ''} karyawan probation
//         `
//     )
// }

// students.forEach(student => {
//     console.log(
//         `Halo! Nama saya ${student[0]},
//         Saya adalah ${student[1]},
//         dan saya ${!student[2] ? 'bukan': ''} karyawan probation
//         `
//     )
// });

class Whatever {
    abilities = ['attack', 'run', 'walk']
    name = 'waria'
    class = 'warrior'

    show() {
        console.log(this)
    }
}

const waria = new Whatever

console.log(waria)

//==arrow function
function sumTraditional(a,b) {
    return a + b
}
const sum = (a, b) => a + b

console.log(sum(2, 3))

function curryFunction(a,b) {
    const c = a + b

    return function(d) {
        console.log(c + d)
    }
}

const anotherFunction = curryFunction(5, 10) (20)

const anotherCurryFunction = (a, b) => (c, d) => (a + b) - (c + d)
console.log(anotherCurryFunction(1, 5))

const addNumb = anotherCurryFunction(10, 20)
console.log(addNumb(12, 11))
