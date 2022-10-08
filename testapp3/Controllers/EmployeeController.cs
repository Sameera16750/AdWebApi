using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using testapp3.Payloads;
using testapp3.Services.InterFaces;

namespace testapp3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpGet(Name ="getAllEmployees")]
        public List<EmployeePayload> getAllEmployees()
        {
            return  _employee.getAllEmployees();
        }
    }
}
