using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
            new Person
            {
               FullName = "Admin Admin",
               Age = 35
               },

            new Person
            {
               FullName = "Admin Admin",
               Age = 35
               }              
            };


            List<Car> car = new List<Car>
            {
            new Car
            {
               Mark = "BMW",
               Year = 2000
               },

                new Car
               {
               Mark = "Mercedes",
               Year = 2000
               }
            };


            List<Home> home = new List<Home>
            {
            new Home
            {
               Adress = "Улица Пушкина",
               Square = 150
               },

                new Home
               {
               Adress = "Улица Пушкина",
               Square = 200
               }
            };
            Console.ReadKey();
        }
    }
}
