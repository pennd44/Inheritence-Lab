using System;

namespace Lesson7
{
    public class Employee
    {
        public string name;
        public string salary;
        public string hireDate;
        public Employee(string name, string salary, string hireDate)
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = hireDate;
        }
        public virtual void getName() {
            Console.WriteLine("Name: " + name);
        }
        public virtual void getSalary() {
            Console.WriteLine("Salary: " + salary);
        }
        public virtual void hiredDate() {
            Console.WriteLine("Hire Date: " + hireDate);
        }
    }
    public class Engineer: Employee
    {
        public string schoolAttended;
        public Engineer(string name, string salary, string hireDate, string schoolAttended)
            :base(name, salary, hireDate)
        {
            this.schoolAttended = schoolAttended;
        }
    }
    public class SoftwareEngineer: Engineer
    {
        public SoftwareEngineer(string name, string salary, string hireDate, string schoolAttended) :base(name, salary, hireDate, schoolAttended) { }
        public override void getSalary()
        {
            Console.WriteLine("Salary: Sorry, this employee's salary is private.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SoftwareEngineer bryan = new SoftwareEngineer("Bryan", "$1,000,000,000", "100 BC", "Woz U");
            Engineer leo = new Engineer("Leo", "$1000", "11/22/21", "Grass U");
            leo.getName();
            leo.getSalary();
            leo.hiredDate();
            Console.WriteLine("------------------------------------");
            bryan.getName();
            bryan.getSalary();
            bryan.hiredDate();
        }
    }
}
