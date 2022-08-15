using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public interface IStudentServes
    {
        List<User> RetrieveStudents(string name = null);

        User RetrieveStudent(int studentId);

        User AddStudent(User student);

        User ModifyStudent(int studentId,User student);

        bool DeleteStudent(int studentId);
    }
}
