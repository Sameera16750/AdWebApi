using System.Collections.Generic;
using System.Linq;
using testapp3.Modals.DBAuth;
using testapp3.Modals.Entity;
using testapp3.Repositories.Interfaces;

namespace testapp3.Repositories.Implements
{
    public class EmployeeRepoImpl : IEmployeeRepo
    {
        private readonly DBAuthContext _context;

        public EmployeeRepoImpl(DBAuthContext context)
        {
            _context = context;
        }

        public List<EEmployee> getAllEmployees()
        {
            return _context.employee.ToList();
        }
    }
}
