using simple.cqrs.applicationService;
using simple.cqrs.applicationService.DataTransferObjects;
using simple.cqrs.webApp.Models;
using System.Web.Mvc;

namespace simple.cqrs.webApp.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonApplicationService _personService;

        public PersonController()
        {
            _personService = new PersonApplicationService();
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

        [HttpPost]
        public ActionResult Create(PersonViewModel person)
        {
            PersonDTO personDTO = person;

            _personService.Insert(personDTO);

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
            return View();
        }
    }
}