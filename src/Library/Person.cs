using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public int Age {get; private set; }
        public string  Name {get; private set;}

        private List<Person> children = new List<Person>();

        

        public ReadOnlyCollection<Person> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public void AddChildren(Person n)
        {
            this.children.Add(n);
        }

        public void Accept (IVisitor visitor)
        {
            visitor.Visit(this);
        }
        
    }
}
