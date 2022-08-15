using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public interface ILibrariantServes
    {
        IList<User> RetrieveLibrariants(string name = null);

        User RetrieveLibrariant(int librariantId);

        User AddLibrariant(User librariant);

        User ModifyLibrariant(int librariantId, User librariant);

        bool RemoveLibrariant(int librariantId);
    }
}
