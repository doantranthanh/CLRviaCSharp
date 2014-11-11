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
            Object o = new Employee();

            Employee e = (Employee) o;

            Manager m = new Manager();

            PromoteEmployee(m);

            DateTime newYears = new DateTime(2013, 1, 1);
            PromoteEmployee(newYears);
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
