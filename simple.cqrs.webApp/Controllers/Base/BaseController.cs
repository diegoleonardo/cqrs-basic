using simple.cqrs.queries.Interfaces;
using System.Web.Mvc;

namespace simple.cqrs.webApp.Controllers.Base
{
    public class BaseController : Controller
    {
        protected readonly IQueryDispatcher _queryDispatcher;

        public BaseController(IQueryDispatcher queryDispatcher)
        {
            _queryDispatcher = queryDispatcher;
        }
    }
}