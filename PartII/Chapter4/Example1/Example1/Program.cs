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
            Object o = new Employee();
            Employee e = (Employee) o;

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
}
