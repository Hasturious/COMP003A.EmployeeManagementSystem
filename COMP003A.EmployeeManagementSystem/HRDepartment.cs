using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Handles employee relations and recruitment
namespace COMP003A.EmployeeManagementSystem
{
    internal class HRDepartment : Department, IDepartmentOperations
    {
        public HRDepartment() : base("HR Department") {}

        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment";
        }
        public void Operate()
        {
            Console.WriteLine("HR Department is online.");
        }
    }
}
