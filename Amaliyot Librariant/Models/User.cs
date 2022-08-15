using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTimeOffset BirthDate { get; set; }

        public UserType Type { get; set; }

        public override string ToString() =>
            $"Id: {UserId}\nName: {Name}\nGender: {Gender}\nBirthday: {BirthDate}\nJob: {Type} ";

    }

    public enum Gender
    {
        Male,
        Famely
    }
    public enum UserType
    {
        Student,
        Librariant
    }
}
