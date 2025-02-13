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
            //creating an instance of the employee class
            Employee myEmployee = new Employee("Alpha", "Bravo", "Charlie", 5000);
            //creating an instance of the departments
            HRDepartment HR = new HRDepartment();
            ITDepartment IT = new ITDepartment();

            Console.WriteLine("Employee Details");
            myEmployee.DisplayEmployeeInfo();
            /*
            Console.WriteLine("HR Department Details:");
            HRDepartment.DisplayDerpartmentInfo()
            */
        }
    }
}
