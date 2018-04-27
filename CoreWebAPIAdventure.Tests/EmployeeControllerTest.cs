using CoreWebAPIAdventure.Controllers;
using CoreWebAPIAdventure.DataModel;
using CoreWebAPIAdventure.Repository.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace CoreWebAPIAdventure.Tests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void EmployeeControllerTest_NotNull() {
            #region ARRANGE
           
            AppSettings appsettingsOptions = new AppSettings() {  ConnectionString = "test" };
            var mockAppSettingsOption = new Mock<IOptions<AppSettings>>();
            mockAppSettingsOption.Setup(x=>x.Value).Returns(appsettingsOptions);

            var mockData = GetEmployeeTestData();
            var mockRepository = new Mock<IEmployeeRepository>();
            mockRepository.Setup(x => x.GetEmployees()).Returns(mockData);
          
            #endregion

            #region ACT
            var empController = new EmployeeController(mockRepository.Object, mockAppSettingsOption.Object);
            var response = empController.Get();

            #endregion

            Assert.IsNotNull(response);

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
