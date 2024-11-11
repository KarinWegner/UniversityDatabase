using System.ComponentModel.DataAnnotations;

namespace UniversityDatabase.Models.ViewModels
{
    public class StudentCreateViewModel
    {
        public int Id { get; set; }
      
        public string NameFirstName { get; set; }
        public string NameLastName { get; set; }
        public string Email { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressZipCode { get; set; }
    }
}
