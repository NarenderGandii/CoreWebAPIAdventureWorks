using CoreWebAPIAdventure.DataModel;
using CoreWebAPIAdventure.Repository.Interfaces;
using Microsoft.ApplicationBlocks.Data;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CoreWebAPIAdventure.Repository {
    public class EmployeeRepository : IEmployeeRepository {
        public IAdventureSqlConnection _adventureSqlConnection { get; set; }
        public ISqlDBContext _dbContext { get; set; }
        public EmployeeRepository(IAdventureSqlConnection adventureSqlConnection, ISqlDBContext dbContext) {
            _adventureSqlConnection = adventureSqlConnection;
            _dbContext = dbContext;
        }
        public List<Employee> GetEmployees() {
            List<Employee> lstEmployee;
            using (var conn = _adventureSqlConnection.GetSqlConnection()) {
                if (conn == null)
                    return null;
                using (var cmd = new SqlCommand("select *  from HumanResources.Employee", conn)) {
                    using (SqlDataReader dtReader = _dbContext.DataReader(conn.ConnectionString, CommandType.Text, cmd.CommandText)) {
                        if (!dtReader.HasRows)
                            return null;
                        lstEmployee = new List<Employee>();
                        while (dtReader.Read()) {
                            lstEmployee.Add(new Employee() { BirthDate = Convert.ToDateTime(dtReader["BirthDate"]), BusinessEntityID = Convert.ToInt16(dtReader["BusinessEntityID"]), HireDate = Convert.ToDateTime(dtReader["HireDate"]), JobTitle = dtReader["JobTitle"].ToString() });
                        }
                    }
                }

            }
            return lstEmployee;
        }

    }
}
