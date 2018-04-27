using CoreWebAPIAdventure.DataModel;
using CoreWebAPIAdventure.Repository.Interfaces;
using Microsoft.ApplicationBlocks.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CoreWebAPIAdventure.Repository.Tests {
    //AAA - Arrange, Act, Assert
    [TestClass]
    public class EmployeeRepositoryTest {
        [TestMethod]
        public void GetEmployees_ReturnsNull() {

            #region ARRANGE

            SqlConnection conn = null;//new SqlConnection() { ConnectionString = "Server=localhost;Database=AdventureWorks2014;Trusted_Connection=True;" };
            var mockConn = new Mock<IAdventureSqlConnection>();
            mockConn.Setup(x => x.GetSqlConnection()).Returns(conn);
            var mockDBContext = new Mock<ISqlDBContext>();
            SqlDataReader reader = null; //SqlHelper.ExecuteReader("", CommandType.Text, "");
            mockDBContext.Setup(x => x.DataReader(string.Empty,  CommandType.StoredProcedure, string.Empty)).Returns(reader);
            #endregion

            #region ACT

            var empRepo = new EmployeeRepository(mockConn.Object, mockDBContext.Object);
            var response = empRepo.GetEmployees();

            #endregion

            Assert.IsNull(response);
        }

        public List<Employee> GetEmployeeTestData() {
            var lstEmp = new List<Employee>();
            lstEmp.Add(new Employee() {
                JobTitle = "tst"
            });
            return lstEmp;
        }
    }
}
