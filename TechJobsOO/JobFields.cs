using System;
namespace TechJobsOO
{
    public class JobField
    {
        private int Id { get; }
        private static int nextId = 1;
        private string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField jobfield &&
                   Id == jobfield.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
