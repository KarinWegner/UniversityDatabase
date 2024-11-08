using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDatabase.Core.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        
        public Name Name { get; set; }
        public string Email { get; set; }

        //Navigational property
        public Address Address { get; set; } = new Address();

        //Convention 2 och 3
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        public ICollection<Course> Courses { get; set; } = new List<Course>();
        private Student()
        {
            Avatar = null!;
            Name = null!;
            Email = null!;
        }

        public Student(string avatar, Name name , string email)
        {
            Avatar = avatar;
            Name = name;

            Email = email;
        }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { set; get; }

        public string FullName => $"{FirstName} {LastName}";

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
