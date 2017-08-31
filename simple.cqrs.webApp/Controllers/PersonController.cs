using System.Web.Mvc;
using simple.cqrs.queries.Interfaces;
using simple.cqrs.queries.Implementation;
using simple.cqrs.applicationService.Services;
using simple.cqrs.applicationService.DataTransferObjects;
using simple.cqrs.webApp.Models;

namespace simple.cqrs.webApp.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonAplicationService _personAppService;
        private readonly IQueryDispatcher _queryDispatcher;

        public PersonController(IPersonAplicationService personAppService, IQueryDispatcher queryDispatcher)
        {
            _personAppService = personAppService;
            _queryDispatcher = queryDispatcher;
        }
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            IQuery query = new Query();

            query.Identificador = id.ToString();

            var dispatcher = _queryDispatcher.Dispatch<IQuery>(query);

            return Json(new { success = true, result = dispatcher }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(PersonViewModel person)
        {
            PersonDTO personDTO = person;

            _personAppService.Insert(personDTO);

            return View();
        }

        public ActionResult Edit(int personId)
        {
            PersonViewModel person = new PersonViewModel()
            {
                Id = 1,
                Firstname = "Diego",
                Lastname = "Santos",
                Birthdate = new System.DateTime(1985, 05, 15)
            };

            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(PersonViewModel person)
        {
            PersonDTO personDTO = person;

            _personAppService.Edit(personDTO);

            return View();
        }
    }
}