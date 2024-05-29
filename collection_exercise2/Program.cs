using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Person> persons = new List<Person>()
        {
            new Person() { Name = "Joe", Age = 24 },
            new Person() { Name = "Jake", Age = 22 },
            new Person() { Name = "Tim", Age = 23 }
        };

        object[] data = new object[]
        {
            5.5f, 10.5f, 200.25d, 10.5f, 5.5d, 2, 3, 4, "apple", "banana", "grapes", "orange", persons
        };

        // Variables to store sums and strings
        double sumOfDoubles = 0;
        int sumOfInts = 0;
        List<string> strings = new List<string>();

        foreach (var obj in data)
        {
            if (obj is float)
            {
                sumOfDoubles += (float)obj;
            }
            else if (obj is double)
            {
                sumOfDoubles += (double)obj;
            }
            else if (obj is int)
            {
                sumOfInts += (int)obj;
            }
            else if (obj is string)
            {
                strings.Add((string)obj);
            }
            else if (obj is List<Person> personList)
            {
                // Print person details
                foreach (var person in personList)
                {
                    Console.WriteLine($"name : {person.Name}, age : {person.Age}");
                }

                // Calculate and print average age
                double averageAge = personList.Average(p => p.Age);
                Console.WriteLine($"average age : {averageAge}");
            }
        }

        // Print sums
        Console.WriteLine($"sum of int is: {sumOfInts}");
        Console.WriteLine($"sum of double is: {sumOfDoubles}");

        // Print strings
        foreach (var str in strings)
        {
            Console.WriteLine($"the fruits are: {str}");
        }
    }
}
