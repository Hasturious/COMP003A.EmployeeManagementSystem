using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Manages technical resources and infrastructure
namespace COMP003A.EmployeeManagementSystem
{
    internal class ITDepartment : Department, IDepartmentOperations
    {
        //base class constructor sets department name
        public ITDepartment() : base("IT Department") {}

        //overides ther abstract method to IT
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure";
        }
        public void Operate()
        {
            Console.WriteLine("IT Department is online.");
        }
    }
}
