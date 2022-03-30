using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class PersonManager
    {
        List<Person> persons = new List<Person>
        {
            new Person
            {
                ID=1,
                Name="Ümit",
                LastName="Şahin"
            },
             new Person
            {
                ID=2,
                Name="Enes",
                LastName="Güzel"
            },
              new Person
            {
                ID=3,
                Name="Mevlüt",
                LastName="Ateş"
            }
        };

        public int List()
        {
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.ID}-{item.Name} {item.LastName}");
            }

            return persons.Count;
        }
    }
}
