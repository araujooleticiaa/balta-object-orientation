using Balta.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new List<Course>();
            var carrers = new List<Career>();
            var carrerItem = new List<CareerItem>();

            var carrer = new Career(carrerItem, "carreira fullstack","");

            var carrerDotnet = new CareerItem(1,"carreria .net", "", null);
            var carrerNodejs = new CareerItem(2, "curso nodejs", "", null);
            var carrerReactjs = new CareerItem(3, "curso reactjs", "", null);

            var cursoDotnet = new Course("Curso de .net", "");
            var cursoNodejs = new Course("Curso de nodejs", "");
            var cursoReactjs = new Course("Curso de reactjs", "");

            carrers.Add(carrer);
            carrerItem.Add(carrerDotnet);
            carrerItem.Add(carrerNodejs);
            carrerItem.Add(carrerReactjs);


            foreach (var item in carrers)
            {
                Console.WriteLine(item.Title);

                foreach (var item1 in carrerItem.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item1.Title} - {item1.Order}");
                    Console.WriteLine();

                    foreach (var notification in item1.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

        }
    }
}
