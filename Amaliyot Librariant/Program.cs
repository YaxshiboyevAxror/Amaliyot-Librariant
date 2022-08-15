
using Amaliyot_Librariant.Serves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Models papkasi

            //{{{{{libruary
            //kitoblar
            //foydalanuvchi - kutubxonachi, kitobxonlar  
            //ijaraga olish }}}}}


            //Data layer papkasi

            //{{{ Subject - (Models) - done
            //Tasks


            //Kutubxonachi - CRUD => (Create, Read, Update, Delete)
            //Data acses layer
            //Servies layer
            //UI layer
            IHomeServes homeServes = new HomeServes();
            homeServes.LoadExistingMenu(); 

            IBookMenuServes bookMenuServes = new BookMenuServes();
            bookMenuServes.LoadMenu1();


            IStudentMenuServes studentMenuServes = new StudentMenuServes();
            studentMenuServes.LoadMenu();

            IRentMenuServes rentMenuServes = new RentMenuServes();
            rentMenuServes.DisplayRent();
   
        }
    }
}
