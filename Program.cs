using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> employees = new List<employee>();
            employees.Add(new employee() { name = "Anurag", gender = 0 });
            employees.Add(new employee() { name = "Pranaya", gender = 1 });
            employees.Add(new employee() { name = "Priyanka", gender = 2 });
            employees.Add(new employee() { name = "Sambit", gender = 3 });
            foreach(var emp in employees)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", emp.name, GetGender(emp.gender));
            }
            Console.ReadLine();

        }
        public static string GetGender(int gender)
        {
            switch(gender)
            {
                case 0:
                    return "un known";
                case 1:
                    return " male";
                case 2:
                    return "female";
                default:
                    return " Invalid Data for gender";
            }

        }
    }
    public class employee
    {
        public string name { get; set; }
        public int gender { get; set; }
    }
}
