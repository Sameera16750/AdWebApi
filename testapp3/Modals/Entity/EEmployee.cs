using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testapp3.Modals.Entity
{
    [Table("T_EMPLOYEE")]
    public class EEmployee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required] 
        public string EmployeeName { get; set; }

        [Required]
        public int EmployeeAge { get; set; }

        [Required]
        public int status { get; set; }

        public EEmployee()
        {

        }

       public EEmployee(int employeeID, string employeeName, int employeeAge, int status)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            EmployeeAge = employeeAge;
            this.status = status;
        }
    }
}
