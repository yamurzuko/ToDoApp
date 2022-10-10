using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class PersonInformation
    {
        public int id;
        public string name;
        public string surname;

        public PersonInformation(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
    }
}