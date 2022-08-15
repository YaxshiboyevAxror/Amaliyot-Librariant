using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public class BookMenuServes : IBookMenuServes
    {
        private readonly IBookServes bookServes;

        public BookMenuServes()
        {
            this.bookServes = new BookServes();
        }

        public void LoadMenu1()
        {
            Console.Clear();
            string menus =
            "1. Ro'yhat\n" +
            "2. Qo'shish\n" +
            "3. O'chirish\n" +
            "4. Yangilash\n" +
            "5. Orqaga";
            Console.WriteLine("===== Kitoblar ====");
            Console.WriteLine(menus);

            Console.Write("Menuni tanlang: ");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1:
                    DisplayBooks(); break;
            }
        }

        public void DisplayBooks()
        {


            var temporaryBook = new Book()
            {
                BookId = 1,
                Name = "Deyl Karnege",
                Author = "Deyl Endiryu Karnege",
                PublishedAt = DateTime.Now,
                Edition = 1,

            };

            this.bookServes.AddBook(temporaryBook);

            var books = this.bookServes.RetrieveBooks();

            for (int index = 0; index < books.Count; index++)
            {
                Console.WriteLine($"{index + 1}. {books[index]}");
            }
            
        }
    }
}
