using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDatabase.Core.Entities
{
    public  class Enrollment
    {
        public int Grade {  get; set; }

        //Convention 1 och 3 
       // public Student Student { get; set; }
     
        //Convention 4 Add foreign key.

        //Foreign Key
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        //Navigational property
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
