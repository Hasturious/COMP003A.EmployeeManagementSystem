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
        private string _employeeId = "2560";
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
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please Enter a Name");
                }
                _firstName = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please Enter a Name");
                }
                _lastName = value;
            }
        }
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Please Enter a Valid Salary");
                }
                _salary = value;
            }
        }
        public Employee(string FirstName, string MiddleName, string LastName, double Salary)
        {
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