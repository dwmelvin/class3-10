using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using api.Models;

namespace mis321_class10_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: api/Book
        [HttpGet]
        public List<Book> Get()
        {

            BookUtility utility = new BookUtility();
            return utility.GetAllBooks();
            
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public Book Get(int id)
        {
            BookUtility utility = new BookUtility();
            List<Book> myBooks = utility.GetAllBooks();
            foreach(Book book in myBooks) {
                if(book.Id == id) {
                    return book;
                }
            }
            return new Book();
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            Console.WriteLine("");
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Book/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
