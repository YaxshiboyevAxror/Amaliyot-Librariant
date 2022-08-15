using Amaliyot_Librariant.Data;
using Amaliyot_Librariant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliyot_Librariant.Serves
{
    public class LibrariantServes : ILibrariantServes
    {
        private readonly ILibrariantRepository librariantRepository;

        public LibrariantServes()
        {
            this.librariantRepository =
                new LibrariantRepository();
        }

        public User AddLibrariant(User librariant)
        {
            User insertedLibrariant = null;
            try
            {
                insertedLibrariant =
                    this.librariantRepository.InsertLibrariant(librariant);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return insertedLibrariant;
        }

        public User ModifyLibrariant(int librariantId, User librariant)
        {
            User modifiedLibrariant = null;
            try
            {
                modifiedLibrariant =
                    this.librariantRepository.UpdateLibrariant(librariantId, librariant);
            }
            catch (KeyNotFoundException exception)
            {
                System.Console.WriteLine(exception.Message);
            }

            return modifiedLibrariant;
        }

        public bool RemoveLibrariant(int librariantId)
        {
            bool isRemoved = false;
            try
            {
                isRemoved =
                    this.librariantRepository.DeleteLibrariant(librariantId);
            }
            catch (KeyNotFoundException exception)
            {
                System.Console.WriteLine(exception.Message);
            }

            return isRemoved;
        }

        public User RetrieveLibrariant(int librariantId)
        {
            User librariant = null;
            try
            {
                librariant =
                    this.librariantRepository.SelectLibrariantById(librariantId);
            }
            catch (KeyNotFoundException exception)
            {
                System.Console.WriteLine(exception.Message);
            }

            return librariant;
        }

        public IList<User> RetrieveLibrariants(string name = null)
        {
            var librariants =
                this.librariantRepository.SelectAllLibrariants();

            if (!string.IsNullOrEmpty(name))
            {
                var filteredLibrariants = new List<User>();
                foreach (var librariant in librariants)
                {
                    if (librariant.Name.Contains(name))
                        filteredLibrariants.Add(librariant);

                    return filteredLibrariants;
                }
            }
            return librariants;
        }

    }
}
