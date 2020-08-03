using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTest
{
    public class People
    {
        public List<Person> people = new List<Person>();
        public void addToList(Person person)
        {
            this.people.Add(person);
        }
    }
}
