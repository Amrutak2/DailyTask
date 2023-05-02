using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodingTest2
{
    class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;
        //public int empno { get; set; }
       // public string empname { get; set; }
        //public double salary { get; set; }
        //public double hra { get; set; }
        //public double ta { get; set; }
        //public double da { get; set; }
        //public double pf { get; set; }
        //public double tds { get; set; }
        //public double netsalary { get; set; }
        //public double grosssalary { get; set; }
        public Employee()
        {
            //this.empno = EmpNo;
            //this.empname = EmpName;
            //this.salary = Salary;
        }
        

        public void GetDetails()
        {
            Console.WriteLine("Enter Details: ");
            Console.WriteLine("Enter Number");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            Salary = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Employee Details are: \n No: {0} Name: {1} Salary: {2} HRA: {3} TA: {4} DA: {5} GrossSalary: {6} PF: {7} TDS: {8} NetSalary: {9}", EmpNo, EmpName, Salary, HRA, TA, DA, GrossSalary, PF, TDS, NetSalary);

        }
        public void Calculate ()
        {
            if(Salary < 5000)
            {
                HRA = (10 * Salary) / 100;
                TA = (5 * Salary)/ 100;
                DA = (15 * Salary) / 100;
            }
            else if(Salary < 10000)
            {
                HRA = (15 * Salary) / 100;
                TA = (10 * Salary) / 100;
                DA = (20 * Salary) / 100;
            }
            else if (Salary < 15000)
            {
                HRA = (20 * Salary) / 100;
                TA = (15 * Salary) / 100;
                DA = (25 * Salary) / 100;
            }
            else if (Salary < 20000)
            {
                HRA = (25 * Salary) / 100;
                TA = (20 * Salary) / 100;
                DA = (30 * Salary) / 100;
            }
            else if (Salary >= 20000)
            {
                HRA = (30 * Salary) / 100;
                TA = (25 * Salary) / 100;
                DA = (35 * Salary) / 100;
            }
            GrossSalary = Salary + HRA + TA + DA;
        }
        public void CalculateSalary()
        {
            PF = (10 * GrossSalary)/100;
            TDS = (18 * GrossSalary)/ 100;
            NetSalary = GrossSalary - (PF + TDS);
        }
        public void Display ()
        {
            Console.WriteLine("Employee Details are: \n No: {0} Name: {1} Salary: {2} HRA: {3} TA: {4} DA: {5} GrossSalary: {6} PF: {7} TDS: {8} NetSalary: {9}", EmpNo, EmpName, Salary, HRA, TA, DA, GrossSalary, PF, TDS, NetSalary);

        }
        

    }
}
