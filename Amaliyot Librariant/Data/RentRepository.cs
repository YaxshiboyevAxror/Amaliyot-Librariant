using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Data
{
    public class RentRepository : IRentRepository
    {
        private Dictionary<int, Rent> rents;

        public RentRepository()
        {
            this.rents = new Dictionary<int, Rent>();
        }

        public List<Rent> SelectIjarachilar() => rents.Values.ToList();

        public Rent SelectIjarachiById(int rentId)
        {
            if (!rents.ContainsKey(rentId))
            {
                throw new KeyNotFoundException("Rent Not Found");
            }

            return rents[rentId];
        }

        public Rent InsertIjarachi(Rent rent)
        {
            if (rents.ContainsKey(rent.RentId))
            {
                throw new ArgumentException("Rent with this already exist");
            }
            rents.Add(rent.RentId, rent);

            return rent;
        }

        public Rent UpdateIjarachi(int rentId, Rent rent)
        {
            if (rents.ContainsKey(rentId))
            {
                throw new KeyNotFoundException("Rent Not Found");
            }

            return rent;
        }

        public bool DeleteIjarachiById(int rentId)
        {
            if (!rents.ContainsKey(rentId))
            {
                throw new KeyNotFoundException("Rent Not Found");
            }

            return rents.Remove(rentId);
        }

    }
}
