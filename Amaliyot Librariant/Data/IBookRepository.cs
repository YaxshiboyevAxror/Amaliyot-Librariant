using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Data
{
    public interface IBookRepository
    {
        IList<Book> SelectAllBooks();

        Book SelectBookById(int bookId);

        Book InsertBook(Book book);

        Book UpdateBook(int bookId, Book book);

        bool DeleteBook(int bookId);
    }
}
