using System.Collections.Generic;
using testapp3.Modals.Entity;
using testapp3.Payloads;
using testapp3.Repositories.Interfaces;
using testapp3.Services.InterFaces;

namespace testapp3.Services.Implements
{
    public class EmployeeImpl : IEmployee
    {
        IEmployeeRepo employeeRepo;

        public EmployeeImpl(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        public List<EmployeePayload> getAllEmployees()
        {
            List<EEmployee> eEmployees = employeeRepo.getAllEmployees();
            List<EmployeePayload> employees = new List<EmployeePayload>();
            for(int i = 0; i < eEmployees.Count; i++)
            {
                EmployeePayload employeePayload = new EmployeePayload();
                employeePayload.EmployeeID = eEmployees[i].EmployeeID;
                employeePayload.EmployeeName = eEmployees[i].EmployeeName;
                employeePayload.EmployeeAge=eEmployees[i].EmployeeAge;
                employeePayload.status = eEmployees[i].status;
                employees.Add(employeePayload);
            }
            return employees;
        }
    }
}
