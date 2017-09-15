using System.Collections.Generic;

namespace simple.cqrs.webApp.Models
{
    public class AllPersonsViewModel
    {
        public IList<PersonViewModel> Persons { get; set; }

        public AllPersonsViewModel(IList<PersonViewModel> persons)
        {
            if (persons != null)
            {
                Persons = persons;
            }else
            {
                Persons = new List<PersonViewModel>();
            }
        }

        public IList<PersonViewModel> ReturnPersons()
        {
            return Persons;
        }
    }
}