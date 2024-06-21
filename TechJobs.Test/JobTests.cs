namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );

        Job job4 = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );

        Job job5 = new Job(
            "Product tester",
            new Employer("Acme"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("")
        );

        [TestMethod]
        public void TestSettingJobId()
        {
            //verifies that the condition is false, meaning the values should not be equal
            bool areEqual = job1.Id == job2.Id;

            Assert.IsFalse(areEqual, $"The values {job1.Id} and {job2.Id} should not be equal.");

            Assert.IsTrue(
                job2.Id - job1.Id == 1,
                $"The values {job1.Id} and {job2.Id} should have IDs that differ by 1."
            );
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(
                "Product tester",
                job3.Name,
                $"{job3.Name} should be equal to 'product tester'."
            );
            Assert.AreEqual(
                "ACME",
                job3.EmployerName.Value,
                $"{job3.EmployerName} should be equal to 'ACME'."
            );
            Assert.AreEqual(
                "Desert",
                job3.EmployerLocation.Value,
                $"{job3.EmployerLocation} should be equal to 'Desert'."
            );
            Assert.AreEqual(
                "Quality control",
                job3.JobType.Value,
                $"{job3.JobType} should be equal to 'Quality control.'"
            );
            Assert.AreEqual(
                "Persistence",
                job3.JobCoreCompetency.Value,
                $"{job3.JobCoreCompetency} should be equal to 'Persistence'."
            );
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.AreNotEqual(job3, job4);
        }

        [TestMethod]
        // Task 5.1
        // had to change job3 into a string in order to use the starts with and ends with methods on it
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData() { 
            Assert.AreEqual(
                "Persistence",
                job3.JobCoreCompetency.Value,
                $"{job3.JobCoreCompetency} should be equal to 'Persistence'."
            );
        }

        [TestMethod]
        // If a field is empty, the method should add, “Data not available” after the label.

        public void TestToStringHandlesEmptyField() {
            Assert.AreEqual("Data not available", job5.JobCoreCompetency.Value, $"The value {job5.JobCoreCompetency.Value} should be equal to 'Data not available'.");
        }
    }
}
