using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public class LibrariantMenuServes : ILibrariantMenuServes
    {
        private readonly ILibrariantServes librariantService;

        public LibrariantMenuServes()
        {
            this.librariantService =
                 new LibrariantServes();
        }


        public void LoadMenu()
        {
            Console.Clear();

            string menus =
            "1. Ro'yhat\n" +
            "2. Qo'shish\n" +
            "3. O'chirish\n" +
            "4. Yangilash\n" +
            "5. Orqaga";
            System.Console.WriteLine("===== Kutubxonachilar ====");
            System.Console.WriteLine(menus);

            System.Console.Write("Menuni tanlang: ");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1:
                    DisplayLibrariants(); break;
            }
        }

        public void DisplayLibrariants()
        {
            var temporaryLibrariant = new User()
            {
                Name = "Axror",
                UserId = 1,
                Type = UserType.Librariant,
                BirthDate = DateTime.Now,
                Gender = Gender.Male,

            };

            this.librariantService.AddLibrariant(temporaryLibrariant);

            var librariants =
                this.librariantService.RetrieveLibrariants();

            for (int index = 0; index < librariants.Count; index++)
            {
                System.Console.WriteLine($"{index + 1}. {librariants[index]}");
            }
        }


    }
}
