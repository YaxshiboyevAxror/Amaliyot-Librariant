using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public interface IBookServes
    {
        IList<Book> RetrieveBooks(string name = null);

        Book RetrieveBook(int bookId);

        Book AddBook(Book book);

        Book ModifyBook(int bookId, Book book);

        bool RemoveBook(int bookId);
    }
}
