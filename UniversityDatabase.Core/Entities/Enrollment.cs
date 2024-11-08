using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDatabase.Core.Entities
{
    public  class Enrollment
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public int Grade {  get; set; }

        //Convention 1

        public Student Student { get; set; }
        
    }
}
