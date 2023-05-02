using System;

namespace CSharpCodingTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp = new Employee();
            emp.GetDetails();
            emp.Calculate();
            emp.CalculateSalary();
            emp.Display();
            
        }
    }
}
