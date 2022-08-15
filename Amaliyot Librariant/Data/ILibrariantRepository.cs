using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Data
{
    public interface ILibrariantRepository
    {
        IList<User> SelectAllLibrariants();

        User SelectLibrariantById(int librariantId);

        User InsertLibrariant(User librariant);

        User UpdateLibrariant(int librariantId, User librariant);

        bool DeleteLibrariant(int librariantId);
    }
}
