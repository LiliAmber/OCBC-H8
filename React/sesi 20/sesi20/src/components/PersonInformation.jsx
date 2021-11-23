import React, { Component, useState } from 'react'
import Quote from './Quote'

export default function PersonInformation() {
    const [personData, setPersonData] = useState(
        {
            name: 'Septyan',
            quote: 'Tiada hari tanpa ngoding React',
            age: 17
        }
    )

    const changeName = () => {
        const newName = personData.name + 2
        setPersonData(
            {
                ...personData,
                name: newName
            }
        )
    }

    return (
        <>
            <h1>Person Information</h1>
            <div>
                <span>Name: {personData.name}</span><br />
                <span>Age: {personData.age}</span><br />
                <span>Quote:</span>
                <Quote quote={personData.quote}/>
            </div>  

            <button onClick={changeName}>change my name</button>
        </>
    )
    
}

// export default class PersonInformation extends Component {
//     constructor() {
//         super()

//         this.state = {
//             name: 'Septyan',
//             quote: 'Tiada hari tanpa ngoding React',
//             age: 17
//         }
//     }

//     render() {
//         return (
//             <>
//                 <h1>Person Information</h1>
//                 <div>
//                     <span>Name: {this.state.name}</span><br />
//                     <span>Age: {this.state.age}</span><br />
//                     <span>Quote:</span>
//                     <Quote quote={this.state.quote}/>
//                 </div>  
//             </>
//         )
//     }
// }
