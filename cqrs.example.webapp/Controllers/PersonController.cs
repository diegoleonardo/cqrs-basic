using cqrs.example.commands.Implementações;
using cqrs.example.webapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace cqrs.example.webapp.Controllers
{
    public class PersonController : Controller
    {
        private readonly InsertPersonCommandHandler _insertCommand;

        public PersonController()
        {
            _insertCommand = new InsertPersonCommandHandler();
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
    }
}