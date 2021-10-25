let pageTitleElement = document.getElementById("page title")
console.log(pageTitleElement)

let pageBoxElements =  document.getElementsByClassName("page-box")
console.log(pageBoxElements)

let pageHeadings = document.getElementsByTagName("div")

let pageTitleElementsContent = pageTitleElement.innerHTML
console.log("isi <div id=page title></div>", pageTitleElementsContent)

//akses array di dom
for(let i = 0; i < pageBoxElements.length; i++) {
    let currentPageBoxElement = pageBoxElements[i]
    let currentPageBoxElementContent = currentPageBoxElement.innerHTML

    let secondPageBoxElement = pageBoxElements[1]
    let secondPageBoxElementContent = secondPageBoxElement.innerHTML

    let thirdPageBoxElement = pageBoxElements[2]
    let thirdPageBoxElementContent = thirdPageBoxElement.innerHTML

    console.log("isi <div class=page-box></div> yang kedua", secondPageBoxElementContent)
    console.log("isi <div class=page-box></div> yang ketiga", thirdPageBoxElementContent)
}