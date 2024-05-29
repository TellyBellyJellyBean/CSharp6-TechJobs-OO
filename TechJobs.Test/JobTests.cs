
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //initalize your testing objects here
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreNotEqual(job1.Id, job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            // Console.WriteLine(job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName);
            Assert.AreEqual("Desert", job3.EmployerLocation);
            Assert.AreEqual("Quality control", job3.JobType);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency);
            // Assert.AreEqual("Product tester", job3.Name);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Id.Equals(job4.Id));
            Assert.IsTrue(job3.Id.Equals(3));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string testNewLineResult = job3.ToString();
            
            Assert.IsTrue(testNewLineResult.StartsWith(Environment.NewLine));
            Assert.IsTrue(testNewLineResult.EndsWith(Environment.NewLine));

        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string testNewLineResult = job3.ToString();
            
            Assert.IsTrue(testNewLineResult.StartsWith(Environment.NewLine));
            Assert.IsTrue(testNewLineResult.EndsWith(Environment.NewLine));

        }
        
    }
}

//assert.isfalse(job3.equals(job4));

