using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Manages technical resources and infrastructure
namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// the IT department class which is dependent on the Department and IDerpartmentOptertaion class/interface
    /// </summary>
    internal class ITDepartment : Department, IDepartmentOperations
    {
        /// <summary>
        /// Constructs the ITDepartment
        /// </summary>
        public ITDepartment() : base("IT Department") {}

        /// <summary>
        /// Provides an output for the ITDepartment when called by GetDepartmentDetails()
        /// </summary>
        /// <returns>a string</returns>
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure";
        }
        /// <summary>
        /// When Operate() is called on IT write this string
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("IT Department is online.");
        }
    }
}
