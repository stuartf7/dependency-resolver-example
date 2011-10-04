namespace DRE.Model
{
    /// <summary>
    /// Domain representation of a book.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the name of the book.
        /// </summary>
        /// <value>The name of the book.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ISBN of the book.
        /// </summary>
        /// <value>The ISBN.</value>
        public string ISBN { get; set; }

        /// <summary>
        /// Gets or sets the authorof the book.
        /// </summary>
        /// <value>The author of the book.</value>
        public string Author { get; set; }
    }
}
