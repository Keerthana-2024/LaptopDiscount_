using NUnit.Framework;
using System;

namespace LaptopDiscount
{
    [TestFixture]
    public class DiscountTests
    {
        [Test]
        public void CalculateDiscountedFor_PartTime_NoDiscount()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 1000m,
                Assert = 1000
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(employeeDiscount.Assert, Is.EqualTo(result));
        }

        [Test]
        public void CalculateDiscountedFor_PartialLoad_FivePercentDiscount()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartialLoad,
                Price = 950m,
                Assert = 902.50
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(employeeDiscount.Assert, Is.EqualTo(result));
        }

        [Test]
        public void CalculateDiscountedFor_FullTime_TenPercentDiscount()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 900m,
                Assert = 810
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(employeeDiscount.Assert, Is.EqualTo(result));
        }

        [Test]
        public void CalculateDiscountedFor_CompanyPurchasing_TwentyPercentDiscount()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 640m,
                Assert = 512
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(employeeDiscount.Assert, Is.EqualTo(result));
        }

        [Test]
        public void CalculateDiscountedFor_NegativePrice()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = -900m,
                Assert = -810
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(employeeDiscount.Assert, Is.EqualTo(result));
        }

        [Test]
        public void CalculateDiscountedFor_ZeroPrice()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 0m,
                Assert = 0
            };

            // Act
            var result = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.That(employeeDiscount.Assert, Is.EqualTo(result));
        }
    }
}
