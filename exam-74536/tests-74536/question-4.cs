using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tests_74536
{
    [TestFixture]
    public class CarRegistrationTests
    {
        [TestCase("12-34-567", "12-34-567")]
        [TestCase("99-88-777", "99-88-777")]
        [TestCase("AB-CDE-FG", "N/A")] // Invalid plate
        [TestCase("12-345-67", "N/A")] // Invalid plate
        [TestCase("123-45-67", "N/A")] // Invalid plate
        public void TestCheckPlate(string plate, string expectedResult)
        {
            CarRegistration carRegistration = new CarRegistration(plate);
            string actualResult = carRegistration.GetPlate();
            Assert.AreEqual(exp ectedResult, actualResult);
        }
}
