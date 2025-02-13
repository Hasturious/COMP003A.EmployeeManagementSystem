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
            //creating an instance of the employee class and validating it
            try
            {
                Employee myEmployee = new Employee("Alpha", "Bravo", "Charlie", -5000);
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
