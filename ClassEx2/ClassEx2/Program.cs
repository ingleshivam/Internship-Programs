using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx2
{
    internal class Emp
    {
        private int empId;
        private string empName;
        private string deptName;
        private int salary;

        public void addEmp(int eid, string ename, string dname, int s)
        {
            empId = eid;
            empName = ename;
            deptName = dname;
            salary = s; 
        }

        public void displayEmp()
        {
            Console.WriteLine("Employee Id :" + empId);
            Console.WriteLine("Employee Name :" + empName);
            Console.WriteLine("Department Name :"+ deptName);
            Console.WriteLine("Salary : " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int id, salary;
            string empname, deptname;
            Console.Write("Enter Employee Id :");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name : ");
            empname = Console.ReadLine();

            Console.Write("Enter Department Name : ");
            deptname = Console.ReadLine();

            Console.Write("Enter Salary :");
            salary = Convert.ToInt32(Console.ReadLine());

            Emp e1 = new Emp();
            e1.addEmp(id,empname,deptname,salary);
            e1.displayEmp();
        }
    }
}
