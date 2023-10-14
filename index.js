const url = 

async function handleOnLoad() {
    let response = await fetch ('https')
    let data = await response.json();
    console.log(data);
}

async function saveBook() {
    console.log("what", book)
    await fetch(url + '/1' {
        method:"POST",
        
        headers: {
            "Content-type": "application/json; charset=UTF-8"
        }
    })
}
// async function fetchAllBooks() {
//     try {
//         let response = await fetch('/api/Book');
//         if (!response.ok) {
//             throw new Error(`HTTP error! Status: ${response.status}`);
//         }
//         let books = await response.json();
//         displayBooks(books);
//     } catch (error) {
//         console.error('Failed to fetch books:', error);
//     }
// }

// function displayBooks(books) {
//     const appDiv = document.getElementById('app');
//     appDiv.innerHTML = '';  // Clear existing content

//     books.forEach(book => {
//         const bookDiv = document.createElement('div');
//         bookDiv.innerHTML = `
//             <h3>${book.Title}</h3>
//             <p>Author: ${book.Author}</p>
//             <p>Pages: ${book.PageCount}</p>
//         `;
//         appDiv.appendChild(bookDiv);
//     });
// }

// // Call fetchAllBooks when the page loads
// window.onload = fetchAllBooks;
