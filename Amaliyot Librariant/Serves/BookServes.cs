using Amaliyot_Librariant.Data;
using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{

    public class BookServes : IBookServes
    {
        private readonly IBookRepository bookRepository;

        public BookServes()
        {
            this.bookRepository = new BookRepository();
        }

        public IList<Book> RetrieveBooks(string name = null)
        {
            var books =
                this.bookRepository.SelectAllBooks();

            if (!string.IsNullOrEmpty(name))
            {
                var filteredBook = new List<Book>();
                foreach (var book in books)
                {
                    if (book.Name.Contains(name))
                        filteredBook.Add(book);

                    return filteredBook;
                }
            }
            return books;
        }

        public Book RetrieveBook(int bookId)
        {
            Book book = null;
            try
            {
                book =
                    this.bookRepository.SelectBookById(bookId);
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return book;
        }

        public Book AddBook(Book book)
        {
            Book insertedBook = null;
            try
            {
                insertedBook =
                    this.bookRepository.InsertBook(book);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return insertedBook;
        }

        public Book ModifyBook(int bookId, Book book)
        {
            Book modifiedBook = null;
            try
            {
                modifiedBook =
                    this.bookRepository.UpdateBook(bookId, book);
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return modifiedBook;
        }

        public bool RemoveBook(int bookId)
        {
            bool isRemoved = false;
            try
            {
                isRemoved =
                    this.bookRepository.DeleteBook(bookId);
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return isRemoved;
        }

        

    }
}
