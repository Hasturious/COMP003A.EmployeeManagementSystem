using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    abstract class Department
    {
        //property
        public string DepartmentName {  get; set; }
        //constructor
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }
        //abstract method
        public abstract string GetDepartmentDetails();
        //concrete method
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department Name: {DepartmentName}");
        }
    }
}
