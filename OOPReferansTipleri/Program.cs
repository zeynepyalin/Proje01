using System;

namespace OOPReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        // base class : Person
        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }
        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }
        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
