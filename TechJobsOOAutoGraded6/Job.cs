using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
namespace TechJobsOOAutoGraded6
{
	public class Job 
	{
        

            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }


        // TODO: Task 3: Add the two necessary constructors.
            public Job()
            {
                Id = nextId;
                nextId++;
            }
        // public MakeIdUnique(int Id, int nextId)
        // {
        //     Id = nextId;
        //     nextId++;
        // }
            public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
            {
                Name = name;
                EmployerName = employerName;
                EmployerLocation = employerLocation;
                JobType = jobType;
                JobCoreCompetency = jobCoreCompetency;

            }


            public override bool Equals(object? obj)
            {
                return obj is Job job &&
                    Id == job.Id;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Id);
            }
        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  

        // TODO: Task 5: Generate custom ToString() method.

            public override string ToString()
            {
                string nl = Environment.NewLine;
                string dataNotAvailable = "Data not available";
                
                // if (Name == "")
                // {
                //     Console.WriteLine(dataNotAvailable);
                // }
                // if (EmployerName.Value == "")
                // {
                //     Console.WriteLine(dataNotAvailable);

                // }
                // if (EmployerLocation.Value == "")
                // {
                //     Console.WriteLine(dataNotAvailable);

                // }
                // if (JobType.Value == "")
                // {
                //     Console.WriteLine(dataNotAvailable);

                // }
                // if (JobCoreCompetency.Value == "")
                // {
                //     Console.WriteLine(dataNotAvailable);

                // }
                if (Name == "")
                {
                    Name = "Data not available";
                }
                if (EmployerName.Value == "")
                {
                    EmployerName.Value = "Data not available";
                }
                if (EmployerLocation.Value == "")
                {
                    EmployerLocation.Value = "Data not available";
                }
                if (JobType.Value == "")
                {
                    JobType.Value = "Data not available";
                }
                if (JobCoreCompetency.Value == "")
                { 
                    JobCoreCompetency.Value = "Data not available";
                }
                
                
                return 
                Environment.NewLine + 
                $"ID: {Id}" +
                nl +
                $"Name: {Name}" +
                nl +
                $"Employer: {EmployerName.Value}" +
                nl +
                $"Location: {EmployerLocation.Value}" +
                nl +
                $"Position Type: {JobType.Value}" +
                nl +
                $"Core Competency: {JobCoreCompetency.Value}" +
                Environment.NewLine;
            }
        //Until you create this method, you will not be able to print a job to the console.



    }
}

