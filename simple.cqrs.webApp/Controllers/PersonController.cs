using System.Web.Mvc;
using simple.cqrs.webApp.Models;
using simple.cqrs.queries.Interfaces;
using simple.cqrs.queries.Implementation;
using simple.cqrs.webApp.Controllers.Base;
using simple.cqrs.applicationService.Services;
using simple.cqrs.queries.Implementation.QueryResults;
using simple.cqrs.applicationService.DataTransferObjects;

namespace simple.cqrs.webApp.Controllers
{
    public class PersonController : BaseController
    {
        private readonly IPersonAplicationService _personAppService;

        public PersonController(IPersonAplicationService personAppService, IQueryDispatcher queryDispatcher):base(queryDispatcher)
        {
            _personAppService = personAppService;
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
            var query = new FindPersonByIdQueryParameter(id.ToString());
            
            var person = _queryDispatcher.Dispatch<FindByIdQueryResult, FindPersonByIdQueryParameter>(query);

            return Json(new { success = true, result = person }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult FindByNome(string nome)
        {
            var query = new FindPersonByNameParameter (nome);

            var person = _queryDispatcher.Dispatch<FindByNamePersonQueryResult, FindPersonByNameParameter >(query);

            return Json(new { success = true, result = person }, JsonRequestBehavior.AllowGet);
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
            var query = new FindPersonByIdQueryParameter(personId.ToString());

            var queryResult = _queryDispatcher.Dispatch<FindByIdQueryResult, IQuery>(query);

            PersonViewModel person = (PersonViewModel) queryResult;

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