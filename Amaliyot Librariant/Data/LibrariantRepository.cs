using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Data
{
    public class LibrariantRepository : ILibrariantRepository
    {
        private Dictionary<int, User> librariants;

        public LibrariantRepository()
        {
            this.librariants = new Dictionary<int, User>();
        }

        public IList<User> SelectAllLibrariants() => this.librariants.Values.ToList();



        public User SelectLibrariantById(int librariantId)
        {
            if (!librariants.ContainsKey(librariantId))
                throw new KeyNotFoundException("Librariant not found");

            return librariants[librariantId];
        }

        public User InsertLibrariant(User librariant)
        {
            if (librariants.ContainsKey(librariant.UserId))
                throw new ArgumentException("Librariant with this key already exists");

            librariants.Add(librariant.UserId, librariant);

            return librariant;
        }

        public User UpdateLibrariant(int librariantId, User librariant)
        {
            if (!librariants.ContainsKey(librariantId))
                throw new KeyNotFoundException("Librariant not found");

            var existingLibrariant = librariants[librariantId];

            if (!string.IsNullOrEmpty(librariant.Name))
                existingLibrariant.Name = librariant.Name;

            return existingLibrariant;
        }

        public bool DeleteLibrariant(int librariantId)
        {
            if (!librariants.ContainsKey(librariantId))
                throw new KeyNotFoundException("Librariant not found");

            return librariants.Remove(librariantId);
        }

    }
}
