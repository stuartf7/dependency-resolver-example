
using System.Collections.Generic;
using DRE.Model;
using DRE.UI.Web.ServiceContracts;

namespace DRE.Services
{
    /// <summary>
    /// Provides methods for accessing data about books.
    /// </summary>
    public class BookService : IBookService
    {
        /// <summary>
        /// Gets all the books in the library.
        /// </summary>
        /// <returns>Enumeration of all <see cref="Book"/>s in the application.</returns>
        public IEnumerable<Book> GetAll()
        {
            return new List<Book>()
                       {
                           new Book() { ISBN = "0000-0001", Name = "The Book of Food", Author = "Homer Simpson" },
                           new Book() { ISBN = "0000-0002", Name = "The Book of Nothing", Author = "A.N Author"}
                       };
        }
    }
}
