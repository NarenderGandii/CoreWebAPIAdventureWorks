using CoreWebAPIAdventure.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebAPIAdventure.Repository.Interfaces {
    public interface IEmployeeRepository {
        List<Employee> GetEmployees();
    }
}
