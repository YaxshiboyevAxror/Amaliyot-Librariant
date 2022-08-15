using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Data
{
    public interface IStudentRepository
    {
        List<User> SelectAllStudents();

        User SelectStudentById(int studentId);

        User InsertStudent(User student);

        User UpdateStudent(int studentId,User student);

        bool DeleteStudent(int studentId);
    }
}
