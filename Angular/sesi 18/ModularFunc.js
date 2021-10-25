function removeSpaces(text) {
    return text.split(' ').join("")
}

function reverseText(text) {
    return text.split("").reverse().join("")
}

function updateVowels(text) {
    let encrypted = ""
    let vowels = ["a", "e", "i", "o", "u"]
    for(let i = 0; i < text.length; i++) {
        let char = text[i]
        if(vowels.includes(char.toLowerCase())){
            // console.log(char)
            if(char.toLowerCase() === "a") {
                encrypted += "b"
            } else if(char.toLowerCase() === "i") {
                encrypted += "j"
            } else if(char.toLowerCase() === "u") {
                encrypted += "v"
            } else if(char.toLowerCase() == "e") {
                encrypted += "f"
            } else if(char.toLowerCase() === "o") {
                encrypted += "p"
            } 
        } else {
            encrypted += char
        }
    }
    return encrypted
}

let password = "dimitri w"
let noSpaces = removeSpaces(password)
let reversed = reverseText(noSpaces)
let encryptedPassword = updateVowels(reversed)

console.log(encryptedPassword)