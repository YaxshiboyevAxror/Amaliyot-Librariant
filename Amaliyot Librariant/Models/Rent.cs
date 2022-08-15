using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Models
{
    public class Rent
    {
        public int RentId { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        public DateTimeOffset RentAt { get; set; }

        public DateTimeOffset ReturnAt { get; set; }

        public bool IsReturned { get; set; }

        public override string ToString() =>
            $"RentId: {RentId}\n UserId: {UserId}\n BookId: {BookId}\n " +
            $"RentAt: {RentAt}\n ReturnAt: {ReturnAt}\n IsReturned: {IsReturned}";
    }
}
