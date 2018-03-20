using GroupBProject;
using GroupBProject.Business;
using NUnit.Framework;
using System.Collections.Generic;

namespace ProjectUnitTests
{
    [TestFixture]
    public class InspectorTests
    {
        [Test]
        public void Inspector_NewInspector_CreatesCorrectFirstName()
        {
            //Arrange and Act
            //Inspector inspector = new Inspector("John Doe", "jdoe@email.com", "402-555-5555", true, new List<DailyAvailability>(),
            //                      new List<Qualification>());

            Inspector inspector = new Inspector("John", "Smith", "jdoe@email.com", "402-555-5555", true, new List<DailyAvailability>(),
                                  new List<Qualification>());

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(inspector.FirstName, Is.EqualTo("John"));
                Assert.That(inspector.FirstName, Is.EqualTo("John"));
            });
        }

        [Test]
        public void Inspector_NewInspector_CreatesCorrectEmail()
        {
            //Arrange and Act
            Inspector inspector = new Inspector("John", "Smith", "jdoe@email.com", "402-555-5555", true, new List<DailyAvailability>(),
                new List<Qualification>());

            //Assert
            Assert.That(inspector.Email, Is.EqualTo("jdoe@email.com"));
        }

        [Test]
        public void Inspector_NewInspector_CreatesCorrectPhoneNumber()
        {
            //Arrange and Act
            Inspector inspector = new Inspector("John", "Smith", "jdoe@email.com", "402-555-5555", true, new List<DailyAvailability>(),
                new List<Qualification>());

            //Assert
            Assert.That(inspector.Phone, Is.EqualTo("402-555-5555"));
        }

        [Test]
        public void Inspector_NewInspector_CreatesEmptyDailyAvailabilityList()
        {
            //Arrange and Act
            Inspector inspector = new Inspector("John", "Smith", "jdoe@email.com", "402-555-5555", true, new List<DailyAvailability>(),
                new List<Qualification>());

            //Assert
            Assert.That(inspector.WeeklyAvailability, Is.Empty);
        }

        [Test]
        public void Inspector_NewInspector_CreatesEmptyQuailificationList()
        {
            //Arrange and Act
            Inspector inspector = new Inspector("John", "Smith", "jdoe@email.com", "402-555-5555", true, new List<DailyAvailability>(),
                new List<Qualification>());

            //Assert
            Assert.That(inspector.Qualifications, Is.Empty);
        }

        [Test]
        public void Inspector_ToString_ReturnInspectorNameJohnDoe()
        {
            //Arrange
            Inspector inspector = new Inspector("John", "Smith", "jdoe@email.com", "402-555-5555", true, new List<DailyAvailability>(),
                new List<Qualification>());

            //Act
            var result = inspector.ToString();

            //Assert
            Assert.That(result, Is.EqualTo("John Smith"));
        }
    }
}