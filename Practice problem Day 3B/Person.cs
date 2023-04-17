using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_problem_Day_3B
{
    public class Person
    {

        private string name;
        private int age;

        // default constructor
        public Person()
        {
            name = "";
            age = 0;
        }

        // parameterized constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
