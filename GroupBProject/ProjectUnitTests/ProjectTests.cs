using GroupBProject;
using NUnit.Framework;

namespace ProjectUnitTests
{
    [TestFixture]
    public class ProjectTests
    {
        [Test]
        public void Project_NewProject_CreatesNewProject()
        {
            //Arrange
            Project project = new Project("New Job", "This is a new job", "1111 Fair St");

            //Act and Assert
            Assert.Multiple(() =>
            {
                Assert.That(project.Title, Is.EqualTo("New Job"));
                Assert.That(project.Description, Is.EqualTo("This is a new job"));
                Assert.That(project.Address, Is.EqualTo("1111 Fair St"));
            });
        }

        [Test]
        public void ToString_ConvertsObjectToString_ReturnsProjectAndProjectTitle()
        {
            //Arrange
            Project project = new Project();
            project.Title = "Awesome Project";

            //Act
            var result = project.ToString();

            //Assert
            Assert.That(result, Is.EqualTo("Project Awesome Project"));
        }
    }
}