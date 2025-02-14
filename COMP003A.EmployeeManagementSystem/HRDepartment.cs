using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Handles employee relations and recruitment
namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// the HR department class which is dependent on the Department and IDerpartmentOptertaion class/interface
    /// </summary>
    internal class HRDepartment : Department, IDepartmentOperations
    {
        /// <summary>
        /// Constructs the HRDepartment
        /// </summary>
        public HRDepartment() : base("HR Department") {}
        /// <summary>
        /// Provides an output for the HRDepartment when called by GetDepartmentDetails()
        /// </summary>
        /// <returns>a string</returns>
        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment";
        }
        /// <summary>
        /// When Operate() is called on HR write this string
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("HR Department is online.");
        }
    }
}
