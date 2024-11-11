namespace UniversityDatabase.Models.ViewModels
{
    public class StudentIndexViewModel
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string NameFullName { get; set; }
        public string AddressCity { get; set; }

        public IEnumerable<CourseInfo> CourseInfos { get; set; }
    }

    public class CourseInfo
    {
        public int Grade { get; set; }
        public string CourseName { get; set; }
    }
}
