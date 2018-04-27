using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreWebAPIAdventure.DataModel;
using Microsoft.Extensions.Options;
using CoreWebAPIAdventure.Repository;
using System.Net.Http;
using CoreWebAPIAdventure.Repository.Interfaces;

namespace CoreWebAPIAdventure.Controllers {
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller {
        public IEmployeeRepository _employeeRepository { get; set; }
        public AppSettings _appSettings { get; set; }
        public EmployeeController(IEmployeeRepository employeeRepository, IOptions<AppSettings> appSettings) {
            _employeeRepository = employeeRepository;
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult Get() {
            List<Employee> lstEmp = _employeeRepository.GetEmployees();
            if (lstEmp == null)
                return NotFound();
            return Ok(lstEmp);
        }
    }
}