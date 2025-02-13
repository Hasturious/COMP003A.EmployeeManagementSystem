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
        private string _employeeId = "001";
        private string _firstName = "Johnathan";
        private string _middleName = "Rodrigo";
        private string _lastName = "Cruz";
        private double _salary = 0;

        //Properties
        public string EmployeeId
        {
            get { return EmployeeId; }
        }

        public string FirstName
        {
            get { return FirstName; }
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
            get { return LastName; }
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
            get { return MiddleName; }
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
        public void PrintFullName()
        {
            Console.WriteLine(FirstName , MiddleName, LastName);
        }
    }
}