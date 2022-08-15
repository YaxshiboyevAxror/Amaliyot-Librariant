using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public interface IRentServes
    {
        List<Rent> RetrieveRents(string name = null);

        Rent RetrieveRent(int rentId);

        Rent AddRent(Rent rent);

        Rent Modify(Rent rent, int rentId);

        bool RemoveRent(int rentId);
    }
}
