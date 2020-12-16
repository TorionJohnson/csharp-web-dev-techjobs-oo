using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace JobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            TechJobsOO.Job job1 = new TechJobsOO.Job();
            TechJobsOO.Job job2 = new TechJobsOO.Job();

            Assert.AreEqual(2, job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            TechJobsOO.Job job1 = new TechJobsOO.Job("Product tester", new TechJobsOO.Employer("ACME"), new TechJobsOO.Location("Desert"), new TechJobsOO.PositionType("Quality control"), new TechJobsOO.CoreCompetency("Persistence"));

            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.ToString());
            Assert.AreEqual("Desert", job1.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job1.JobType.ToString());
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            TechJobsOO.Job job1 = new TechJobsOO.Job("Product tester", new TechJobsOO.Employer("ACME"), new TechJobsOO.Location("Desert"), new TechJobsOO.PositionType("Quality control"), new TechJobsOO.CoreCompetency("Persistence"));
            TechJobsOO.Job job2 = new TechJobsOO.Job("Product tester", new TechJobsOO.Employer("ACME"), new TechJobsOO.Location("Desert"), new TechJobsOO.PositionType("Quality control"), new TechJobsOO.CoreCompetency("Persistence"));

            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestJobsForToStringBlankLines()
        {
            TechJobsOO.Job job = new TechJobsOO.Job("Product tester", new TechJobsOO.Employer("ACME"), new TechJobsOO.Location("Desert"), new TechJobsOO.PositionType("Quality control"), new TechJobsOO.CoreCompetency("Persistence"));

            Assert.IsTrue(job.ToString().StartsWith("_____"));
            Assert.IsTrue(job.ToString().EndsWith("_____"));

        }

        [TestMethod]
        public void TestJobsForToStringDataNotAvailable()


        {
            TechJobsOO.Job job = new TechJobsOO.Job("", new TechJobsOO.Employer(""), new TechJobsOO.Location(""), new TechJobsOO.PositionType(""), new TechJobsOO.CoreCompetency(""));

            Assert.AreEqual($"_____\n" +
                $"ID: {job.Id}\n" +
                $"Name: Data is not available\n" +
                $"Employer: Data is not available\n" +
                $"Location: Data is not available\n" +
                $"Position Type: Data is not available\n" +
                $"Core Competency: Data is not available\n" +
                $"_____", job.ToString());
        }
    }
}