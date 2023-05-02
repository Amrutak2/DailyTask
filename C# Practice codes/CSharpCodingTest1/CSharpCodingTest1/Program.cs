using System;
using System.Collections.Generic;

namespace CSharpCodingTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Employee Emp = new Employee();
            // Emp.AddEmployee();
            // Emp.Display();
            //list
            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(new Employee("amk"));
            EmpList.Add(new Employee("lmn"));

            Console.WriteLine("The list of employee is :");
            foreach (Employee emp in EmpList)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("List Contains " + EmpList.Count + " Employees");


            //arrayyy
            //int n;
            //Console.WriteLine("Enter size of array: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] arrayname = new int[n];
            //Console.WriteLine("Enter elements: ");
            //for (int i = 0; i < arrayname.Length; i++)
            //{
            //    //Console.WriteLine(arrayname[i]);
            //   arrayname[n]  = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Array elements are:");
            //foreach(int it in arrayname)
            //{
            //    Console.WriteLine(it);
            //}
        }
    }
}
