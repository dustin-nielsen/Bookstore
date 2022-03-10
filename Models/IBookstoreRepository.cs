using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }

        public void SaveBook(Book b);
        public void CreateBook(Book b);
        public void DeleteBook(Book b);
    }
}
