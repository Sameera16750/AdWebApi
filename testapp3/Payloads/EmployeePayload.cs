using System.ComponentModel.DataAnnotations;

namespace testapp3.Payloads
{
    public class EmployeePayload
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public int EmployeeAge { get; set; }

        public int status { get; set; }

        public EmployeePayload()
        {

        }

       public EmployeePayload(int employeeID, string employeeName, int employeeAge, int status)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            EmployeeAge = employeeAge;
            this.status = status;
        }
    }
}
