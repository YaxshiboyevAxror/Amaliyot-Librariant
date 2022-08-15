using Amaliyot_Librariant.Data;
using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public class RentServes : IRentServes
    {
        private readonly IRentRepository rentRepository;

        public RentServes()
        {
            var rentRepository = new RentRepository();
        }

        public List<Rent> RetrieveRents(string name = null)
        {
            var rents =
                this.rentRepository.SelectIjarachilar();

            if (!string.IsNullOrEmpty(name))
            {
                var filteredRent = new List<Rent>();
                foreach (var rent in rents)
                {
                    if (rent.IsReturned.Equals(name))
                        filteredRent.Add(rent);

                    return filteredRent;
                }
            }
            return rents;
        }

        public Rent RetrieveRent(int rentId)
        {
            Rent rent = null;
            try
            {
                rent =
                    this.rentRepository.SelectIjarachiById(rentId);
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return rent;
        }

        public Rent AddRent(Rent rent)
        {
            Rent insertedRent = null;
            try
            {
                insertedRent = this.rentRepository.InsertIjarachi(rent);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return insertedRent;
        }

        public Rent Modify(Rent rent, int rentId)
        {
            Rent modifiedRent = null;
            try
            {
                modifiedRent =
                    this.rentRepository.UpdateIjarachi(rentId, rent);
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return modifiedRent;
        }

        public bool RemoveRent(int rentId)
        {
            bool isRemoved = false;
            try
            {
                isRemoved =
                    this.rentRepository.DeleteIjarachiById(rentId);
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return isRemoved;
        }

    }
}
