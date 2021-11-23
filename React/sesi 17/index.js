function showInTerminal(message) {
    console.log(message)
}

function greeting(name, callback) {
    const value = `Halo! Nama saya ${name}. Senang bertemu dengan FSD Batch 1 OCBC`

    callback(value)
}

greeting("Matthew", showInTerminal)

async function greeting1(name, callback) {
    const value = `Halo! Nama saya ${name}. Senang bertemu dengan FSD Batch 1 OCBC`
    callback(showInTerminal(value))
    return 'ini error'
}
greeting1('rara')

async function buy(thing) {
    return thing === "susu"
}
  
async function anggaBuy() {
    try {
      const isBought = await buy("susu")
      console.log(isBought)
    } catch(err) {
      console.log(err)
    }
}
  
anggaBuy()