using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    abstract class Department
    {
        public string DepartmentName {  get; set; }

        public abstract void GetDepartmentDetails();

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine(DepartmentName);
        }
    }
}
