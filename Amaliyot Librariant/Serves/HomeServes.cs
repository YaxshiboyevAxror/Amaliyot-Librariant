using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public class HomeServes : IHomeServes
    {
        private readonly ILibrariantMenuServes librariantMenuService;
        private readonly IBookMenuServes bookMenuServes;
        private readonly IStudentMenuServes studentMenuServes;
        private readonly IRentMenuServes rentMenuServes;
        public HomeServes()
        {
            this.librariantMenuService = new LibrariantMenuServes();
            this.bookMenuServes = new BookMenuServes();
            this.studentMenuServes = new StudentMenuServes();
            this.rentMenuServes = new RentMenuServes();
        }

        public void LoadExistingMenu()
        {
            string menus = "" +
                "1. Kutubxonachilar\n" +
                "2. Kitoblar\n" +
                "3. Talabalar\n" +
                "4. Ijarachilar\n" +
                "5. Chiqish";
            System.Console.WriteLine("===== Menu =====");
            System.Console.WriteLine(menus);

            System.Console.Write("Menuni tanlang: ");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1:
                    librariantMenuService.LoadMenu(); break;

                case 2: bookMenuServes.LoadMenu1(); break;

                case 3: studentMenuServes.LoadMenu(); break;

                case 4: rentMenuServes.LoadMenu2(); break;

                case 5:
                    Exit(); break;
            }
        }
        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}
