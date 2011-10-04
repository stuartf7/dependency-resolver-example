using System.Web.Mvc;
using DRE.UI.Web.ServiceContracts;

namespace DRE.UI.Web.Controllers
{
    public class BookController : Controller
    {
        #region Fields

        private readonly IBookService _bookService;
        
        #endregion
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BookController"/> class.
        /// </summary>
        /// <param name="bookService">The book service.</param>
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        #endregion

        #region Actions

        /// <summary>
        /// Index Action.
        /// </summary>
        /// <returns>ActionResult containing the index view</returns>
        public ActionResult Index()
        {
            return View(_bookService.GetAll());
        }
        
        #endregion
    }
}
