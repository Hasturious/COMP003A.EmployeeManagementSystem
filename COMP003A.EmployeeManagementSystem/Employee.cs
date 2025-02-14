using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// Defines the Employee class which has mutliple variables deependent on user input
    /// </summary>
    internal class Employee
    {
        //Private Fields
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        //Properties

        /// <summary>
        /// Adds EmployeeID thats read only
        /// </summary>
        public string EmployeeId
        {
            get { return _employeeId; }
        }

        /// <summary>
        /// Gets/Sets first name
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            { _firstName = value; }
        }
        /// <summary>
        /// Gets/Sets last name
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {  _lastName = value; }
        }
        /// <summary>
        /// Gets/Sets middle name
        /// </summary>
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        /// <summary>
        /// Gets/Sets the salary of the employee.
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        /// <summary>
        /// Constructs the class with details
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <param name="FirstName"></param>
        /// <param name="MiddleName"></param>
        /// <param name="LastName"></param>
        /// <param name="Salary"></param>
        /// <exception cref="ArgumentException"></exception>
        public Employee(string EmployeeId, string FirstName, string MiddleName, string LastName, double Salary)
        {
            if (string.IsNullOrWhiteSpace(EmployeeId))
            {
                throw new ArgumentException("ID cannot be empty. Please try again.");
            }
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                throw new ArgumentException("First name cannot be empty. Please try again.");
            }
            if (string.IsNullOrWhiteSpace(LastName))
            {
                throw new ArgumentException("Last name cannot be empty. Please try again.");
            }
            if (Salary < 0 || double.IsNaN(Salary))
            {
                throw new ArgumentException("Salary cannot be less than 0. Please enter a valid value.");
            }

            _employeeId = EmployeeId;
            _firstName = FirstName;
            _middleName = MiddleName;
            _lastName = LastName;
            _salary = Salary;
        }
        /// <summary>
        /// prints full name
        /// </summary>
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
        }
        /// <summary>
        /// Displays all employee info
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            PrintFullName();
            Console.WriteLine($"Salary: {Salary:F2} ID: {EmployeeId}");
        }
    }
}
