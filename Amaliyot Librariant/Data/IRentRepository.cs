using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Data
{
    public interface IRentRepository
    {
        List<Rent> SelectIjarachilar();

        Rent SelectIjarachiById(int rentId);

        Rent InsertIjarachi(Rent rent);

        Rent UpdateIjarachi(int rentId,Rent rent);

        bool DeleteIjarachiById(int rentId);
    }
}
