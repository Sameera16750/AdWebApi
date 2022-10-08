using System.Collections.Generic;
using testapp3.Payloads;

namespace testapp3.Services.InterFaces
{
    public interface IEmployee
    {
        public List<EmployeePayload> getAllEmployees();
    }
}
