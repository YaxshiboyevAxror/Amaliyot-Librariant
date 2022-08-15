using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Data
{
    public class BookRepository : IBookRepository
    {
        private Dictionary<int, Book> books;

        public BookRepository()
        {
            this.books = new Dictionary<int, Book>();
        }


        public IList<Book> SelectAllBooks() => books.Values.ToList();

        public Book SelectBookById(int bookId)
        {
            if (!books.ContainsKey(bookId))
                throw new KeyNotFoundException("Book not found");

            return books[bookId];
        }

        public Book InsertBook(Book book)
        {
            if (books.ContainsKey(book.BookId))
            {
                throw new ArgumentException("Book with this Key already exists");
            }

            books.Add(book.BookId, book);

            return book;
        }

        public Book UpdateBook(int bookId, Book book)
        {
            if (!books.ContainsKey(bookId))
                throw new KeyNotFoundException("Book not found");

            var existingBook = books[bookId];

            if (!string.IsNullOrEmpty(book.Name))
                existingBook.Name = book.Name;

            return existingBook;
        }

        public bool DeleteBook(int bookId)
        {
            if (!books.ContainsKey(bookId))
            {
                throw new KeyNotFoundException("Book not found");
            }
            return books.Remove(bookId);
        }

    }
}
