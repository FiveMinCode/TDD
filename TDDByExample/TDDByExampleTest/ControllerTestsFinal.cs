using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using TDDByExample;
using TDDByExample.Controllers;
using TDDByExample.Model;
using TDDByExample.Service;

namespace TDDByExampleTest
{
    [TestClass]
    public class ControllerTestsFinal
    {
        [TestMethod]
        public void Get_Cutomer_On_LastName_Search()
        {
            //Arrange
            //user provides the last name
            var customers = new List<Customer>();
            string lastName = string.Empty;
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(t => t.GetCustomers(It.IsAny<string>()))
                .Returns(new List<Customer>() { new Customer() { FirstName = "Test", LastName = "Test" } });
            var controller = new CustomerController(mockCustomerService.Object);
            //Act
            //Search action
            customers = controller.GetCustomers(lastName);
            //Assert
            // list of customer
            Assert.IsTrue(customers != null && customers.Count > 0);
        }

        [TestMethod]
        public void Add_User()
        {
            //Arrange
            //provide the user details
            var user = new User();
            var mockUserService = new Mock<IUserService>();
            mockUserService.Setup(t => t.Add(It.IsAny<User>())).Returns(true);
            var controller = new UserController(mockUserService.Object);
            //Act
            // save action
            var result = controller.Add(user);
            //Assert
            // checking the user is saved
            Assert.IsTrue(result);
        }
    }
}
