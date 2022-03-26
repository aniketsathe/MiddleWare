using AddMVC.Repository;
using Microsoft.AspNetCore.Mvc;
using AddMVC.Model;
using System.Collections.Generic;

namespace AddMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string Name,string authorName)
        {
            return _bookRepository.SearchBook(Name, authorName);
        }
    }
}
