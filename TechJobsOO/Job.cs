using System;
namespace TechJobsOO
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

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string value, Employer employername, Location employerlocation, PositionType jobtype, CoreCompetency jobcorecompetency) : this()
        {
            Name = value;
            EmployerName = employername;
            EmployerLocation = employerlocation;
            JobType = jobtype;
            JobCoreCompetency = jobcorecompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string desc =
                $"_____\n" +
                $"ID: {Id}\n" +
                $"Name: {(!String.IsNullOrEmpty(Name) ? Name : "Data is not available") }\n" +
                $"Employer: {(!String.IsNullOrEmpty(EmployerName.ToString()) ? EmployerName.ToString() : "Data is not available") }\n" +
                $"Location: {(!String.IsNullOrEmpty(EmployerLocation.ToString()) ? EmployerLocation.ToString() : "Data is not available") }\n" +
                $"Position Type: {(!String.IsNullOrEmpty(JobType.ToString()) ? JobType.ToString() : "Data is not available") }\n" +
                $"Core Competency: {(!String.IsNullOrEmpty(JobCoreCompetency.ToString()) ? JobCoreCompetency.ToString() : "Data is not available") }\n" +
                $"_____";

            return desc;
        }

    }
}
