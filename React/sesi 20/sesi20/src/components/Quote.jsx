import React, {useState} from 'react'

export default function Quote(props) {
    //==state ini nggak bisa diubah, karena nggak ada setternya, ex: [quote, setQuote]==
    const [quote] = useState(props.quote)
    return (
        <>
            <blockquote>
                {props.quote}
            </blockquote>

            <blockquote>
                quote with useState hooks: {quote}
            </blockquote>   
        </>
    )
}
