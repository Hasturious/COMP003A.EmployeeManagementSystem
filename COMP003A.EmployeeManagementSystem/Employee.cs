using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace COMP003A.EmployeeManagementSystem
{
    internal class Employee
    {
        //Private Fields
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        //Properties
        public string EmployeeId
        {
            get { return _employeeId; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {  _lastName = value; }
        }
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Employee(string EmployeeId, string FirstName, string MiddleName, string LastName, double Salary)
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                throw new ArgumentException("First name cannot be empty. Please try again.");
            }
            if (string.IsNullOrWhiteSpace(LastName))
            {
                throw new ArgumentException("Last name cannot be empty. Please try again.");
            }
            if (Salary < 0)
            {
                throw new ArgumentException("Salary cannot be less than 0. Please enter a valid value.");
            }

            _employeeId = EmployeeId;
            _firstName = FirstName;
            _middleName = MiddleName;
            _lastName = LastName;
            _salary = Salary;
        }
        //prints full name
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
        }
        public void DisplayEmployeeInfo()
        {
            PrintFullName();
            Console.WriteLine($"Salary: {Salary} ID: {EmployeeId}");
        }
    }
}
