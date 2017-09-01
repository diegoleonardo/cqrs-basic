using System;
using System.Collections.Generic;
using simple.cqrs.data.storage.Mocks.Domain;
using System.Linq;

namespace simple.cqrs.data.storage.Mocks
{
    public static class PersonStorageSet
    {
        public static IList<Person> Persons = new List<Person>() {
            new Person (){ Id = 1, Firstname = "Diego", Lastname = "Santos", Birthdate = new DateTime(1985, 05, 15) },
            new Person (){ Id = 2, Firstname = "Gabriel", Lastname = "Duarte", Birthdate = new DateTime(1995, 08, 10) },
            new Person (){ Id = 3, Firstname = "Fabiana", Lastname = "Castanho", Birthdate = new DateTime(1985, 10, 20) },
            new Person (){ Id = 4, Firstname = "Mari", Lastname = "Não sei o sobrenome", Birthdate = new DateTime(1995, 04, 15) }
        };

        public static int RetornaIdParaInsercao()
        {
            return Persons.Max(x => x.Id) + 1;
        }
    }
}
