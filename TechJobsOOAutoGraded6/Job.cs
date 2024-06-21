﻿using System;

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

        public Job(
            string name,
            Employer employerName,
            Location employerLocation,
            PositionType jobType,
            CoreCompetency jobCoreCompetency
        )
            : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object? obj)
        {
            return obj is Job job && Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5.1: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

        public override string ToString()
        {
            string line = Environment.NewLine;
            string PositionName;
            string CompanyName;
            string CompanyLocation;
            string PositionType;
            string CoreCompetency;

            if (EmployerName.Value == "")
            {
                CompanyName = "Data not available";
            }
            else
            {
                CompanyName = EmployerName.Value;
            }
            if (EmployerLocation.Value == "")
            {
                CompanyLocation = "Data not available";
            }
            else
            {
                CompanyLocation = EmployerLocation.Value;
            }
            if (JobType.Value == "")
            {
                PositionType = "Data not available";
            }
            else
            {
                PositionType = JobType.Value;
            }
            if (JobCoreCompetency.Value == "")
            {
                CoreCompetency = "Data not available";
            }
            else
            {
                CoreCompetency = JobCoreCompetency.Value;
            }
            if (Name == "")
            {
                PositionName = "Data not available";
            }
            else
            {
                PositionName = Name;
            }

            return line
                + "ID: "
                + Id
                + line
                + "Name: "
                + PositionName
                + line
                + "Employer: "
                + CompanyName
                + line
                + "Location: "
                + CompanyLocation
                + line
                + "Position Type: "
                + PositionType
                + line
                + "Core Competency: "
                + CoreCompetency
                + line;
        }
    }
}
