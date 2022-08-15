using Amaliyot_Librariant.Data;
using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public class StudentServes : IStudentServes
    {
        private readonly IStudentRepository studentRepository;

        public StudentServes()
        {
            this.studentRepository = new StudentRepository();
        }

        public List<User> RetrieveStudents(string name = null)
        {
            var students = this.studentRepository.SelectAllStudents();

            if (!string.IsNullOrEmpty(name))
            {
                var filtiredStudent = new List<User>();
                foreach(var student in students)
                {
                    if (student.Name.Contains(name))
                    {
                        filtiredStudent.Add(student);

                        return filtiredStudent;
                    }
                }
            }
            return students;
        }

        public User RetrieveStudent(int studentId)
        {
            User student = null;
            try
            {
                student = this.studentRepository.SelectStudentById(studentId);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return student;
        }

        public User AddStudent(User student)
        {
            User insertstudent = null;
            try
            {
                insertstudent = this.studentRepository.InsertStudent(student);
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return insertstudent;
        }

        public User ModifyStudent(int studentId, User student)
        {
            User modifystudent = null;
            try
            {
                modifystudent = this.studentRepository.UpdateStudent(studentId, student);
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return modifystudent;
        }

        public bool DeleteStudent(int studentId)
        {
            bool isRemoved = false;
            try
            {
                isRemoved =
                    this.studentRepository.DeleteStudent(studentId);
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return isRemoved;
        }

    }
}
