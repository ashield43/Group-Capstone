using GroupBProject;
using GroupBProject.Business;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ProjectUnitTests
{
    [TestFixture]
    public class JobTests
    {
        [Test]
        public void Job_ConstructorTest_CreatesNewJob()
        {
            //Arrange
            Job job = new Job("The Job", "A newly created job", new DateTime(2018, 1, 20), 8, 17, new Qualification("Heating", true));

            //Act and Assert
            Assert.Multiple(() =>
            {
                Assert.That(job.Name, Is.EqualTo("The Job"));
                Assert.That(job.Description, Is.EqualTo("A newly created job"));
                Assert.That(job.Date, Is.EqualTo(new DateTime(2018, 1, 20)));
                Assert.That(job.StartTime, Is.EqualTo(8));
                Assert.That(job.EndTime, Is.EqualTo(17));
                Assert.That(job.RequiredQualification.Name, Is.EqualTo("Heating"));
            });
        }

        [Test]
        public void CheckInspectorQualifications_InspectorIsQualified_ReturnTrue()
        {
            Inspector inspector = new Inspector();
            inspector.Qualifications = new List<Qualification>();
            inspector.Qualifications.Add(new Qualification("Hammer", true));

            Job job = new Job();
            job.RequiredQualification = new Qualification("Hammer", true);

            var result = job.CheckInspectorQualifications(inspector);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CheckInspectorQualifications_InspectorIsNotQualified_ReturnFalse()
        {
            //Arrange
            Inspector inspector = new Inspector();
            inspector.Qualifications = new List<Qualification>();
            inspector.Qualifications.Add(new Qualification("Hammer", true));

            Job job = new Job();
            job.RequiredQualification = new Qualification("Painter", true);

            //Act
            var result = job.CheckInspectorQualifications(inspector);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CheckInspectorWeeklyAvailability_InspectorIsAvailable_ReturnTrue()
        {
            //Arrange
            DailyAvailability inspectorAvailability = new DailyAvailability("Monday", 8, 17, true);
            Inspector inspector = new Inspector();
            inspector.WeeklyAvailability = new List<DailyAvailability>();
            inspector.WeeklyAvailability.Add(inspectorAvailability);

            Job job = new Job();

            DateTime today = new DateTime(2018, 2, 5);
            job.Date = today;
            job.StartTime = 8;
            job.EndTime = 17;

            //Act
            var result = job.CheckInspectorWeeklyAvailability(inspector);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CheckInspectorWeeklyAvailability_InspectorIsNotAvailable_ReturnFalse()
        {
            //Arrange
            DailyAvailability inspectorAvailability = new DailyAvailability("Monday", 9, 17, true);
            Inspector inspector = new Inspector();
            inspector.WeeklyAvailability = new List<DailyAvailability>();
            inspector.WeeklyAvailability.Add(inspectorAvailability);

            Job job = new Job();

            DateTime today = new DateTime(2018, 2, 5);
            job.Date = today;
            job.StartTime = 8;
            job.EndTime = 17;

            //Act
            var result = job.CheckInspectorWeeklyAvailability(inspector);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CheckInspectorAssignments_InspectorCantBeAssignedToJob_ReturnFalse()
        {
            //Arrange

            Inspector inspector = new Inspector();
            inspector.AssignedJobs = new List<Job>();
            Job inspectorJob = new Job();
            inspectorJob.StartTime = 7;
            inspectorJob.EndTime = 9;
            inspectorJob.Date = new DateTime(2018, 2, 5);
            inspector.AssignedJobs.Add(inspectorJob);

            Job job = new Job();
            job.StartTime = 8;
            job.EndTime = 12;
            job.Date = new DateTime(2018, 2, 5);

            //Act
            var result = job.CheckInspectorAssignments(inspector);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CheckInspectorAssignments_InspectorJobStartsAndEndsBeforeCurrentJob_ReturnTrue()
        {
            //Arrange

            Inspector inspector = new Inspector();
            inspector.AssignedJobs = new List<Job>();
            Job inspectorJob = new Job();
            inspectorJob.StartTime = 8;
            inspectorJob.EndTime = 12;
            inspectorJob.Date = new DateTime(2018, 2, 5);
            inspector.AssignedJobs.Add(inspectorJob);

            Job job = new Job();
            job.StartTime = 12;
            job.EndTime = 17;
            job.Date = new DateTime(2018, 2, 5);

            //Act
            var result = job.CheckInspectorAssignments(inspector);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CheckInspectorAssignments_InspectorJobStartsAndEndsAfterCurrentJob_ReturnTrue()
        {
            //Arrange

            Inspector inspector = new Inspector();
            inspector.AssignedJobs = new List<Job>();
            Job inspectorJob = new Job();
            inspectorJob.StartTime = 12;
            inspectorJob.EndTime = 17;
            inspectorJob.Date = new DateTime(2018, 2, 5);
            inspector.AssignedJobs.Add(inspectorJob);

            Job job = new Job();
            job.StartTime = 8;
            job.EndTime = 12;
            job.Date = new DateTime(2018, 2, 5);

            //Act
            var result = job.CheckInspectorAssignments(inspector);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CheckInspectorAssignments_InspectorCanBeAssignedToJobDueToJobBeingOnDifferentDay_ReturnTrue()
        {
            //Arrange
            Inspector inspector = new Inspector();
            inspector.AssignedJobs = new List<Job>();
            Job inspectorJob = new Job();
            inspectorJob.StartTime = 8;
            inspectorJob.EndTime = 17;
            inspectorJob.Date = new DateTime(2018, 2, 3);
            inspector.AssignedJobs.Add(inspectorJob);

            Job job = new Job();
            job.StartTime = 8;
            job.EndTime = 12;
            job.Date = new DateTime(2018, 2, 5);

            //Act
            var result = job.CheckInspectorAssignments(inspector);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CheckInspectorAvailability_InspectorIsAvailable_ReturnTrue()
        {
            //Arrange
            Inspector inspector = new Inspector();
            inspector.Qualifications = new List<Qualification>();
            inspector.Qualifications.Add(new Qualification("Hammer", true));

            DailyAvailability inspectorAvailability = new DailyAvailability("Monday", 8, 17, true);
            inspector.WeeklyAvailability = new List<DailyAvailability>();
            inspector.WeeklyAvailability.Add(inspectorAvailability);

            Job inspectorJob = new Job();
            inspector.AssignedJobs = new List<Job>();
            inspectorJob.StartTime = 12;
            inspectorJob.EndTime = 17;
            inspectorJob.Date = new DateTime(2018, 2, 5);
            inspector.AssignedJobs.Add(inspectorJob);

            Job job = new Job();
            job.RequiredQualification = new Qualification("Hammer", true);
            DateTime today = new DateTime(2018, 2, 5);
            job.Date = today;
            job.StartTime = 8;
            job.EndTime = 12;

            //Act
            var result = job.CheckInspectorAvailability(inspector);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CheckInspectorAvailability_InspectorIsNotAvailable_ReturnFalse()
        {
            //Arrange
            Inspector inspector = new Inspector();
            inspector.Qualifications = new List<Qualification>();
            inspector.Qualifications.Add(new Qualification("Hammer", true));

            DailyAvailability inspectorAvailability = new DailyAvailability("Monday", 8, 17, true);
            inspector.WeeklyAvailability = new List<DailyAvailability>();
            inspector.WeeklyAvailability.Add(inspectorAvailability);

            Job inspectorJob = new Job();
            inspector.AssignedJobs = new List<Job>();
            inspectorJob.StartTime = 7;
            inspectorJob.EndTime = 9;
            inspectorJob.Date = new DateTime(2018, 2, 5);
            inspector.AssignedJobs.Add(inspectorJob);

            Job job = new Job();
            job.RequiredQualification = new Qualification("Hammer", true);
            DateTime today = new DateTime(2018, 2, 5);
            job.Date = today;
            job.StartTime = 8;
            job.EndTime = 12;

            //Act
            var result = job.CheckInspectorAvailability(inspector);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void AddInspector_InspectorIdDoesNotEqualsJobInspectorId_AssignsJobInspectorIDto2()
        {
            //Arrange
            //Arrange
            Inspector inspector = new Inspector();
            inspector.Qualifications = new List<Qualification>();
            inspector.Qualifications.Add(new Qualification("Hammer", true));
            inspector.InspectorID = 2;

            DailyAvailability inspectorAvailability = new DailyAvailability("Monday", 8, 17, true);
            inspector.WeeklyAvailability = new List<DailyAvailability>();
            inspector.WeeklyAvailability.Add(inspectorAvailability);

            Job inspectorJob = new Job();
            inspector.AssignedJobs = new List<Job>();
            inspectorJob.StartTime = 12;
            inspectorJob.EndTime = 17;
            inspectorJob.Date = new DateTime(2018, 2, 5);
            inspector.AssignedJobs.Add(inspectorJob);

            Job job = new Job();
            job.RequiredQualification = new Qualification("Hammer", true);
            DateTime today = new DateTime(2018, 2, 5);
            job.Date = today;
            job.StartTime = 8;
            job.EndTime = 12;

            //Act
            var result = job.AddInspector(inspector);

            //Assert
            Assert.That(job.InspectorID, Is.EqualTo(2));
        }

        [Test]
        public void ToString_ReturnsCorrectToString()
        {
            //Arrange
            Job job = new Job("The Job", "This is a great job", new DateTime(2018, 2, 5), 8, 17, new Qualification("Hammer", true));

            //Act
            var result = job.ToString();

            //Assert
            Assert.That(result, Is.EqualTo("2/5/2018 The Job This is a great job Hammer"));
        }
    }
}