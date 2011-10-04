using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DRE.Services;
using DRE.UI.Web.Controllers;

namespace DRE.UI.Web.Core
{
    public class MyDependencyResolver : IDependencyResolver
    {
        #region Implementation of IDependencyResolver

        /// <summary>
        /// Resolves singly registered services that support arbitrary object creation.
        /// </summary>
        /// <returns>
        /// The requested service or object.
        /// </returns>
        /// <param name="serviceType">The type of the requested service or object.</param>
        public object GetService(Type serviceType)
        {
            switch (serviceType.Name)
            {
                case "BookController":
                    return new BookController(new BookService());

                default:
                    return null;
            }
        }

        /// <summary>
        /// Resolves multiply registered services.
        /// </summary>
        /// <returns>
        /// The requested services.
        /// </returns>
        /// <param name="serviceType">The type of the requested services.</param>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return null;
        }

        #endregion
    }
}