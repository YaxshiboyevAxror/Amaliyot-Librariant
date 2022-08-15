using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public DateTimeOffset PublishedAt { get; set; }

        public int Edition { get; set; }

        public override string ToString() =>
            $"Id: {BookId}\n Name: {Name}\n Author: {Author}\n PublishedAt: {PublishedAt}\n Edition: {Edition} ";
    }
}
