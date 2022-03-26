using AddMVC.Model;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace AddMVC.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {                 
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel>SearchBook(string title, string autherName )
        {
            return DataSource().Where(x => x.Author == autherName || x.Title == title).ToList();
        }

        private List<BookModel>DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title = "Loyalty",Author="Aniket" },
                new BookModel(){Id=2, Title = "Loyalty2",Author="Aniket2" },
                new BookModel(){Id=3, Title = "Loyalty3",Author="Aniket3" },
                new BookModel(){Id=4, Title = "Loyalty4",Author="Aniket4" },
            };
        }
    }
}
