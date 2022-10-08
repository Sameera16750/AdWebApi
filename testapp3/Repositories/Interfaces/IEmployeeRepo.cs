using System.Collections.Generic;
using testapp3.Modals.Entity;

namespace testapp3.Repositories.Interfaces
{
    public interface IEmployeeRepo
    {
        public List<EEmployee> getAllEmployees();
    }
}
