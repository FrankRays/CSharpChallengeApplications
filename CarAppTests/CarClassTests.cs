using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobiles;
using CSharpChallengeProject01;

namespace CarAppTests
{
    [TestClass]
    public class CarClassTests
    {
        [TestMethod]
        public void CarClass_CanSetColorString()
        {
            // Arrange
            string expectedResponse = "Red";
            Car newCar = new Car();
            newCar.Color = "Red";

            // Act
            string response = newCar.Color;

            // Assert
            Assert.AreEqual(response, expectedResponse);
        }
        [TestMethod]
        public void CarClass_CanSetModelString()
        {
            // Arrange
            string expectedResponse = "Ford";
            Car newCar = new Car();
            newCar.Model = "Ford";

            // Act
            string response = newCar.Model;

            // Assert
            Assert.AreEqual(response, expectedResponse);
        }
        [TestMethod]
        public void CarClass_CanSetMakeString()
        {
            // Arrange
            string expectedResponse = "Dragon";
            Car newCar = new Car();
            newCar.Make = "Dragon";

            // Act
            string response = newCar.Make;

            // Assert
            Assert.AreEqual(response, expectedResponse);
        }
    }
}
