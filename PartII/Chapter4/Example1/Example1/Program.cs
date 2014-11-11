using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Example1
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            //Cast example 1
            //No cast needed
            Object o1 = new Employee();
            Employee e1 = (Employee) o1;

            //Cast example 2
            /* this line of codes will work both runtime and compile time
             * because m object has a IS - A relation, in fact it is a derived class from Employee class
             */
            Manager m = new Manager();
            PromoteEmployee(m);
            
            /* this line of codes will cause a problem at runtime
             * because newYears object is not Employee or a derived class from Employee
             * at compile time, it works because the parameter for PromoteEmployee is an instance of object
             * in other word, DateTime object is derived from Object
             */
            //DateTime newYears = new DateTime(2013, 1, 1);
            //PromoteEmployee(newYears);

            //Casting with the C# is and as Operators
            Object o2 = new Object();
            Boolean b1 = (o2 is Object);
            Console.WriteLine(b1);
            Boolean b2 = (o2 is Employee); 
            Console.WriteLine(b2);

            if (o2 is Employee)
            {
                Employee e2 = (Employee) o2;
            }

            Employee e3 = o2 as Employee;
            if (e3 != null)
            {
                
            }

            //Checking Table

        }

        private static void PromoteEmployee(Object o)
        {
            Employee e = (Employee) o;
        }
    }

    internal class Employee
    {
        
    }

    internal class Manager : Employee
    {
        
    }

    internal class B
    { // Base class
    }
    internal class D : B
    { // Derived class
    }
}
