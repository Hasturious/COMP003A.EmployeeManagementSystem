// Author: Jean Bryant Figueroa
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getting user inputs
            Console.Write("Enter ID: ");
            string _employeeId = Console.ReadLine();
            Console.Write("Enter First Name: ");
            string _firstName = Console.ReadLine();
            Console.Write("Enter Middle Name: ");
            string _middleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string _lastName = Console.ReadLine();
            Console.Write("Enter Salary: ");
            try
            {

            }
            string salaryInput = Console.ReadLine();
            double _salary = 0;
            if (int.TryParse(salaryInput, out int number))
            {
               _salary = number;
            }
            else
            {
                throw new ArgumentException("Invalid salary input. Please enter a valid number.");
                Console.WriteLine($"Error: {ex.Message}");
            }

            //Console.WriteLine(_salary);
            
            //creating an instance of the employee class and validating it
                try
                {
                    Employee myEmployee = new Employee(_employeeId, _firstName, _middleName, _lastName, _salary);
                    myEmployee.DisplayEmployeeInfo();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            //creating an instance of the departments
            HRDepartment HR = new HRDepartment();
            ITDepartment IT = new ITDepartment();
            //Employee info
            //Console.WriteLine("Employee Details");
            

            Console.WriteLine(); //Spacing for readability in the console

            //HR department
            HR.DisplayDepartmentInfo();
            HR.Operate();
            Console.WriteLine(HR.GetDepartmentDetails());
            
            Console.WriteLine(); //Spacing for readability in the console

            //IT department
            IT.DisplayDepartmentInfo();
            IT.Operate();
            Console.WriteLine(IT.GetDepartmentDetails());
            
        }
    }
}
