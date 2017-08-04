using Microsoft.AspNetCore.Mvc;
using simple_cqrs.commands.Implementações.Person;
using simple_cqrs.webapp.Models;

namespace simple_cqrs.webapp.Controllers
{
    public class PersonController : Controller
    {
        private readonly InsertPersonCommandHandler _insertCommand;
        private readonly EditPersonCommandHandler _editCommand;
        public PersonController()
        {
            _insertCommand = new InsertPersonCommandHandler();
            _editCommand = new EditPersonCommandHandler();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonViewModel person)
        {
            InsertPersonCommand personCommand = person;

            var resultado = _insertCommand.Execute(personCommand);

            return View();
        }

        public IActionResult Edit(int personId)
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
        public IActionResult Edit(PersonViewModel person)
        {
            EditPersonCommand personCommand = person;
            var result = _editCommand.Execute(personCommand);

            return View();
        }
    }
}