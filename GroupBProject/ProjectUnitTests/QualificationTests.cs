using GroupBProject.Business;
using NUnit.Framework;

namespace ProjectUnitTests
{
    [TestFixture]
    internal class QualificationTests
    {
        [Test]
        public void Qualification_ConstructorTest_CreatesCorrectQualification()
        {
            //Arrange
            Qualification qualificaiton = new Qualification("Painting", true);

            //Act
            var result = qualificaiton.Name;

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Painting"));
                Assert.That(qualificaiton.IsJobQualification, Is.True);
            });
        }

        [Test]
        public void QualificationToString_QualificaitonIsEqualToPainting_ReturnsPaintingAsString()
        {
            //Arrange
            Qualification qualificaiton = new Qualification("Painting", true);

            //Act
            var result = qualificaiton.ToString();

            //Assert
            Assert.That(result, Is.EqualTo("Painting"));
        }
    }
}