using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternMatching
{
    class Program
    {

        class Employee
        {

            public int ID;
            public string Name;
        }

        class Developers : Employee
        {
            public int Add (int a, int b)
            {

                Console.WriteLine(a + b);
                return a + b;
                
            }

            
        }
        class Designers : Employee
        {

        }



        static void Main(string[] args)
        {
            var emp = new Employee();
            Console.Write("Enter Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name");
            string name = Console.ReadLine();


            var dev = new Developers()
            {
                ID = id, Name = name
            };
            var des = new Designers()
            {
                ID = 02, Name = "AHMED"
            };
            System.Console.WriteLine("Enter your first number");
            int a = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter your Second Number");
            int b = Convert.ToInt32(Console.ReadLine());



             dev.Add(a, b);
            switch(dev)
            {
                case Employee e when (e.ID >= 03):
                    Console.WriteLine($"Employee Name:{e.Name}");
                    break;
            }   

            Console.ReadKey();
            
            /*
            var myData = "FAHAD";
            var myData2 = myData is string ? "Yes it is " : "Not a string";
            var myData3 = myData is string p ? p : "Not a String";
            Console.WriteLine(myData2);
            Console.WriteLine(myData3);
            Console.ReadKey();
            */
        }
    }
}
