using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class LinqMethodsUsageClass
    {
        static readonly List<Person> _persons = new List<Person>
        {
            new Person
            {
                Name = "John",
                Age = 20
            },
            new Person
            {
                Name = "Mary",
                Age = 35
            },
            new Person
            {
                Name = "Arthur",
                Age = 78
            },
            new Person
            {
                Name = "Mike",
                Age = 27
            },
            new Person
            {
                Name = "Judy",
                Age = 42
            },
            new Person
            {
                Name = "Tim",
                Age = 8
            }
        };

        public static void MethodToUseWhereLinq()
        {
        // Where: filter a sequence of values based on a predicate - returns IEnumerable
        // filter: gives a new array which satisfies the condition provided

            var youngsters = _persons.Where(person => person.Age < 30).ToList();
            Console.WriteLine(youngsters);
            /*
             *Same as you write filter in JS
             * let youngsters = _persons.filter(person => person.Age < 30);
             */

        }

        public static void MethodToUseSelectLinq()
        {
            // Select and map both gives the selected item properties
           var names =  _persons.Select(person => person.Name);
            Console.WriteLine(names);
            /*
             * its equivalent would be map ->
             * let names = _persons.map(person => person.Name);
             * === both returns the resultant set
             */
        }

        public static void MethodToUseAllLinq()
        {
            var isAllYoungsters = _persons.All(person => person.Age < 25);
            Console.WriteLine(isAllYoungsters);
            /*
             *its equivalent would be every ->
             * let isAllYoungsters = _persons.every(person => person.Age < 25);
             * === both returns a bool
             */
        }
    }
}
