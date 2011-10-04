using System.Collections.Generic;
using DRE.Model;

namespace DRE.UI.Web.ServiceContracts
{
    public interface IBookService
    {
        /// <summary>
        /// Gets all the books in the library.
        /// </summary>
        /// <returns>Enumeration of all <see cref="Book"/>s in the application.</returns>
        IEnumerable<Book> GetAll();
    }
}