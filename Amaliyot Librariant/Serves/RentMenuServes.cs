using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public class RentMenuServes : IRentMenuServes
    {
        private readonly RentServes rentServes;

        public RentMenuServes()
        {
            this.rentServes = new RentServes();
        }

        public void LoadMenu2()
        {
            Console.Clear();
            string menus =
            "1. Ro'yhat\n" +
            "2. Qo'shish\n" +
            "3. O'chirish\n" +
            "4. Yangilash\n" +
            "5. Orqaga";
            Console.WriteLine("===== Ijarachilar ====");
            Console.WriteLine(menus);

            Console.Write(" Menuni tanlang: ");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1:
                    DisplayRent(); break;
            }
        }

        public void DisplayRent()
        {

            var temporaryRent = new Rent()
            {
                RentId = 1,
                UserId = 1,
                BookId = 1,
                RentAt = DateTime.Now,
                ReturnAt = DateTime.Now,
                IsReturned = true,

            };

            this.rentServes.AddRent(temporaryRent);

            var rents = this.rentServes.RetrieveRents();

            for (int index = 0; index < rents.Count; index++)
            {
                Console.WriteLine($"{index + 1}. {rents[index]}");
            }
        }

    }
}
