using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public class StudentMenuServes : IStudentMenuServes
    {
        private readonly IStudentServes studentServes;

        public StudentMenuServes()
        {
            this.studentServes = new StudentServes();
        }

        public void LoadMenu()
        {
            Console.Clear();
            string menus = "" +
                "1. Ro`yxat\n" +
                "2. Qo`shish\n" +
                "3. O`chirish\n" +
                "4. Yangilash";
            Console.WriteLine("==== Talabalar ====");
            Console.WriteLine(menus);

            Console.WriteLine("==== Menu Tanlang ====");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1: DisplayStudents(); break;
            }
        }

        public void DisplayStudents()
        {
            

            var temporaryStudent = new User()
            {

                UserId = 1,
                Name = "Axror",
                Gender = Gender.Male,
                BirthDate = DateTime.Now,
                Type = UserType.Student,

            };
            
            this.studentServes.AddStudent(temporaryStudent);

            var students =
                this.studentServes.RetrieveStudents();

            for(int index = 0; index < students.Count; index++)
            {
                Console.WriteLine($"{index + 1}. {students[index]}");
            }
        }
    }
}
