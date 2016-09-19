using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephonebook.Models;

namespace Telephonebook
{

    class TelephoneBook
    {
        private List<Person> persons;

        public TelephoneBook()
        {
            persons = new List<Person>();
            persons.Add(new Person("Ad", "Baantjer"));
            persons.Add(new Person("Bob", "Stone"));
            persons.Add(new Person("Celine", "van Stakkeren"));
            persons.Add(new Person("Dirk", "Luiver"));
            persons.Add(new Person("Edwin", "Heuvel"));
            persons.Add(new Person("Fernando", "Alonso"));
            persons.Add(new Person("Greta", "Tafelen"));
            persons.Add(new Person("Hans", "van Beveren"));
            persons.Add(new Person("Irene", "Doremi"));
            persons.Add(new Person("Jan", "Zaterdag"));

        }
    }
}
