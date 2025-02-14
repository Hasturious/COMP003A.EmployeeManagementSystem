using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// The department class which is the parent of IT and HR department classes
    /// </summary>
    abstract class Department
    {
        /// <summary>
        /// Gets/Sets the name of the department
        /// </summary>
        public string DepartmentName {  get; set; }
        /// <summary>
        /// Department constructor
        /// </summary>
        /// <param name="departmentName"></param>
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }
        /// <summary>
        /// this method applies to subclasses of Department
        /// </summary>
        /// <returns>a string on the details of the department</returns>
        public abstract string GetDepartmentDetails();
        /// <summary>
        /// concrete method that children inherit and displays the name of the department
        /// </summary>
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department Name: {DepartmentName}");
        }
    }
}
